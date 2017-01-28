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
    public partial class Login : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;Database=hashini_auto;port=3306;username=root;password=");

        public Login()
      
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveFirstItem4_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem4_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSeparator12_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem4_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem4_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSeparator13_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem4_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem4_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSeparator14_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem4_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem4_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "Select password from hashini_auto.staff where user_name='"+ txtusername.Text + "'";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader mdr;

                mdr = command.ExecuteReader();
                mdr.Read();
                string password = mdr.GetString("password");
                if (txtpass.Text == password)
                {
                    MainMenu fm = new MainMenu();
                    this.Hide();
                    fm.Show();
                    fm.Closed += (s, args) => this.Close();
                    mdr.Close();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("You have entered a wrong paasword");

                }
            }
            catch
            {
                MessageBox.Show("You have entered a wrong username");
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new signup();
            myForm.Show();
           
            this.Hide();  

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
           
        }
      

        private void txtpass_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
            else
            {

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
