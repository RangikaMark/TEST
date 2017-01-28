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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void openInPanel(Form form)
        {
            form.TopLevel = false;
            mainPanel.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void payment_Click(object sender, EventArgs e)
        {
            openInPanel(new Payment());
        }

        private void customer_Click(object sender, EventArgs e)
        {
            openInPanel(new Customer());
        }

        private void search_Click(object sender, EventArgs e)
        {
            openInPanel(new Search());

        }

        private void supplier_Click(object sender, EventArgs e)
        {
            openInPanel(new Payment());
        }

        private void stock_Click(object sender, EventArgs e)
        {
            openInPanel(new Stock());
        }

        private void employee_Click(object sender, EventArgs e)
        {
            openInPanel(new Payment());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
