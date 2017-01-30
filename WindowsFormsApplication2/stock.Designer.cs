namespace AutoParts
{
    partial class Stock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.stockgrid = new System.Windows.Forms.DataGridView();
            this.barcode_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.part_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.part_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selling_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbpartnumber = new System.Windows.Forms.ComboBox();
            this.cmbcompanypartno = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpurchase_id = new System.Windows.Forms.TextBox();
            this.btnNewItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // stockgrid
            // 
            this.stockgrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.stockgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode_number,
            this.part_number,
            this.part_name,
            this.company_number,
            this.quantity,
            this.cost,
            this.selling_price});
            this.stockgrid.Location = new System.Drawing.Point(0, 163);
            this.stockgrid.Name = "stockgrid";
            this.stockgrid.Size = new System.Drawing.Size(1042, 171);
            this.stockgrid.TabIndex = 0;
            this.stockgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // barcode_number
            // 
            this.barcode_number.HeaderText = "Barcode";
            this.barcode_number.Name = "barcode_number";
            this.barcode_number.Width = 150;
            // 
            // part_number
            // 
            this.part_number.HeaderText = "Part Number";
            this.part_number.Name = "part_number";
            this.part_number.Width = 150;
            // 
            // part_name
            // 
            this.part_name.HeaderText = "Part Name";
            this.part_name.Name = "part_name";
            this.part_name.Width = 150;
            // 
            // company_number
            // 
            this.company_number.HeaderText = "Company number";
            this.company_number.Name = "company_number";
            this.company_number.ReadOnly = true;
            this.company_number.Width = 150;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // cost
            // 
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            this.cost.Width = 150;
            // 
            // selling_price
            // 
            this.selling_price.HeaderText = "Selling Price";
            this.selling_price.Name = "selling_price";
            this.selling_price.ReadOnly = true;
            this.selling_price.Width = 150;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(105, 22);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(71, 20);
            this.txtdate.TabIndex = 1;
            this.txtdate.TextChanged += new System.EventHandler(this.txtdate_TextChanged);
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(76, 104);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(100, 20);
            this.txtbarcode.TabIndex = 4;
            this.txtbarcode.TextChanged += new System.EventHandler(this.txtbarcode_TextChanged);
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(967, 351);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(75, 23);
            this.btnconfirm.TabIndex = 6;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date/Time";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(491, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Company Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(219, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Part Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Barcode";
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(315, 43);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(298, 21);
            this.cmbSuppliers.TabIndex = 12;
            this.cmbSuppliers.SelectedIndexChanged += new System.EventHandler(this.cmbSuppliers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(219, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select the supplier";
            // 
            // cmbpartnumber
            // 
            this.cmbpartnumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbpartnumber.FormattingEnabled = true;
            this.cmbpartnumber.Location = new System.Drawing.Point(315, 108);
            this.cmbpartnumber.Name = "cmbpartnumber";
            this.cmbpartnumber.Size = new System.Drawing.Size(121, 21);
            this.cmbpartnumber.TabIndex = 14;
            this.cmbpartnumber.SelectedIndexChanged += new System.EventHandler(this.cmbpartnumber_SelectedIndexChanged);
            this.cmbpartnumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbKeyDown);
            this.cmbpartnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FALSE);
            // 
            // cmbcompanypartno
            // 
            this.cmbcompanypartno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbcompanypartno.FormattingEnabled = true;
            this.cmbcompanypartno.Location = new System.Drawing.Point(612, 108);
            this.cmbcompanypartno.Name = "cmbcompanypartno";
            this.cmbcompanypartno.Size = new System.Drawing.Size(121, 21);
            this.cmbcompanypartno.TabIndex = 15;
            this.cmbcompanypartno.SelectedIndexChanged += new System.EventHandler(this.cmbcompanypartno_SelectedIndexChanged);
            this.cmbcompanypartno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FALSE);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(860, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Purchase ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtpurchase_id
            // 
            this.txtpurchase_id.Location = new System.Drawing.Point(942, 22);
            this.txtpurchase_id.Name = "txtpurchase_id";
            this.txtpurchase_id.Size = new System.Drawing.Size(100, 20);
            this.txtpurchase_id.TabIndex = 16;
            this.txtpurchase_id.TextChanged += new System.EventHandler(this.txtpurchase_id_TextChanged);
            // 
            // btnNewItem
            // 
            this.btnNewItem.BackColor = System.Drawing.Color.Transparent;
            this.btnNewItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNewItem.Location = new System.Drawing.Point(796, 108);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(75, 23);
            this.btnNewItem.TabIndex = 18;
            this.btnNewItem.Text = "New Item";
            this.btnNewItem.UseVisualStyleBackColor = false;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1243, 511);
            this.Controls.Add(this.btnNewItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpurchase_id);
            this.Controls.Add(this.cmbcompanypartno);
            this.Controls.Add(this.cmbpartnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSuppliers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.stockgrid);
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stockgrid;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbpartnumber;
        private System.Windows.Forms.ComboBox cmbcompanypartno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpurchase_id;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn part_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn part_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn selling_price;
    }
}