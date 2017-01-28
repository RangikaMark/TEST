namespace AutoParts
{
    partial class Search
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchGrid = new System.Windows.Forms.DataGridView();
            this.partnoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.com_brand = new System.Windows.Forms.ComboBox();
            this.com_made_in = new System.Windows.Forms.ComboBox();
            this.com_vehicle_type = new System.Windows.Forms.ComboBox();
            this.com_company = new System.Windows.Forms.ComboBox();
            this.part_type = new System.Windows.Forms.CheckedListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(1024, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Made in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(1024, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Vehicle Part";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(1024, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Vehicle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(1024, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Brand";
            // 
            // searchGrid
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.searchGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.searchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partnoCol,
            this.nameCol,
            this.country,
            this.VehicleType,
            this.brandCol,
            this.qtyCol,
            this.priceCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.searchGrid.Location = new System.Drawing.Point(25, 28);
            this.searchGrid.Name = "searchGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.searchGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.searchGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGrid.Size = new System.Drawing.Size(993, 400);
            this.searchGrid.TabIndex = 26;
            this.searchGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchGrid_CellContentClick);
            // 
            // partnoCol
            // 
            this.partnoCol.HeaderText = "Part No";
            this.partnoCol.Name = "partnoCol";
            this.partnoCol.ReadOnly = true;
            this.partnoCol.Width = 150;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            this.nameCol.Width = 250;
            // 
            // country
            // 
            this.country.HeaderText = "country";
            this.country.Name = "country";
            // 
            // VehicleType
            // 
            this.VehicleType.HeaderText = "Vehicle Type";
            this.VehicleType.Name = "VehicleType";
            // 
            // brandCol
            // 
            this.brandCol.HeaderText = "Brand";
            this.brandCol.Name = "brandCol";
            this.brandCol.ReadOnly = true;
            this.brandCol.Width = 150;
            // 
            // qtyCol
            // 
            this.qtyCol.HeaderText = "Qty.";
            this.qtyCol.MinimumWidth = 8;
            this.qtyCol.Name = "qtyCol";
            // 
            // priceCol
            // 
            this.priceCol.HeaderText = "Price";
            this.priceCol.Name = "priceCol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(1024, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Company";
            // 
            // com_brand
            // 
            this.com_brand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_brand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_brand.FormattingEnabled = true;
            this.com_brand.Location = new System.Drawing.Point(1027, 44);
            this.com_brand.Name = "com_brand";
            this.com_brand.Size = new System.Drawing.Size(173, 21);
            this.com_brand.TabIndex = 36;
            this.com_brand.SelectedIndexChanged += new System.EventHandler(this.com_brand_SelectedIndexChanged);
            // 
            // com_made_in
            // 
            this.com_made_in.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_made_in.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_made_in.FormattingEnabled = true;
            this.com_made_in.Location = new System.Drawing.Point(1027, 271);
            this.com_made_in.Name = "com_made_in";
            this.com_made_in.Size = new System.Drawing.Size(173, 21);
            this.com_made_in.TabIndex = 37;
            this.com_made_in.SelectedIndexChanged += new System.EventHandler(this.com_made_in_SelectedIndexChanged);
            // 
            // com_vehicle_type
            // 
            this.com_vehicle_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_vehicle_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_vehicle_type.FormattingEnabled = true;
            this.com_vehicle_type.Location = new System.Drawing.Point(1027, 93);
            this.com_vehicle_type.Name = "com_vehicle_type";
            this.com_vehicle_type.Size = new System.Drawing.Size(173, 21);
            this.com_vehicle_type.TabIndex = 39;
            this.com_vehicle_type.SelectedIndexChanged += new System.EventHandler(this.com_vehicle_type_SelectedIndexChanged);
            // 
            // com_company
            // 
            this.com_company.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_company.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_company.FormattingEnabled = true;
            this.com_company.Location = new System.Drawing.Point(1027, 320);
            this.com_company.Name = "com_company";
            this.com_company.Size = new System.Drawing.Size(173, 21);
            this.com_company.TabIndex = 40;
            this.com_company.SelectedIndexChanged += new System.EventHandler(this.com_company_SelectedIndexChanged);
            // 
            // part_type
            // 
            this.part_type.FormattingEnabled = true;
            this.part_type.Location = new System.Drawing.Point(1027, 143);
            this.part_type.Name = "part_type";
            this.part_type.ScrollAlwaysVisible = true;
            this.part_type.Size = new System.Drawing.Size(173, 109);
            this.part_type.TabIndex = 42;
            this.part_type.SelectedIndexChanged += new System.EventHandler(this.Test_Load);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(1106, 120);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 17);
            this.checkBox1.TabIndex = 43;
            this.checkBox1.Text = "Select All";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(1098, 357);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(65, 30);
            this.btn_search.TabIndex = 41;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.UseWaitCursor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.DarkGray;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(1027, 407);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(73, 21);
            this.btn_edit.TabIndex = 48;
            this.btn_edit.Text = "Edit Search";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.UseWaitCursor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.LightGray;
            this.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_new.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_new.FlatAppearance.BorderSize = 0;
            this.btn_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Location = new System.Drawing.Point(1165, 407);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(76, 21);
            this.btn_new.TabIndex = 49;
            this.btn_new.Text = "New Search";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.UseWaitCursor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1243, 511);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.part_type);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.com_company);
            this.Controls.Add(this.com_vehicle_type);
            this.Controls.Add(this.com_made_in);
            this.Controls.Add(this.com_brand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchGrid);
            this.MaximizeBox = false;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView searchGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox com_brand;
        private System.Windows.Forms.ComboBox com_made_in;
        private System.Windows.Forms.ComboBox com_vehicle_type;
        private System.Windows.Forms.ComboBox com_company;
        private System.Windows.Forms.CheckedListBox part_type;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_new;
    }
}