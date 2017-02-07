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
    public partial class AddItem : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;Database=hashini_auto;port=3306;username=root;password=");
        List
          <string> vehicles = new List<string>();
        List
            <string> Brands = new List<string>();
        //  string[] vehicles = new string[10];
        // string[] brands = new string[10];
        string partno;
        string company_PartNo;
        string supplier;
        string date_time;
        string supplierId;
        string countryID;
      
        
        string cost;
        string itemBrandId;
        string partName;
        string nameTxt;
        string cmbSupTxt;
        string cmbCountryTxt;
        
        string cmbVBrandTxt;
        string cmbItemBTxt;
        string bquery;
        string vquery;
        string binqery;
        string vinquery;
       

        public string select_id(string tname, string col_id, string col_chk, string Name)
        {
            string selectId = "SELECT " + col_id + " FROM `hashini_auto`.`" + tname + "` where " + col_chk + "='" + Name + "'";
            MySqlCommand cmdInsert = new MySqlCommand(selectId, connection);
            connection.Open();
            MySqlDataReader mdr;
            mdr = cmdInsert.ExecuteReader();
            mdr.Read();
            string coloumnId = mdr.GetString(col_id);
            connection.Close();
            return coloumnId;
        }
        public void insertData(string table, string col, string value)
        {
            string query = "INSERT INTO hashini_auto." + table + "(`" + col + "`) VALUES ('" + value + "')";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert" + table + "succesfully");
            connection.Close();
        }
        public string checkData(string table, string col, string data1)
        {
            string query = "select count(*) from " + table + " where " + col + "='" + data1 + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader mdr;
            connection.Open();
            mdr = cmd.ExecuteReader();
            mdr.Read();
            string result = mdr.GetString("count(*)");
            mdr.Close();
            connection.Close();
            return result;
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
        public AddItem()
        {
            InitializeComponent();
                

        }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void textBox10_TextChanged(object sender, EventArgs e) { }
        private void btnAddItem_Click(object sender, EventArgs e) { }

        private void AddItem_Load(object sender, EventArgs e)
        {
            txtPartNumber.Focus();
            string d = DateTime.Now.ToString();
            txtdate.Text = Convert.ToDateTime(d).ToShortDateString();
           
            Search fill = new Search();
            fill.fill_combo("supplier_name", "supplier", cmbSup); ;
            
            Search fillCountry = new Search();
            fillCountry.fill_combo("country_name", "country", cmbCountry);
            Search fillVBrand = new Search();
            fillVBrand.fill_combo("brand_name", "vehicle_brand", cmbVBrand);
            Search fillIBrand = new Search();
            fillIBrand.fill_combo("items_brand_name", "items_brand", cmbItemBrand);
            Search fillIName = new Search();
            fillIName.fill_combo("part_type_name", "part_type", cmbPartName);
        }
        private void txtdate_TextChanged(object sender, EventArgs e) { }
        private void btnAddItems_Click(object sender, EventArgs e)
        {
            if (txtCost.Text !="")
            {
                if (cmbVBrand.Text != "")
                {
                    if (Brands.Contains(cmbVBrand.Text))
                    {
                        for (int i = 0; i < chklistVehicle.Items.Count; i++)
                        {
                            if (chklistVehicle.GetItemChecked(i))
                            {
                                vehicles.Add((string)chklistVehicle.Items[i]);
                            }
                        }
                        
                    }
                    else
                    {
                        for (int i = 0; i < chklistVehicle.Items.Count; i++)
                        {
                            if (chklistVehicle.GetItemChecked(i))
                            {
                                vehicles.Add((string)chklistVehicle.Items[i]);
                            }

                        }
                        Brands.Add(cmbVBrand.Text);
                    }
                }
               
                int vcount = vehicles.Count();
                int bcount = Brands.Count();
                MessageBox.Show(vcount.ToString());
                MessageBox.Show(bcount.ToString());
                MessageBox.Show(Brands[0]);
                for (int i = 0; i < bcount; i++)
                {
                    bquery += "`vehicle_brand_id_" + (i) + "`,";
                    string selectQ = "select vehicle_brand_id from vehicle_brand where brand_name='" + Brands[i] + "'";
                    MySqlCommand cmd = new MySqlCommand(selectQ, connection);
                    MySqlDataReader mdr;
                    connection.Open();
                    mdr = cmd.ExecuteReader();
                    mdr.Read();
                    string brandID = mdr.GetString("vehicle_brand_id");
                    binqery += "" + brandID + ",";
                    mdr.Close();
                    connection.Close();
                }
                for (int i = 0; i < vcount; i++)
                {
                    vquery += "`vehicle_type_id_" + (i) + "`,";
                    string selectQ = "select vehicle_type_id from vehicle_type where vehicle_name='" + vehicles[i] + "'";
                    MySqlCommand cmd = new MySqlCommand(selectQ, connection);
                    MySqlDataReader mdr;
                    connection.Open();
                    mdr = cmd.ExecuteReader();
                    mdr.Read();
                    string vehicleID = mdr.GetString("vehicle_type_id");
                    vinquery += "" + vehicleID + ",";
                    mdr.Close();
                    connection.Close();
                }
                MessageBox.Show(vquery);
                MessageBox.Show(vinquery);
                MessageBox.Show(bquery);
                MessageBox.Show(binqery);
                partno = txtPartNumber.Text;
                company_PartNo = txtCompanyNo.Text;
                supplier = cmbSup.SelectedItem.ToString();
                date_time = txtdate.Text;
                cost = txtCost.Text;
                string insertCost = "INSERT INTO `hashini_auto`.`cost` (`cost`, `partNumber`, `company_part_no`) VALUES ('" + cost + "','" + partno + "','" + company_PartNo + "')";
                MySqlCommand cmdInsert = new MySqlCommand(insertCost, connection);
                connection.Open();
                cmdInsert.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(" cost Insert succesfully");
                Stock c_id = new Stock();
                string costID = c_id.purchase_id("cost_id", "cost_id", "cost");
               
                string countryCount = checkData("country", "country_name", cmbCountry.Text);
                string itemBrandCount = checkData("items_brand", "items_brand_name", cmbItemBrand.Text);
                string vBrandCount = checkData("vehicle_brand", "brand_name", cmbVBrand.Text);
                Stock purchase = new Stock();
                
                if (countryCount == "0" || itemBrandCount == "0" )
                {
                    if (countryCount == "0")
                    {
                        insertData("country", "country_name", cmbCountry.Text);
                        countryID = select_id("country", "country_id", "country_name", cmbCountry.Text.ToString());
                        MessageBox.Show(countryID);
                    }
                    if (itemBrandCount == "0")
                    {
                        insertData("items_brand", "items_brand_name", cmbItemBrand.Text.ToString());
                        itemBrandId = select_id("items_brand", "items_brand_id", "items_brand_name", cmbItemBrand.Text.ToString());
                        MessageBox.Show(itemBrandId);
                    }
                }
                string ainsertItemQuery = "INSERT INTO `hashini_auto`.`item_details` (`part_number`, `cost_price`, `supplier_id`, " + bquery + " `part_type_id`," + vquery + " `country_id`, `items_brand_id`, `company_part_no`) VALUES ('" + partno + "','" + costID + "','" + supplierId +"'," + binqery + "'" + partName + "'," + vinquery +"'" + countryID + "','" + itemBrandId + "','" + company_PartNo + "')";
                MySqlCommand acmdItemInsert = new MySqlCommand(ainsertItemQuery, connection);
                connection.Open();
                acmdItemInsert.ExecuteNonQuery();
                MessageBox.Show("Insert item succesfully");
                connection.Close();
                cmbCountry.Text = "";
                cmbItemBrand.Text = "";
                cmbPartName.Text = "";
                
                txtPartNumber.Text = "";
                txtCost.Text = "";
                txtCompanyNo.Text = "";
                cmbPartName.Text = "";
            }
            
            {

                MessageBox.Show("Please complete all fields");
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSup.Text == "")
            {
                MessageBox.Show("Please Select a Country");
            }
            else
            {
                itemBrandId = select_id("items_brand", "items_brand_id", "items_brand_name", cmbItemBrand.SelectedItem.ToString());
                MessageBox.Show(itemBrandId);
                cmbItemBTxt = cmbItemBrand.Text;
            }
        }
        private void cmbVBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSup.Text == "")
            {
                MessageBox.Show("Please Select a Item Brand");
            }
            else
            {
                chklistVehicle.Items.Clear();

                string bQuery = "SELECT vehicle_name FROM vehicle_type INNER JOIN vehicle_brand ON vehicle_brand.vehicle_brand_id = vehicle_type.vehicle_brand_id where vehicle_brand.brand_name = '" + cmbVBrand.Text + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(bQuery, connection);
                MySqlDataReader mdr;
                try
                {
                    mdr = command.ExecuteReader();
                    while (mdr.Read())
                    {
                        string bName = mdr.GetString("vehicle_name");
                        chklistVehicle.Items.Add(bName);
                    }
                    mdr.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cmbVBrandTxt = cmbVBrand.Text;
            }
        }
        private void cmbSup_SelectedIndexChanged(object sender, EventArgs e)
        {
            supplierId = select_id("supplier", "supplier_id", "supplier_name", cmbSup.SelectedItem.ToString());
            MessageBox.Show(supplierId);
            cmbSupTxt = cmbSup.Text;
        }
        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSup.Text == "")
            {
                MessageBox.Show("Please Select a Part Type");
            }
            else
            {
                countryID = select_id("country", "country_id", "country_name", cmbCountry.SelectedItem.ToString());
                MessageBox.Show(countryID);
                cmbCountryTxt = cmbCountry.Text;
            }
        }
       
        private void cmbPartName_SelectedIndexChanged(object sender, EventArgs e)
        {
            partName = select_id("part_type", "part_type_id", "part_type_name", cmbPartName.SelectedItem.ToString());
            MessageBox.Show(partName);
            nameTxt = cmbPartName.Text;
        }
        private void txtCompanyNo_TextChanged(object sender, EventArgs e) { }
        private void txtBarcode_TextChanged(object sender, EventArgs e) { }

       
        private void txtPartNumber_TextChanged(object sender, EventArgs e) {

            if (cmbSup.Text == "")
            {
                MessageBox.Show("Please fill the supplier field");

            }
        }
     

        private void txtCost_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void chklistVehicle_SelectedIndexChanged(object sender, EventArgs e) { }
        private void chkotherB_CheckedChanged(object sender, EventArgs e)
        {
            if (chkotherB.Checked == true)
            {
                if (Brands.Contains(cmbVBrand.Text))
                {
                    for (int i = 0; i < chklistVehicle.Items.Count; i++)
                    {
                        if (chklistVehicle.GetItemChecked(i))
                        {
                            vehicles.Add((string)chklistVehicle.Items[i]);
                        }
                    }
                    chklistVehicle.Items.Clear();
                    cmbVBrand.Text = "";
                    chkotherB.Checked = false;
                }
                else
                {
                    for (int i = 0; i < chklistVehicle.Items.Count; i++)
                    {
                        if (chklistVehicle.GetItemChecked(i))
                        {
                            vehicles.Add((string)chklistVehicle.Items[i]);
                        }
                    }
                    Brands.Add(cmbVBrand.Text);
                    chklistVehicle.Items.Clear();
                    cmbVBrand.Text = "";
                    chkotherB.Checked = false;
                }
            }
        }

        private void txtPartNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode==Keys.Right) {
                if (txtCompanyNo.Text == "")
                {
                    txtCompanyNo.Focus();
                }
                
                
            }
        }

        private void txtCompanyPartNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) {
                txtPartNumber.Focus();
            }
        }
    }
    }
