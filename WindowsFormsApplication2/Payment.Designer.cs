namespace AutoParts
{
    partial class Payment
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
            System.Windows.Forms.Button button2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            System.Windows.Forms.Button button1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paymentGrid = new System.Windows.Forms.DataGridView();
            this.barcodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.barcodeTxt = new System.Windows.Forms.TextBox();
            this.enableEdit = new System.Windows.Forms.CheckBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paymentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Transparent;
            button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.ForeColor = System.Drawing.Color.White;
            button2.Location = new System.Drawing.Point(1102, 126);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(105, 97);
            button2.TabIndex = 17;
            button2.UseVisualStyleBackColor = false;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(1102, 278);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(105, 97);
            button1.TabIndex = 20;
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.clear_button);
            // 
            // paymentGrid
            // 
            this.paymentGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.paymentGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.paymentGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.paymentGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.paymentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeCol,
            this.partnoCol,
            this.nameCol,
            this.brandCol,
            this.qtyCol,
            this.discountCol,
            this.priceCol,
            this.subtotalCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.paymentGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.paymentGrid.Location = new System.Drawing.Point(41, 109);
            this.paymentGrid.Name = "paymentGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.paymentGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.paymentGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.paymentGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.paymentGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentGrid.RowTemplate.Height = 35;
            this.paymentGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.paymentGrid.Size = new System.Drawing.Size(1018, 287);
            this.paymentGrid.TabIndex = 15;
            this.paymentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // barcodeCol
            // 
            this.barcodeCol.HeaderText = "Barcode";
            this.barcodeCol.Name = "barcodeCol";
            this.barcodeCol.Visible = false;
            // 
            // partnoCol
            // 
            this.partnoCol.HeaderText = "Part No";
            this.partnoCol.Name = "partnoCol";
            this.partnoCol.ReadOnly = true;
            this.partnoCol.Width = 175;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            this.nameCol.Width = 250;
            // 
            // brandCol
            // 
            this.brandCol.HeaderText = "Brand";
            this.brandCol.Name = "brandCol";
            this.brandCol.ReadOnly = true;
            this.brandCol.Width = 155;
            // 
            // qtyCol
            // 
            this.qtyCol.HeaderText = "Qty.";
            this.qtyCol.MinimumWidth = 8;
            this.qtyCol.Name = "qtyCol";
            this.qtyCol.Width = 50;
            // 
            // discountCol
            // 
            this.discountCol.HeaderText = "Discount";
            this.discountCol.Name = "discountCol";
            this.discountCol.Width = 75;
            // 
            // priceCol
            // 
            this.priceCol.HeaderText = "Price (Rs.)";
            this.priceCol.Name = "priceCol";
            this.priceCol.Width = 125;
            // 
            // subtotalCol
            // 
            this.subtotalCol.HeaderText = "Sub Total (Rs.)";
            this.subtotalCol.Name = "subtotalCol";
            this.subtotalCol.ReadOnly = true;
            this.subtotalCol.Width = 145;
            // 
            // totalLbl
            // 
            this.totalLbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.totalLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.ForeColor = System.Drawing.Color.Red;
            this.totalLbl.Location = new System.Drawing.Point(660, 437);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(400, 50);
            this.totalLbl.TabIndex = 18;
            this.totalLbl.Text = "Total : Rs. 0";
            this.totalLbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(1133, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Submit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1133, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cancle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(59, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Barcode";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // barcodeTxt
            // 
            this.barcodeTxt.Enabled = false;
            this.barcodeTxt.Location = new System.Drawing.Point(137, 53);
            this.barcodeTxt.Name = "barcodeTxt";
            this.barcodeTxt.Size = new System.Drawing.Size(213, 20);
            this.barcodeTxt.TabIndex = 25;
            this.barcodeTxt.TextChanged += new System.EventHandler(this.enableAddButton);
            // 
            // enableEdit
            // 
            this.enableEdit.AutoSize = true;
            this.enableEdit.BackColor = System.Drawing.Color.Transparent;
            this.enableEdit.ForeColor = System.Drawing.Color.Coral;
            this.enableEdit.Location = new System.Drawing.Point(137, 79);
            this.enableEdit.Name = "enableEdit";
            this.enableEdit.Size = new System.Drawing.Size(139, 17);
            this.enableEdit.TabIndex = 26;
            this.enableEdit.Text = "Enter Barcode Manually";
            this.enableEdit.UseVisualStyleBackColor = false;
            this.enableEdit.CheckedChanged += new System.EventHandler(this.enableEditTheBarcode);
            // 
            // addBtn
            // 
            this.addBtn.Enabled = false;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(372, 38);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 46);
            this.addBtn.TabIndex = 27;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addItem);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(481, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 46);
            this.button4.TabIndex = 30;
            this.button4.Text = "Add Items Without Barcode";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.itemsWithoutBarcodes);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(924, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(830, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(830, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Transaction";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.comboBox1.Location = new System.Drawing.Point(924, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1243, 511);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.enableEdit);
            this.Controls.Add(this.barcodeTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(button1);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(button2);
            this.Controls.Add(this.paymentGrid);
            this.MinimizeBox = false;
            this.Name = "Payment";
            this.Opacity = 0.1D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox barcodeTxt;
        private System.Windows.Forms.CheckBox enableEdit;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView paymentGrid;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalCol;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}