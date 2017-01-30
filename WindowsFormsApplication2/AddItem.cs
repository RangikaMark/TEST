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
        List<string> barcodeNumbers = new List<string>();
        List<string> barcodeTable = new List<string>();
        string partno;
        string company_PartNo;
        string supplier;
        string date_time;
        string barcode;
        string supplierId;
        string countryID;
        string vehicle;
        string vBrandId;
        string cost;
        string itemBrandId;
        string partName;
        string nameTxt;
        string cmbSupTxt;
        string cmbCountryTxt;
        string cmbVName;
        string cmbVBrandTxt;

        string cmbItemBTxt;
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
                barcodeTable.Add(txtBarcode.Text);
            }
            bmdr.Close();
            connection.Close();

        }



        MySqlConnection connection = new MySqlConnection("datasource=localhost;Database=hashini_auto;port=3306;username=root;password=");

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
            txtBarcode.KeyDown += new KeyEventHandler(this.txtbarcodeKeyPress);
            cmbCountry.KeyDown += new KeyEventHandler(this.cmbKeyDown);
            cmbItemBrand.KeyDown += new KeyEventHandler(this.cmbKeyDown);
            cmbPartName.KeyDown += new KeyEventHandler(this.cmbKeyDown);
            cmbSup.KeyDown += new KeyEventHandler(this.cmbKeyDown);
            cmbV.KeyDown += new KeyEventHandler(this.cmbKeyDown);
            cmbVBrand.KeyDown += new KeyEventHandler(this.cmbKeyDown);
            txtCompanyNo.KeyDown += new KeyEventHandler(this.cmbKeyDown);
            txtCost.KeyDown += new KeyEventHandler(this.cmbKeyDown);
            txtPartNumber.KeyDown += new KeyEventHandler(this.cmbKeyDown);


        }
        private void txtbarcodeKeyPress(object sender, KeyEventArgs e)
        {
            
            chkbarcode();

            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(txtBarcode.Text) || IsDigitsOnly(txtBarcode.Text))
                {
                    if (barcodeNumbers.Contains(txtBarcode.Text) || barcodeTable.Contains(txtBarcode.Text))
                    {
                        MessageBox.Show("Entered Barcode is already in the checkout table.");
                    }


                    else
                    {

                        txtPartNumber.Focus();
                        barcodeNumbers.Add(txtBarcode.Text);
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            txtBarcode.Focus();
            string d = DateTime.Now.ToString();
            txtdate.Text = Convert.ToDateTime(d).ToShortDateString();
            connection.Open();
            string getpurcahse_id = "SELECT purchase_item_id + 1 FROM purchase_item ORDER BY purchase_item_id DESC LIMIT 1";
            MySqlCommand pid = new MySqlCommand(getpurcahse_id, connection);
            MySqlDataReader mdr;
            mdr = pid.ExecuteReader();
            mdr.Read();
            txtPid.Text = mdr.GetString("purchase_item_id + 1");
            mdr.Close();
            connection.Close();

            Search fill = new Search();
            fill.fill_combo("supplier_name", "supplier", cmbSup); ;

            Stock purchase = new Stock();
            purchase.purchase_id("purchase_item_id + 1", "purchase_item_id", "purchase_item");

            Search fillCountry = new Search();
            fillCountry.fill_combo("country_name", "country", cmbCountry);

            Search fillVBrand = new Search();
            fillVBrand.fill_combo("brand_name", "vehicle_brand", cmbVBrand);

            Search fillIBrand = new Search();
            fillIBrand.fill_combo("items_brand_name", "items_brand", cmbItemBrand);

            Search fillIName = new Search();
            fillIName.fill_combo("part_type_name", "part_type", cmbPartName);


        }

        private void txtdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            partno = txtPartNumber.Text;
            company_PartNo = txtCompanyNo.Text;
            supplier = cmbSup.SelectedItem.ToString();
            date_time = txtdate.Text;
            barcode = txtBarcode.Text;
            cost = txtCost.Text;


            string insertCost = "INSERT INTO `hashini_auto`.`cost` (`cost`, `partNumber`, `company_part_no`) VALUES ('" + cost + "','" + partno + "','" + company_PartNo + "')";
            MySqlCommand cmdInsert = new MySqlCommand(insertCost, connection);
            connection.Open();
            cmdInsert.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Insert succesfully");

            Stock c_id = new Stock();
            string costID = c_id.purchase_id("cost_id", "cost_id", "cost");
            string vehicleCount = checkData("vehicle_type", "vehicle_name", cmbV.Text);
            string countryCount = checkData("country", "country_name", cmbCountry.Text);
            string itemBrandCount = checkData("items_brand", "items_brand_name", cmbItemBrand.Text);
            string vBrandCount = checkData("vehicle_brand", "brand_name", cmbVBrand.Text);
            Stock purchase = new Stock();
            string purchaseID = purchase.purchase_id("purchase_item_id", "purchase_item_id", "purchase_item");
            if (countryCount == "0" || vehicleCount == "0" || itemBrandCount == "0" || vBrandCount == "0")
            {


                if (countryCount == "0")
                {

                    insertData("country", "country_name", cmbCountry.Text);
                    countryID = select_id("country", "country_id", "country_name", cmbCountry.Text.ToString());
                    MessageBox.Show(countryID);
                }
                //     string purchaseID = p_id.purchase_id("purchase_item_id", "purchase_item_id", "purchase_item");




                if (vBrandCount == "0")
                {
                    insertData("vehicle_brand", "brand_name", cmbVBrand.Text.ToString());
                    vBrandId = select_id("vehicle_brand", "vehicle_brand_id", "brand_name", cmbVBrand.Text.ToString());
                    MessageBox.Show(vBrandId);
                    //   string purchaseID = p_id.purchase_id("purchase_item_id", "purchase_item_id", "purchase_item");

                }



                if (vehicleCount == "0")
                {
                    insertData("vehicle_type", "vehicle_name", cmbV.Text.ToString());
                    vehicle = select_id("vehicle_type", "vehicle_type_id", "vehicle_name", cmbV.Text.ToString());
                    MessageBox.Show(vehicle);
                    // string purchaseID = p_id.purchase_id("purchase_item_id", "purchase_item_id", "purchase_item");

                }
                if (itemBrandCount == "0")
                {

                    insertData("items_brand", "items_brand_name", cmbItemBrand.Text.ToString());
                    //          vehicle = select_id("country", "country_id", "country_name", cmbCountry.SelectedItem.ToString());
                    itemBrandId = select_id("items_brand", "items_brand_id", "items_brand_name", cmbItemBrand.Text.ToString());
                    MessageBox.Show(itemBrandId);
                    //  string itemBrandId = p_id.purchase_id("purchase_item_id", "purchase_item_id", "purchase_item");
                }







                /*   {
                       countryID = select_id("country", "country_id", "country_name", cmbCountry.SelectedItem.ToString());
                       MessageBox.Show(countryID);
                     //  string purchaseID = p_id.purchase_id("purchase_item_id", "purchase_item_id", "purchase_item");
                       string insertItemQuery = "INSERT INTO `hashini_auto`.`item_details` (`part_number`, `cost_price`, `barcode`, `supplier_id`, `purchase_id`, `vehicle_type_id`, `vehicle_brand_id`, `status_id`, `part_type_id`, `country_id`, `items_brand_id`, `company_part_no`) VALUES ('" + partno + "','" + costID + "','" + barcode + "','" + supplierId + "','" + purchaseID + "','" + vehicle + "','" + vBrandId + "','1','" + partName + "','" + countryID + "','" + itemBrandId + "','" + company_PartNo + "')";
                       MySqlCommand cmdItemInsert = new MySqlCommand(insertItemQuery, connection);
                       connection.Open();
                       cmdItemInsert.ExecuteNonQuery();
                       MessageBox.Show("Insert item succesfully");
                       connection.Close();
                   }*/
            }
            else
            {
                string ainsertItemQuery = "INSERT INTO `hashini_auto`.`item_details` (`part_number`, `cost_price`, `barcode`, `supplier_id`, `purchase_id`, `vehicle_type_id`, `vehicle_brand_id`, `status_id`, `part_type_id`, `country_id`, `items_brand_id`, `company_part_no`) VALUES ('" + partno + "','" + costID + "','" + barcode + "','" + supplierId + "','" + purchaseID + "','" + vehicle + "','" + vBrandId + "','1','" + partName + "','" + countryID + "','" + itemBrandId + "','" + company_PartNo + "')";
                MySqlCommand acmdItemInsert = new MySqlCommand(ainsertItemQuery, connection);
                connection.Open();
                acmdItemInsert.ExecuteNonQuery();
                MessageBox.Show("Insert item succesfully");
                connection.Close();
                cmbCountry.Text = "";
                cmbItemBrand.Text = "";
                //cmbItemBrand.Text = "";
                cmbPartName.Text = "";
                cmbSup.Text = "";
                txtPartNumber.Text = "";
                txtCost.Text = "";
                txtCompanyNo.Text = "";
                txtBarcode.Text = "";
                cmbPartName.Text = "";
                


            }


        }

         private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemBrandId = select_id("items_brand", "items_brand_id", "items_brand_name", cmbItemBrand.SelectedItem.ToString());
            MessageBox.Show(itemBrandId);
            cmbItemBTxt = cmbItemBrand.Text;
        }

        private void cmbVBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbV.Items.Clear();
            cmbV.Text = "";
            string Query = "SELECT vehicle_name FROM vehicle_type INNER JOIN vehicle_brand ON vehicle_brand.vehicle_brand_id = vehicle_type.vehicle_brand_id where vehicle_brand.brand_name = '";
            Search fillVehicle = new Search();
            fillVehicle.fill_combo_type(cmbVBrand, cmbV, Query, "vehicle_name");
            vBrandId = select_id("vehicle_brand", "vehicle_brand_id", "brand_name", cmbVBrand.SelectedItem.ToString());
            MessageBox.Show(vBrandId);
            cmbVBrandTxt = cmbVBrand.Text;

        }

        private void cmbSup_SelectedIndexChanged(object sender, EventArgs e)
        {
            supplierId = select_id("supplier", "supplier_id", "supplier_name", cmbSup.SelectedItem.ToString());
            MessageBox.Show(supplierId);
            cmbSupTxt = cmbSup.Text;
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            countryID = select_id("country", "country_id", "country_name", cmbCountry.SelectedItem.ToString());
            MessageBox.Show(countryID);
            cmbCountryTxt = cmbCountry.Text;
        }

        private void cmbV_SelectedIndexChanged(object sender, EventArgs e)
        {
            vehicle = select_id("vehicle_type", "vehicle_type_id", "vehicle_name", cmbV.SelectedItem.ToString());
            MessageBox.Show(vehicle);
            cmbVName = cmbV.Text;


        }

        private void cmbPartName_SelectedIndexChanged(object sender, EventArgs e)
        {
            partName = select_id("part_type", "part_type_id", "part_type_name", cmbPartName.SelectedItem.ToString());
            MessageBox.Show(partName);
            nameTxt = cmbPartName.Text;
        }

        private void txtCompanyNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {


        }

        private void cmbKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCompanyNo.Text = "";
                txtPartNumber.Text = "";
                txtCost.Text = "";
                txtPartNumber.Text = "";
                cmbPartName.Text = nameTxt;
                cmbSup.Text = cmbSupTxt;
                cmbV.Text = cmbVName;
                cmbVBrand.Text = cmbVBrandTxt;
                cmbItemBrand.Text = cmbItemBTxt;
                cmbCountry.Text = cmbCountryTxt;
                txtBarcode.Focus();


            }
        }

        private void txtPartNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}