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
    public partial class addVehicle : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;Database=hashini_auto;port=3306;username=root;password=");
        public addVehicle()
        {
            InitializeComponent();
        }

        private void addVehicle_Load(object sender, EventArgs e)
        {
            string sQuery = "SELECT brand_name FROM vehicle_brand";
            Search select = new Search();
            select.select_query(sQuery, "brand_name", cmb_brand);
           
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            if (cmb_brand.Items.Contains(cmb_brand.Text))
            {
                AddItem selectID = new AddItem();
                string BrandId = selectID.select_id("vehicle_brand", "vehicle_brand_id", "brand_name", cmb_brand.Text.ToString());
                string query = "INSERT INTO `hashini_auto`.`vehicle_type` (`vehicle_brand_id`, `vehicle_name`) VALUES ('" + BrandId + "', '" + txtvehicle.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();

              cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Vehicle added succesfully");
            }
            else
            {
                string iquery = "INSERT INTO `hashini_auto`.`vehicle_brand` (`brand_name`) VALUES ('"+cmb_brand.Text+"')";
                MySqlCommand cmd = new MySqlCommand(iquery, connection);
                connection.Open();

                cmd.ExecuteNonQuery();
                connection.Close();
                AddItem selectID = new AddItem();
                string BrandId = selectID.select_id("vehicle_brand", "vehicle_brand_id","brand_name", cmb_brand.Text.ToString());
                string query = "INSERT INTO `hashini_auto`.`vehicle_type` (`vehicle_brand_id`, `vehicle_name`) VALUES ('" + BrandId + "', '" + txtvehicle.Text + "')";
                MySqlCommand ccmd = new MySqlCommand(query, connection);
                connection.Open();

                ccmd.ExecuteNonQuery();
                connection.Close();
                txtvehicle.Text = "";
                MessageBox.Show("Vehicle added succesfully");
            }
        }
    }
}
