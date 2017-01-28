namespace AutoParts
{
    partial class signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup));
            this.btnsub = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtadress = new System.Windows.Forms.TextBox();
            this.txtcontactno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrepass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(164, 285);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(75, 23);
            this.btnsub.TabIndex = 0;
            this.btnsub.Text = "Submit";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(88, 12);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(151, 20);
            this.txtname.TabIndex = 1;
            // 
            // txtadress
            // 
            this.txtadress.Location = new System.Drawing.Point(88, 90);
            this.txtadress.Name = "txtadress";
            this.txtadress.Size = new System.Drawing.Size(151, 20);
            this.txtadress.TabIndex = 2;
            // 
            // txtcontactno
            // 
            this.txtcontactno.Location = new System.Drawing.Point(88, 52);
            this.txtcontactno.Name = "txtcontactno";
            this.txtcontactno.Size = new System.Drawing.Size(151, 20);
            this.txtcontactno.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contact no";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(88, 134);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(151, 20);
            this.txtusername.TabIndex = 7;
            this.txtusername.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(88, 172);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(151, 20);
            this.txtpassword.TabIndex = 8;
            this.txtpassword.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "User name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // txtrepass
            // 
            this.txtrepass.Location = new System.Drawing.Point(88, 214);
            this.txtrepass.Name = "txtrepass";
            this.txtrepass.Size = new System.Drawing.Size(151, 20);
            this.txtrepass.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Re-type the\r\n password";
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(286, 320);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtrepass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcontactno);
            this.Controls.Add(this.txtadress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnsub);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Create User";
            this.Load += new System.EventHandler(this.signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtadress;
        private System.Windows.Forms.TextBox txtcontactno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtrepass;
        private System.Windows.Forms.Label label6;
    }
}