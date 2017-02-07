namespace AutoParts
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.payment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.supplier = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.employee = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPanel.Location = new System.Drawing.Point(53, 137);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1259, 525);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // payment
            // 
            this.payment.AutoEllipsis = true;
            this.payment.BackColor = System.Drawing.Color.Transparent;
            this.payment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("payment.BackgroundImage")));
            this.payment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.payment.FlatAppearance.BorderSize = 0;
            this.payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payment.ForeColor = System.Drawing.Color.White;
            this.payment.Location = new System.Drawing.Point(102, 16);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(93, 89);
            this.payment.TabIndex = 5;
            this.payment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.payment.UseVisualStyleBackColor = false;
            this.payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Payments";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search.BackgroundImage")));
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(235, 16);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(93, 89);
            this.search.TabIndex = 11;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Search";
            // 
            // customer
            // 
            this.customer.BackColor = System.Drawing.Color.Transparent;
            this.customer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customer.BackgroundImage")));
            this.customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.customer.FlatAppearance.BorderSize = 0;
            this.customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer.ForeColor = System.Drawing.Color.White;
            this.customer.Location = new System.Drawing.Point(366, 16);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(93, 89);
            this.customer.TabIndex = 13;
            this.customer.UseVisualStyleBackColor = false;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Customer";
            // 
            // supplier
            // 
            this.supplier.BackColor = System.Drawing.Color.Transparent;
            this.supplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("supplier.BackgroundImage")));
            this.supplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.supplier.FlatAppearance.BorderSize = 0;
            this.supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplier.ForeColor = System.Drawing.Color.White;
            this.supplier.Location = new System.Drawing.Point(500, 16);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(93, 89);
            this.supplier.TabIndex = 15;
            this.supplier.UseVisualStyleBackColor = false;
            this.supplier.Click += new System.EventHandler(this.supplier_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Supplier";
            // 
            // stock
            // 
            this.stock.BackColor = System.Drawing.Color.Transparent;
            this.stock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stock.BackgroundImage")));
            this.stock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stock.FlatAppearance.BorderSize = 0;
            this.stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock.ForeColor = System.Drawing.Color.White;
            this.stock.Location = new System.Drawing.Point(640, 16);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(93, 89);
            this.stock.TabIndex = 17;
            this.stock.UseVisualStyleBackColor = false;
            this.stock.Click += new System.EventHandler(this.stock_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(666, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Stock";
            // 
            // employee
            // 
            this.employee.BackColor = System.Drawing.Color.Transparent;
            this.employee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employee.BackgroundImage")));
            this.employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.employee.FlatAppearance.BorderSize = 0;
            this.employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee.ForeColor = System.Drawing.Color.White;
            this.employee.Location = new System.Drawing.Point(766, 16);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(93, 89);
            this.employee.TabIndex = 19;
            this.employee.UseVisualStyleBackColor = false;
            this.employee.Click += new System.EventHandler(this.employee_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(784, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Employee";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1145, 701);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Welcome";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.supplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Hashini Auto Parts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button payment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button supplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button employee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}