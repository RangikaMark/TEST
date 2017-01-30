using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoParts.Properties;
using MySql.Data.MySqlClient;
namespace AutoParts
{
    public partial class Stock : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;Database=hashini_auto;port=3306;username=root;password=");
        List<string> barcodeNumbers = new List<string>();
        List<string> barcodeTable = new List<string>();
        string cmbpartValue;
        string cmbcomValue;
        public void chkbarcode()
        {
            connection.Open();
            string bquery = "select barcode from hashini_auto.item_details";
            MySqlCommand bcmd = new MySqlCommand(bquery, connection);
            MySqlDataReader bmdr;
            bmdr = bcmd.ExecuteReader();
            while (bmdr.Read()) ;
            { 
            string barcode = bmdr.GetString("barcode");
            barcodeTable.Add(txtbarcode.Text);
        } bmdr.Close();
            connection.Close();
            
        }

        public string purchase_id(string colcon,string col,string table) {

            connection.Open();
            string getpurcahse_id = "SELECT "+colcon+" FROM "+table+" ORDER BY "+col+" DESC LIMIT 1";
            MySqlCommand pid = new MySqlCommand(getpurcahse_id, connection);
            MySqlDataReader mdr;
            mdr = pid.ExecuteReader();
            mdr.Read();
            string lastId = mdr.GetString(colcon);
            mdr.Close();
            connection.Close();
            return lastId;
        }
        public void clear()
        {
            txtbarcode.Text = "";
            cmbcompanypartno.Text = "";
            cmbpartnumber.Text = "";
            cmbpartnumber.SelectedItem = null;
            cmbcompanypartno.SelectedItem = null;
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

        public Stock()
        {
            InitializeComponent();
            stockgrid.CellPainting += new DataGridViewCellPaintingEventHandler(this.stockgrid_CellPainting);
            txtbarcode.KeyDown += new KeyEventHandler(this.txtbarcodeKeyPress);
            cmbcompanypartno.KeyDown += new KeyEventHandler(this.cmbKeyDown);
            cmbpartnumber.KeyDown += new KeyEventHandler(this.cmbKeyDown);
        }
        private void txtbarcodeKeyPress(object sender, KeyEventArgs e)
        {
            chkbarcode();

            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(txtbarcode.Text) || IsDigitsOnly(txtbarcode.Text)|| !string.IsNullOrWhiteSpace(cmbcompanypartno.Text)|| !string.IsNullOrWhiteSpace(cmbpartnumber.Text))
                {
                    if (barcodeNumbers.Contains(txtbarcode.Text) || barcodeTable.Contains(txtbarcode.Text))
                    {
                        MessageBox.Show("Entered Barcode is already in the checkout table.");
                    }

                    else
                    {
                        connection.Open();
                        string partno;
                        string companyPartNo;
                        partno = cmbpartnumber.SelectedItem.ToString();
                        companyPartNo = cmbcompanypartno.SelectedItem.ToString();

                        string query = "Select part_number,cost,part_type.part_type_name,item_details.company_part_no from item_details inner join cost on cost.partNumber=item_details.part_number inner join part_type on part_type.part_type_id=item_details.part_type_id where item_details.part_number='" + partno + "' and item_details.company_part_no='" + companyPartNo + "'";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        MySqlDataReader mdr;

                        mdr = command.ExecuteReader();
                        mdr.Read();


                        string partTypeName = mdr.GetString("part_type_name");
                        string partNumber = mdr.GetString("part_number");
                        string cost = mdr.GetString("cost");
                        string comPartNo = mdr.GetString("company_part_no");
                        int sellingPricein = mdr.GetInt16("cost");
                        int sellingPrice = (sellingPricein + (sellingPricein * 35) / 100);
                        barcodeNumbers.Add(txtbarcode.Text);
                        //this.stockgrid.Rows.Add(txtbarcode.Text, partNumber, partTypeName, companyPartNo, cost, sellingPrice);

                        mdr.Close();
                        string count_query = "select count(*) from item_details where part_number='" + partNumber + "' AND company_part_no= '" + comPartNo + "'";
                        MySqlCommand countCmd = new MySqlCommand(count_query, connection);
                        MySqlDataReader cmdr;
                        cmdr = countCmd.ExecuteReader();
                        cmdr.Read();
                        string count = cmdr.GetString("count(*)");
                        this.stockgrid.Rows.Add(txtbarcode.Text, partNumber, partTypeName, companyPartNo, count, cost, sellingPrice);
                        cmdr.Close();
                        connection.Close();
                        clear();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Enter the Barcode correctly");
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtbarcode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Stock_Load(object sender, EventArgs e)
        {
            Search fill = new Search();
            fill.fill_combo("supplier_name", "supplier", cmbSuppliers);
            string d= DateTime.Now.ToString();
            txtdate.Text = Convert.ToDateTime(d).ToShortDateString();
            Search fillpart = new Search();
            fillpart.fill_combo("part_number", "item_details", cmbpartnumber);
            Search fillcompart = new Search();
            fillcompart.fill_combo("company_part_no", "item_details", cmbcompanypartno);
            txtpurchase_id.Text =purchase_id("purchase_item_id + 1", "purchase_item_id","purchase_item");
        }

        private void txtpartNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbpartnumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbpartValue = cmbpartnumber.Text;
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
           
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {

          //  string partno = cmbpartnumber.SelectedItem.ToString();
          //  string company_PartNo = cmbcompanypartno.SelectedItem.ToString();
            string supplier = cmbSuppliers.SelectedItem.ToString();
            string date_time = txtdate.Text;
            // connection.Open();
            for (int i = 0; i < ((stockgrid.Rows.Count) - 1); i++)
            {
                //connection.Open();

                string selectQuery = "select part_type.part_type_id,supplier.supplier_id,item_details.part_number,country.country_id,item_details.items_brand_id,vehicle_brand.vehicle_brand_id,vehicle_type.vehicle_type_id,item_details.company_part_no from item_details inner join part_type on item_details.part_type_id = part_type.part_type_id inner join supplier on item_details.supplier_id=supplier.supplier_id inner join vehicle_brand on item_details.vehicle_brand_id = vehicle_brand.vehicle_brand_id inner join vehicle_type on vehicle_type.vehicle_type_id = item_details.vehicle_type_id inner join items_brand on item_details.items_brand_id=items_brand.items_brand_id inner join country on item_details.country_id = country.country_id inner join cost on cost.partNumber=item_details.part_number where item_details.part_number = '" + stockgrid.Rows[i].Cells["part_number"].Value + "' AND item_details.company_part_no = '" + stockgrid.Rows[i].Cells["company_number"].Value + "'";
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                connection.Open();
                MySqlDataReader mdr;
                mdr = command.ExecuteReader();
                mdr.Read();
                string part_type_id = mdr.GetString("part_type_id");
                string part_number = mdr.GetString("part_number");
                string country_id = mdr.GetString("country_id");
                string vehicle_brand_id = mdr.GetString("vehicle_brand_id");
                string vehicle_type_id = mdr.GetString("vehicle_type_id");
                string supplier_id = mdr.GetString("supplier_id");
                string item_brand_id = mdr.GetString("items_brand_id");
                string companyPartNo = mdr.GetString("company_part_no");
                string cost = mdr.GetString("part_number");
                mdr.Close();
                connection.Close();
                string costmatch = "select cost.cost,cost.cost_id from cost where partNumber='" + stockgrid.Rows[i].Cells["part_number"].Value + "'and company_part_no='" + stockgrid.Rows[i].Cells["company_number"].Value + "'";
                MySqlCommand cmdcost = new MySqlCommand(costmatch, connection);
                connection.Open();
                MySqlDataReader cmdr;
                cmdr = cmdcost.ExecuteReader();
                cmdr.Read();
                string checkCost = cmdr.GetString("cost");
                string costId = cmdr.GetString("cost_id");
                cmdr.Close();
                connection.Close();
               // string cost= stockgrid.Rows[i].Cells["cost"].Value.
                if (checkCost == stockgrid.Rows[i].Cells["cost"].Value.ToString())
                {

                    string insertQuery = "INSERT INTO `hashini_auto`.`item_details` (`part_number`, `cost_price`, `barcode`, `supplier_id`,`purchase_id`, `vehicle_type_id`, `vehicle_brand_id`,`part_type_id`, `country_id`, `items_brand_id`, `company_part_no`) VALUES ('" + part_number + "','" + costId + "','" + stockgrid.Rows[i].Cells["barcode_number"].Value + "','" + supplier_id + "','300','" + vehicle_type_id + "','" + vehicle_brand_id + "','" + part_type_id + "','" + country_id + "','" + item_brand_id + "','" + companyPartNo + "')";// '1', '1', '1', '1', '1', '1', '1', '123');
                    MySqlCommand insercommand = new MySqlCommand(insertQuery, connection);
                    connection.Open();
                    insercommand.ExecuteNonQuery();
                    MessageBox.Show("data entered Succesfully");
                    connection.Close();
                }
                else
                {
                    string updateQuery = "UPDATE `hashini_auto`.`cost` SET `cost`= '" + stockgrid.Rows[i].Cells["cost"].Value + "' WHERE `cost_id`= '"+costId+"'";
                    MySqlCommand upquery = new MySqlCommand(updateQuery, connection);
                    connection.Open();
                    upquery.ExecuteNonQuery();
                    MessageBox.Show("data cost updated Succesfully");
                    connection.Close();
                    string purchaseID =purchase_id("purchase_item_id", "purchase_item_id", "purchase_item");
                    string insertQuery = "INSERT INTO `hashini_auto`.`item_details` (`part_number`, `cost_price`, `barcode`, `supplier_id`,`purchase_id`, `vehicle_type_id`, `vehicle_brand_id`,`part_type_id`, `country_id`, `items_brand_id`, `company_part_no`) VALUES ('" + part_number + "','" + cost + "','" + stockgrid.Rows[i].Cells["barcode_number"].Value + "','" + supplier_id + "','"+purchaseID+",'" + vehicle_type_id + "','" + vehicle_brand_id + "','" + part_type_id + "','" + country_id + "','" + item_brand_id + "','" + companyPartNo + "')";// '1', '1', '1', '1', '1', '1', '1', '123');
                    MySqlCommand insercommand = new MySqlCommand(insertQuery, connection);
                    connection.Open();
                    insercommand.ExecuteNonQuery();
                    MessageBox.Show("data entered Succesfully");
                    connection.Close();

                }
            }

            string purchase = "INSERT INTO `hashini_auto`.`purchase_item` (`purchase_item_id`, `purchase_date`, `supplier_id`, `order_id`) VALUES ('" + txtpurchase_id.Text + "','" + txtdate.Text + "',(select supplier_id from supplier where supplier_name='" + supplier + "'),'2')";
            MySqlCommand purchasecmd = new MySqlCommand(purchase, connection);
            connection.Open();
            purchasecmd.ExecuteNonQuery();
            MessageBox.Show("User crested Succesfully");
            connection.Close();

        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            var myForm = new AddItem();
            myForm.Show();

            //    this.Hide();
        }

        private void txtpurchase_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void stockgrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
                                                 Color.Gray, colIndex != stockgrid.ColumnCount - 1 ? 1 : 0, ButtonBorderStyle.Inset,
                                               Color.Gray, 1, ButtonBorderStyle.Inset);
        }

        private void txtdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void FALSE(object sender, KeyPressEventArgs e)
        {
           
        }

        private void cmbKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                cmbcompanypartno.Text = cmbcomValue;
                cmbpartnumber.Text = cmbpartValue;
               txtbarcode.Focus();
            }
        }

        private void cmbcompanypartno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbcomValue = cmbcompanypartno.Text;
        }
    }
}