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
    public partial class signup : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;Database=hashini_auto;port=3306;username=root;password=");

        public signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            
            
              
                if (txtname.Text == String.Empty ||
    txtadress.Text == String.Empty ||
    txtcontactno.Text == String.Empty ||
    txtpassword.Text == String.Empty ||
    txtusername.Text == String.Empty ||
    txtadress.Text == String.Empty)
                {
                    MessageBox.Show("Please Fill the all fields");
                }
                else if (txtpassword.Text != txtrepass.Text)
            {
                MessageBox.Show("Passwords are not match");
            }
                else
            {
                connection.Open();
                string name = txtname.Text;
                string adress = txtadress.Text;
                string contact = txtcontactno.Text;
                string password = txtpassword.Text;
                string username = txtusername.Text;

                string selectQuery = "INSERT INTO `hashini_auto`.`staff` (`name`, `password`, `address`, `telephone_number`, `user_name`) VALUES('" + name + "', '" + password + "', '" + adress + "', '" + contact + "', '" + username + "')";
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("User crested Succesfully");
                    connection.Close();
                    var login = new Login();
                    login.Show();
                    this.Hide();
                }
            
            
        }

        private void signup_Load(object sender, EventArgs e)
        {
            
        }
    }
}
