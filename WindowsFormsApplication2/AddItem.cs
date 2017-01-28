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
        public AddItem()
        {
            InitializeComponent();
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
            txtdate.Text = DateTime.Now.ToString();
            connection.Open();
            string getpurcahse_id = "SELECT purchase_item_id + 1 FROM purchase_item ORDER BY purchase_item_id DESC LIMIT 1";
            MySqlCommand pid = new MySqlCommand(getpurcahse_id, connection);
            MySqlDataReader mdr;
            mdr = pid.ExecuteReader();
            mdr.Read();
            txtPid.Text = mdr.GetString("purchase_item_id + 1");
            mdr.Close();
            connection.Close();
        }

        private void txtdate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
