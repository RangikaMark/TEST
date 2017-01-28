using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AutoParts
{

    public partial class Search : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;Database=hashini_auto;port=3306;username=root;password=");

        string brand;
        string type;
        string madeIn;
        string query;
        string company;
        string partTypeName;
        string partNumber;
        string countries;
        string quantity;
        string costPrice;
        string vName;
        string bName;


        public void fill_combo(string c_name,string t_name,ComboBox combo)
        {
            connection.Open();
            string selectQuery = "SELECT DISTINCT " + c_name + " FROM "+t_name;
            MySqlCommand command = new MySqlCommand(selectQuery, connection);
            MySqlDataReader mdr;
            try
            {

                mdr = command.ExecuteReader();
                while (mdr.Read())
                {
                    string sName = mdr.GetString(c_name);

                    combo.Items.Add(sName);

                }
                mdr.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void fill_combo_type(ComboBox combo, string Query, string c_name)
        {


            connection.Open();
            string b_name = combo.SelectedItem.ToString();
            string fQuery = Query + b_name + "'";
            MySqlCommand command = new MySqlCommand(fQuery, connection);
            MySqlDataReader mdr;
            try
            {
                mdr = command.ExecuteReader();
                while (mdr.Read())
                {
                    string bName = mdr.GetString(c_name);
                    com_vehicle_type.Items.Add(bName);
                }
                mdr.Close();
                connection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        void select_query(String sQuery, string getString, ComboBox combo)
        {

            connection.Open();
            MySqlCommand command = new MySqlCommand(sQuery, connection);
            MySqlDataReader mdr;
            try
            {
                mdr = command.ExecuteReader();
                while (mdr.Read())
                {
                    string bName = mdr.GetString(getString);
                    combo.Items.Add(bName);
                }
                mdr.Close();
                connection.Close();
            }
            catch
             (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        public Search()
        {
            InitializeComponent();
            searchGrid.CellPainting += new DataGridViewCellPaintingEventHandler(this.searchGrid_CellPainting);
            fill_combo("brand_name","vehicle_brand",com_brand);

            string sQuery = "SELECT items_brand_name FROM items_brand";
            select_query(sQuery, "items_brand_name", com_company);

            string cQuery = "SELECT country_name FROM country";
            select_query(cQuery, "country_name", com_made_in);

            connection.Open();
            string bQuery = "SELECT part_type_name FROM part_type";
            MySqlCommand command = new MySqlCommand(bQuery, connection);
            MySqlDataReader mdr;

            try
            {
                mdr = command.ExecuteReader();

                while (mdr.Read())
                {
                    string bName = mdr.GetString("part_type_name");
                    part_type.Items.Add(bName);
                }
                mdr.Close();
                connection.Close();

            }
            catch
             (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void Test_Load(object sender, EventArgs e)
        {






        }

        private void searchGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void com_brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            com_vehicle_type.Items.Clear();
            com_vehicle_type.Text = "";
            string Query = "SELECT vehicle_name FROM vehicle_type INNER JOIN vehicle_brand ON vehicle_brand.vehicle_brand_id = vehicle_type.vehicle_brand_id where vehicle_brand.brand_name = '";
            fill_combo_type(com_brand, Query, "vehicle_name");


        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            brand = com_brand.SelectedItem.ToString();
            type = com_vehicle_type.SelectedItem.ToString();
            if (com_made_in.SelectedItem == null)
            {
                madeIn = "";
            }
            else
            {
                madeIn = com_made_in.SelectedItem.ToString();
            }
            if (com_company.SelectedItem == null)
            {
                company = "";
            }
            else
            {
                company = com_company.SelectedItem.ToString();
            }

            for (int s = 0; s < part_type.Items.Count; s++)
            {
                if (part_type.GetItemChecked(s))
                {


                    string str = (string)part_type.Items[s];
                    if (company == "" && madeIn == "")
                    {
                        query = "select  count(*) from item_details inner join cost on cost.partNumber=item_details.part_number inner join part_type on item_details.part_type_id=part_type.part_type_id inner join vehicle_brand on item_details.vehicle_brand_id=vehicle_brand.vehicle_brand_id inner join vehicle_type on vehicle_type.vehicle_type_id=item_details.vehicle_type_id inner join country on item_details.country_id=country.country_id inner join items_brand on items_brand.items_brand_id=item_details.items_brand_id where part_type.part_type_name='" + str + "' and vehicle_brand.brand_name='" + brand + "'and vehicle_type.vehicle_name='" + type + "'"; //    where part_type.part_type_name='" + str+"' and vehicle_brand.brand_name='nissan'";

                    }
                    else if (company == "")
                    {
                        query = "select count(*) from item_details inner join cost on cost.partNumber=item_details.part_number  inner join part_type on item_details.part_type_id=part_type.part_type_id inner join vehicle_brand on item_details.vehicle_brand_id=vehicle_brand.vehicle_brand_id inner join vehicle_type on vehicle_type.vehicle_type_id=item_details.vehicle_type_id inner join country on item_details.country_id=country.country_id inner join items_brand on items_brand.items_brand_id=item_details.items_brand_id where part_type.part_type_name='" + str + "' and vehicle_brand.brand_name='" + brand + "'and vehicle_type.vehicle_name='" + type + "' and country.country_name='" + madeIn + "'";//    where part_type.part_type_name='" + str+"' and vehicle_brand.brand_name='nissan'";
                    }
                    else if (madeIn == "")
                    {
                        query = "select count(*) from item_details inner join cost on cost.partNumber=item_details.part_number  inner join part_type on item_details.part_type_id=part_type.part_type_id inner join vehicle_brand on item_details.vehicle_brand_id=vehicle_brand.vehicle_brand_id inner join vehicle_type on vehicle_type.vehicle_type_id=item_details.vehicle_type_id inner join country on item_details.country_id=country.country_id inner join items_brand on items_brand.items_brand_id=item_details.items_brand_id where part_type.part_type_name='" + str + "' and vehicle_brand.brand_name='" + brand + "'and vehicle_type.vehicle_name='" + type + "' and items_brand.items_brand_name='" + company + "'"; //    where part_type.part_type_name='" + str+"' and vehicle_brand.brand_name='nissan'";
                    }
                    else
                    {
                        query = "select count(*) from item_details inner join cost on cost.partNumber=item_details.part_number  inner join part_type on item_details.part_type_id=part_type.part_type_id inner join vehicle_brand on item_details.vehicle_brand_id=vehicle_brand.vehicle_brand_id inner join vehicle_type on vehicle_type.vehicle_type_id=item_details.vehicle_type_id inner join country on item_details.country_id=country.country_id inner join items_brand on items_brand.items_brand_id=item_details.items_brand_id where part_type.part_type_name='" + str + "' and vehicle_brand.brand_name='" + brand + "'and vehicle_type.vehicle_name='" + type + "' and country.country_name='" + madeIn + "' and items_brand.items_brand_name='" + company + "'"; //    where part_type.part_type_name='" + str+"' and vehicle_brand.brand_name='nissan'";
                    }
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    connection.Open();
                    MySqlDataReader qmdr;

                    qmdr = cmd.ExecuteReader();
                    while (qmdr.Read())
                    {


                        quantity = qmdr.GetString("count(*)");

                        //   this.searchGrid.Rows.Add(partNumber, partTypeName, countries, vName, bName, quantity, costPrice);
                    }
                    qmdr.Close();
                    connection.Close();

                    // MessageBox.Show(txt.ToString());
                }
                //  connection.Close();

                //    connection.Open();
                for (int i = 0; i < part_type.Items.Count; i++)
                {
                    if (part_type.GetItemChecked(i))
                    {


                        string str = (string)part_type.Items[i];
                        if (company == "" && madeIn == "")
                        {
                            query = " select   item_details.company_part_no ,part_type.part_type_name ,item_details.part_number,cost.cost,country.country_name,vehicle_brand.brand_name,vehicle_type.vehicle_name from item_details inner join cost on cost.partNumber=item_details.part_number inner join part_type on item_details.part_type_id=part_type.part_type_id inner join vehicle_brand on item_details.vehicle_brand_id=vehicle_brand.vehicle_brand_id inner join vehicle_type on vehicle_type.vehicle_type_id=item_details.vehicle_type_id inner join country on item_details.country_id=country.country_id inner join items_brand on items_brand.items_brand_id=item_details.items_brand_id where part_type.part_type_name='" + str + "' and vehicle_brand.brand_name='" + brand + "'and vehicle_type.vehicle_name='" + type + "'"; //    where part_type.part_type_name='" + str+"' and vehicle_brand.brand_name='nissan'";

                        }
                        else if (company == "")
                        {
                            query = " select  item_details.company_part_no, part_type.part_type_name ,item_details.part_number,cost.cost,country.country_name,vehicle_brand.brand_name,vehicle_type.vehicle_name from item_details inner join cost on cost.partNumber=item_details.part_number  inner join part_type on item_details.part_type_id=part_type.part_type_id inner join vehicle_brand on item_details.vehicle_brand_id=vehicle_brand.vehicle_brand_id inner join vehicle_type on vehicle_type.vehicle_type_id=item_details.vehicle_type_id inner join country on item_details.country_id=country.country_id inner join items_brand on items_brand.items_brand_id=item_details.items_brand_id where part_type.part_type_name='" + str + "' and vehicle_brand.brand_name='" + brand + "'and vehicle_type.vehicle_name='" + type + "' and country.country_name='" + madeIn + "'";//    where part_type.part_type_name='" + str+"' and vehicle_brand.brand_name='nissan'";
                        }
                        else if (madeIn == "")
                        {
                            query = " select  item_details.company_part_no, part_type.part_type_name ,item_details.part_number,cost.cost,country.country_name,vehicle_brand.brand_name,vehicle_type.vehicle_name from item_details inner join cost on cost.partNumber=item_details.part_number  inner join part_type on item_details.part_type_id=part_type.part_type_id inner join vehicle_brand on item_details.vehicle_brand_id=vehicle_brand.vehicle_brand_id inner join vehicle_type on vehicle_type.vehicle_type_id=item_details.vehicle_type_id inner join country on item_details.country_id=country.country_id inner join items_brand on items_brand.items_brand_id=item_details.items_brand_id where part_type.part_type_name='" + str + "' and vehicle_brand.brand_name='" + brand + "'and vehicle_type.vehicle_name='" + type + "' and items_brand.items_brand_name='" + company + "'"; //    where part_type.part_type_name='" + str+"' and vehicle_brand.brand_name='nissan'";
                        }
                        else
                        {
                            query = " select  item_details.company_part_no, part_type.part_type_name ,item_details.part_number,cost.cost,country.country_name,vehicle_brand.brand_name,vehicle_type.vehicle_name from item_details inner join cost on cost.partNumber=item_details.part_number  inner join part_type on item_details.part_type_id=part_type.part_type_id inner join vehicle_brand on item_details.vehicle_brand_id=vehicle_brand.vehicle_brand_id inner join vehicle_type on vehicle_type.vehicle_type_id=item_details.vehicle_type_id inner join country on item_details.country_id=country.country_id inner join items_brand on items_brand.items_brand_id=item_details.items_brand_id where part_type.part_type_name='" + str + "' and vehicle_brand.brand_name='" + brand + "'and vehicle_type.vehicle_name='" + type + "' and country.country_name='" + madeIn + "' and items_brand.items_brand_name='" + company + "'"; //    where part_type.part_type_name='" + str+"' and vehicle_brand.brand_name='nissan'";
                        }
                        MySqlCommand command = new MySqlCommand(query, connection);
                        connection.Open();
                        MySqlDataReader mdr;

                        mdr = command.ExecuteReader();
                        while (mdr.Read())
                        {

                            partTypeName = mdr.GetString("part_type_name");
                            partNumber = mdr.GetString("part_number");
                            countries = mdr.GetString("country_name");
                            //  quantity = mdr.GetString("count(*)");
                            costPrice = mdr.GetString("cost");
                            vName = mdr.GetString("vehicle_name");
                            bName = mdr.GetString("brand_name");
                            this.searchGrid.Rows.Add(partNumber, partTypeName, countries, vName, bName, quantity, costPrice);
                        }
                        mdr.Close();
                        connection.Close();

                        // MessageBox.Show(txt.ToString());
                    }

                }

            }
        }
               private void searchGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
                                                 Color.Gray, colIndex != searchGrid.ColumnCount - 1 ? 1 : 0, ButtonBorderStyle.Inset,
                                               Color.Gray, 1, ButtonBorderStyle.Inset);
        }
    


                   
                
           
    

    

        


    
    private void com_vehicle_type_SelectedIndexChanged(object sender, EventArgs e)
        {
           // 


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void com_made_in_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void com_company_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {



        }

       
        
         private void checkBox1_CheckedChanged_1(object sender, EventArgs e) { 

            if (checkBox1.Text == "Select All")
            {
                checkBox1.Text = "DeSelect All";
                SelectDeselectAll(true); // passing <strong>true </strong>so that all items will be checked
            }
            else
            {
                checkBox1.Text = "Select All";
                SelectDeselectAll(false); // passing false so that all items will be unchecked
            }
        }
        void SelectDeselectAll(bool Selected)
        {
            for (int i = 0; i < part_type.Items.Count; i++) // loop to set all items checked or unchecked
            {
                part_type.SetItemChecked(i, Selected);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.searchGrid.DataSource = null;
            this.searchGrid.Rows.Clear();
        }

       

     

        private void btn_edit_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Do you want to edit the search");
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to do new search", "New search", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.searchGrid.DataSource = null;
                this.searchGrid.Rows.Clear();
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
           
        }
    }
    }



