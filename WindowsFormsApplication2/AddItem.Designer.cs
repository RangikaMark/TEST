namespace AutoParts
{
    partial class AddItem
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
            System.Windows.Forms.Button btnAddItems;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCompanyNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPid = new System.Windows.Forms.Label();
            this.cmbSup = new System.Windows.Forms.ComboBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.cmbVBrand = new System.Windows.Forms.ComboBox();
            this.cmbItemBrand = new System.Windows.Forms.ComboBox();
            this.cmbPartName = new System.Windows.Forms.ComboBox();
            this.chklistVehicle = new System.Windows.Forms.CheckedListBox();
            this.chkotherB = new System.Windows.Forms.CheckBox();
            btnAddItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddItems
            // 
            btnAddItems.BackColor = System.Drawing.Color.Transparent;
            btnAddItems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddItems.BackgroundImage")));
            btnAddItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnAddItems.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnAddItems.FlatAppearance.BorderSize = 0;
            btnAddItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnAddItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAddItems.ForeColor = System.Drawing.Color.White;
            btnAddItems.Location = new System.Drawing.Point(630, 386);
            btnAddItems.Name = "btnAddItems";
            btnAddItems.Size = new System.Drawing.Size(69, 56);
            btnAddItems.TabIndex = 33;
            btnAddItems.UseVisualStyleBackColor = false;
            btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPartNumber.Location = new System.Drawing.Point(139, 121);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPartNumber.TabIndex = 0;
            this.txtPartNumber.TextChanged += new System.EventHandler(this.txtPartNumber_TextChanged);
            this.txtPartNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPartNumber_KeyDown);
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCost.Location = new System.Drawing.Point(139, 414);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 1;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(516, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Part Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(318, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "supplier";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(16, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Part Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(16, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cost ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(313, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Vehicle  ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(51, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(267, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Company Part Number ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(18, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Vehicle Brand ";
            // 
            // txtCompanyNo
            // 
            this.txtCompanyNo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCompanyNo.Location = new System.Drawing.Point(388, 121);
            this.txtCompanyNo.Name = "txtCompanyNo";
            this.txtCompanyNo.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyNo.TabIndex = 16;
            this.txtCompanyNo.TextChanged += new System.EventHandler(this.txtCompanyNo_TextChanged);
            this.txtCompanyNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompanyPartNo_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Location = new System.Drawing.Point(303, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Item Brand";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.SystemColors.Menu;
            this.txtdate.Location = new System.Drawing.Point(54, 40);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(60, 20);
            this.txtdate.TabIndex = 21;
            this.txtdate.TextChanged += new System.EventHandler(this.txtdate_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.ForeColor = System.Drawing.SystemColors.Info;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(18, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Date";
            // 
            // lblPid
            // 
            this.lblPid.AutoSize = true;
            this.lblPid.BackColor = System.Drawing.Color.Transparent;
            this.lblPid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPid.ForeColor = System.Drawing.SystemColors.Info;
            this.lblPid.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPid.Location = new System.Drawing.Point(208, 43);
            this.lblPid.Name = "lblPid";
            this.lblPid.Size = new System.Drawing.Size(0, 13);
            this.lblPid.TabIndex = 25;
            // 
            // cmbSup
            // 
            this.cmbSup.FormattingEnabled = true;
            this.cmbSup.Location = new System.Drawing.Point(388, 61);
            this.cmbSup.Name = "cmbSup";
            this.cmbSup.Size = new System.Drawing.Size(185, 21);
            this.cmbSup.TabIndex = 29;
            this.cmbSup.SelectedIndexChanged += new System.EventHandler(this.cmbSup_SelectedIndexChanged);
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(139, 189);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(100, 21);
            this.cmbCountry.TabIndex = 30;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // cmbVBrand
            // 
            this.cmbVBrand.FormattingEnabled = true;
            this.cmbVBrand.Location = new System.Drawing.Point(139, 280);
            this.cmbVBrand.Name = "cmbVBrand";
            this.cmbVBrand.Size = new System.Drawing.Size(100, 21);
            this.cmbVBrand.TabIndex = 31;
            this.cmbVBrand.SelectedIndexChanged += new System.EventHandler(this.cmbVBrand_SelectedIndexChanged);
            // 
            // cmbItemBrand
            // 
            this.cmbItemBrand.FormattingEnabled = true;
            this.cmbItemBrand.Location = new System.Drawing.Point(388, 186);
            this.cmbItemBrand.Name = "cmbItemBrand";
            this.cmbItemBrand.Size = new System.Drawing.Size(100, 21);
            this.cmbItemBrand.TabIndex = 34;
            this.cmbItemBrand.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbPartName
            // 
            this.cmbPartName.FormattingEnabled = true;
            this.cmbPartName.Location = new System.Drawing.Point(599, 120);
            this.cmbPartName.Name = "cmbPartName";
            this.cmbPartName.Size = new System.Drawing.Size(100, 21);
            this.cmbPartName.TabIndex = 35;
            this.cmbPartName.SelectedIndexChanged += new System.EventHandler(this.cmbPartName_SelectedIndexChanged);
            // 
            // chklistVehicle
            // 
            this.chklistVehicle.FormattingEnabled = true;
            this.chklistVehicle.Location = new System.Drawing.Point(388, 245);
            this.chklistVehicle.Name = "chklistVehicle";
            this.chklistVehicle.Size = new System.Drawing.Size(120, 94);
            this.chklistVehicle.TabIndex = 36;
            this.chklistVehicle.SelectedIndexChanged += new System.EventHandler(this.chklistVehicle_SelectedIndexChanged);
            // 
            // chkotherB
            // 
            this.chkotherB.AutoSize = true;
            this.chkotherB.BackColor = System.Drawing.Color.Transparent;
            this.chkotherB.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkotherB.Location = new System.Drawing.Point(570, 276);
            this.chkotherB.Name = "chkotherB";
            this.chkotherB.Size = new System.Drawing.Size(123, 17);
            this.chkotherB.TabIndex = 38;
            this.chkotherB.Text = "Add Another Vehicle";
            this.chkotherB.UseVisualStyleBackColor = false;
            this.chkotherB.CheckedChanged += new System.EventHandler(this.chkotherB_CheckedChanged);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 454);
            this.Controls.Add(this.chkotherB);
            this.Controls.Add(this.chklistVehicle);
            this.Controls.Add(this.cmbPartName);
            this.Controls.Add(this.cmbItemBrand);
            this.Controls.Add(btnAddItems);
            this.Controls.Add(this.cmbVBrand);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.cmbSup);
            this.Controls.Add(this.lblPid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCompanyNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtPartNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCompanyNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPid;
        private System.Windows.Forms.ComboBox cmbSup;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.ComboBox cmbVBrand;
        private System.Windows.Forms.ComboBox cmbItemBrand;
        private System.Windows.Forms.ComboBox cmbPartName;
        private System.Windows.Forms.CheckedListBox chklistVehicle;
        private System.Windows.Forms.CheckBox chkotherB;
    }
}