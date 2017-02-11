namespace AutoParts
{
    partial class addVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addVehicle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvehicle = new System.Windows.Forms.TextBox();
            this.cmb_brand = new System.Windows.Forms.ComboBox();
            btnAddItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle Name";
            // 
            // txtvehicle
            // 
            this.txtvehicle.Location = new System.Drawing.Point(120, 83);
            this.txtvehicle.Name = "txtvehicle";
            this.txtvehicle.Size = new System.Drawing.Size(121, 20);
            this.txtvehicle.TabIndex = 2;
            // 
            // cmb_brand
            // 
            this.cmb_brand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_brand.FormattingEnabled = true;
            this.cmb_brand.Location = new System.Drawing.Point(120, 35);
            this.cmb_brand.Name = "cmb_brand";
            this.cmb_brand.Size = new System.Drawing.Size(121, 21);
            this.cmb_brand.TabIndex = 3;
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
            btnAddItems.Location = new System.Drawing.Point(207, 116);
            btnAddItems.Name = "btnAddItems";
            btnAddItems.Size = new System.Drawing.Size(34, 35);
            btnAddItems.TabIndex = 34;
            btnAddItems.UseVisualStyleBackColor = false;
            btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // addVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 163);
            this.Controls.Add(btnAddItems);
            this.Controls.Add(this.cmb_brand);
            this.Controls.Add(this.txtvehicle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Vehicle";
            this.Load += new System.EventHandler(this.addVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvehicle;
        private System.Windows.Forms.ComboBox cmb_brand;
    }
}