using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoParts
{

    public partial class Payment : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;Database=hashini_auto;port=3306;username=root;password=root");
        List<string> paymentGridColumns = new List<string>() {"barcodeCol", "partnoCol", "nameCol", "brandCol", "qtyCol", "discountCol", "priceCol", "subtotalCol" };
        List<string> barcodeNumbers = new List<string>();

        public Payment()
        {

            InitializeComponent();
            paymentGrid.CellPainting += new DataGridViewCellPaintingEventHandler(this.paymentGrid_CellPainting);
            paymentGrid.CellValueChanged += new DataGridViewCellEventHandler(this.cellChanged);
            paymentGrid.RowsAdded += new DataGridViewRowsAddedEventHandler(this.rowAdded);
            paymentGrid.UserDeletingRow += new DataGridViewRowCancelEventHandler(this.rowsRemovedInPaymentGrid);
            barcodeTxt.KeyDown += new KeyEventHandler(this.barcodeTxtKeyPress);
            comboBox1.SelectedIndex = 0;
        }

        private void barcodeTxtKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addItem(this, new EventArgs());
            }
        }

        private void rowsRemovedInPaymentGrid(object sender, DataGridViewRowCancelEventArgs e)
        {
            barcodeNumbers.RemoveAt(barcodeNumbers.IndexOf(e.Row.Cells[paymentGridColumns.IndexOf("barcodeCol")].Value.ToString()));
            setTotalValue();
        }

        private void rowAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            setTotalValue();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void paymentGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                e.PaintBackground(e.CellBounds, true);
                RenderColumnHeader(e.Graphics, e.CellBounds, e.CellBounds.Contains(hotSpot) ? hotSpotColor : backColor);
                RenderColumnHeaderBorder(e.Graphics, e.CellBounds, e.ColumnIndex);
                using (Brush brush = new SolidBrush(e.CellStyle.ForeColor))
                {
                    using (StringFormat sf = new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center })
                    {
                        e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, brush, e.CellBounds, sf);
                    }
                }
                e.Handled = true;
            }
        }
        Color hotSpotColor = Color.LightBlue;//For hover backcolor
        Color backColor = Color.LightBlue;    //For backColor    
        Point hotSpot;
        private char ba;

        private void RenderColumnHeader(Graphics g, Rectangle headerBounds, Color c)
        {
            int topHeight = 10;
            Rectangle topRect = new Rectangle(headerBounds.Left, headerBounds.Top + 1, headerBounds.Width, topHeight);
            RectangleF bottomRect = new RectangleF(headerBounds.Left, headerBounds.Top + 1 + topHeight, headerBounds.Width, headerBounds.Height - topHeight - 4);
            Color c1 = Color.FromArgb(180, c);
            using (SolidBrush brush = new SolidBrush(c1))
            {
                g.FillRectangle(brush, topRect);
                brush.Color = c;
                g.FillRectangle(brush, bottomRect);
            }
        }
        private void RenderColumnHeaderBorder(Graphics g, Rectangle headerBounds, int colIndex)
        {
            g.DrawRectangle(new Pen(Color.White, 0.1f), headerBounds.Left + 0.5f, headerBounds.Top + 0.5f, headerBounds.Width - 1f, headerBounds.Height - 1f);
            ControlPaint.DrawBorder(g, headerBounds, Color.Gray, 0, ButtonBorderStyle.Inset,
                                                   Color.Gray, 0, ButtonBorderStyle.Inset,
                                                 Color.Gray, colIndex != paymentGrid.ColumnCount - 1 ? 1 : 0, ButtonBorderStyle.Inset,
                                               Color.Gray, 1, ButtonBorderStyle.Inset);
        }
        //MouseMove event handler for your dataGridView1
        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            hotSpot = e.Location;
        }
        //MouseLeave event handler for your dataGridView1
        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            hotSpot = Point.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void enableAddButton(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(barcodeTxt.Text))
                addBtn.Enabled = false;
            else
                addBtn.Enabled = true;

        }

        private void cellChanged(object sender,DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == paymentGridColumns.IndexOf("priceCol") || e.ColumnIndex == paymentGridColumns.IndexOf("discountCol") || e.ColumnIndex == paymentGridColumns.IndexOf("qtyCol"))
            {
                calculateTheSubTotal(e.RowIndex);
            }
        }

        private void calculateTheSubTotal(int rowNumber)
        {
          
            String discount =  null;
            int qty = 1;
            int price = 0;
            if (paymentGrid.Rows[rowNumber].Cells[paymentGridColumns.IndexOf("discountCol")].Value != null && paymentGrid.Rows[rowNumber].Cells[paymentGridColumns.IndexOf("discountCol")].Value.ToString() != "")
            {
                discount = paymentGrid.Rows[rowNumber].Cells[paymentGridColumns.IndexOf("discountCol")].Value.ToString();                    
            }
                
            try{
                qty = int.Parse(paymentGrid.Rows[rowNumber].Cells[paymentGridColumns.IndexOf("qtyCol")].Value.ToString());
            } catch (Exception e)  {
                               
            }
            try {
                price = int.Parse(paymentGrid.Rows[rowNumber].Cells[paymentGridColumns.IndexOf("priceCol")].Value.ToString());
            } catch(Exception e) {

            }

            if (discount != null && discount.Contains("%"))
            {
                int discountVal = (price* int.Parse(discount.Replace("%", ""))) / 100;
                int newSubTotal = (price - discountVal) * qty;
                paymentGrid.Rows[rowNumber]
                    .Cells[paymentGridColumns.IndexOf("subtotalCol")].Value = newSubTotal;
            } else if(discount != null && IsDigitsOnly(discount))
            {
                int newSubTotal = (price - int.Parse(discount)) * qty;
                paymentGrid.Rows[rowNumber].Cells[paymentGridColumns.IndexOf("subtotalCol")].Value = newSubTotal;
            }

            else
            {
                paymentGrid.Rows[rowNumber].Cells[paymentGridColumns.IndexOf("subtotalCol")].Value = price * qty;
            }
            setTotalValue();
        }

        private void setTotalValue()
        {
            int total = 0;
            for (int counter = 0; counter < (paymentGrid.Rows.Count); counter++)
            {
                total += int.Parse(paymentGrid.Rows[counter]
                    .Cells[paymentGridColumns.IndexOf("subtotalCol")].Value.ToString());
            }
            totalLbl.Text = "Total : Rs. " + total.ToString();
        }

        private void addItem(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(barcodeTxt.Text) || IsDigitsOnly(barcodeTxt.Text)) {
                if (barcodeNumbers.Contains(barcodeTxt.Text))
                {
                    MessageBox.Show("Entered Barcode is already in the checkout table.");
                }
                else { 
                    connection.Open();
                    string selectQuery = "select part_number,item_name,selling_price from item_details where barcode="+barcodeTxt.Text+";";
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    try{
                        MySqlDataReader mdr = command.ExecuteReader();
                        while (mdr.Read())
                        {
                            String partNo = mdr.GetString("part_number");
                            String itemName = mdr.GetString("item_name");
                            String sellingPrice = mdr.GetString("selling_price");
                            this.paymentGrid.Rows.Add(int.Parse(barcodeTxt.Text), partNo, itemName, "test", 1, "", sellingPrice, sellingPrice);
                            barcodeNumbers.Add(barcodeTxt.Text);
                        }

                        mdr.Close();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    barcodeTxt.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Provided barcode number is wrong. Please re-check the number.");
            }
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void clear_button(object sender, EventArgs e)
        {
            barcodeNumbers = new List<string>();
            totalLbl.Text = "Total : Rs. 0";
            this.paymentGrid.Rows.Clear();
        }

        private void enableEditTheBarcode(object sender, EventArgs e)
        {

            if (enableEdit.Checked)
                barcodeTxt.Enabled = true;
            else
                barcodeTxt.Enabled = false;
        }

        private void itemsWithoutBarcodes(object sender, EventArgs e)
        {
            this.paymentGrid.Rows.Add(0, 0, "Items Without Barcodes", "Other", 1, "", 0, 0);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
