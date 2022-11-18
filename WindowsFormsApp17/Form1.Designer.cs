namespace WindowsFormsApp17
{
    partial class Form1
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
            this.lblwtabdrve = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lbluserna = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblpwd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblwtabdrve
            // 
            this.lblwtabdrve.AutoSize = true;
            this.lblwtabdrve.BackColor = System.Drawing.Color.Transparent;
            this.lblwtabdrve.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwtabdrve.ForeColor = System.Drawing.Color.Black;
            this.lblwtabdrve.Location = new System.Drawing.Point(48, 36);
            this.lblwtabdrve.Name = "lblwtabdrve";
            this.lblwtabdrve.Size = new System.Drawing.Size(468, 23);
            this.lblwtabdrve.TabIndex = 0;
            this.lblwtabdrve.Text = "Welcome To Ayubo Drive Car Rental System !";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(114, 214);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(97, 43);
            this.btnsubmit.TabIndex = 6;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.lbllogin);
            this.panel1.Controls.Add(this.btnsubmit);
            this.panel1.Controls.Add(this.lbluserna);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.lblpwd);
            this.panel1.Location = new System.Drawing.Point(110, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 289);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.BackColor = System.Drawing.Color.White;
            this.lbllogin.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.Location = new System.Drawing.Point(135, 27);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(57, 17);
            this.lbllogin.TabIndex = 15;
            this.lbllogin.Text = "LOGIN";
            // 
            // lbluserna
            // 
            this.lbluserna.AutoSize = true;
            this.lbluserna.BackColor = System.Drawing.Color.White;
            this.lbluserna.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserna.Location = new System.Drawing.Point(52, 61);
            this.lbluserna.Name = "lbluserna";
            this.lbluserna.Size = new System.Drawing.Size(70, 15);
            this.lbluserna.TabIndex = 11;
            this.lbluserna.Text = "Username ";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(55, 167);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(199, 20);
            this.txtpassword.TabIndex = 14;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(55, 92);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(199, 20);
            this.txtusername.TabIndex = 13;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.BackColor = System.Drawing.Color.Beige;
            this.lblpwd.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpwd.Location = new System.Drawing.Point(52, 134);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(64, 15);
            this.lblpwd.TabIndex = 12;
            this.lblpwd.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = global::WindowsFormsApp17.Properties.Resources.istockphoto_1281935531_170667a1;
            this.ClientSize = new System.Drawing.Size(528, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblwtabdrve);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwtabdrve;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lbluserna;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblpwd;
    }
}

