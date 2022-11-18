namespace WindowsFormsApp17
{
    partial class Dashboard
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
            this.btnback = new System.Windows.Forms.Button();
            this.paneldashbrd = new System.Windows.Forms.Panel();
            this.btnrent = new System.Windows.Forms.Button();
            this.btncustom = new System.Windows.Forms.Button();
            this.btndriver = new System.Windows.Forms.Button();
            this.btnhire = new System.Windows.Forms.Button();
            this.btnvehicle = new System.Windows.Forms.Button();
            this.txtvid = new System.Windows.Forms.TextBox();
            this.lblvid = new System.Windows.Forms.Label();
            this.paneldashbrd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(29, 406);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(81, 32);
            this.btnback.TabIndex = 7;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // paneldashbrd
            // 
            this.paneldashbrd.BackColor = System.Drawing.Color.AliceBlue;
            this.paneldashbrd.Controls.Add(this.btnrent);
            this.paneldashbrd.Controls.Add(this.btncustom);
            this.paneldashbrd.Controls.Add(this.btndriver);
            this.paneldashbrd.Controls.Add(this.btnhire);
            this.paneldashbrd.Controls.Add(this.btnvehicle);
            this.paneldashbrd.Controls.Add(this.txtvid);
            this.paneldashbrd.Controls.Add(this.lblvid);
            this.paneldashbrd.Location = new System.Drawing.Point(85, 23);
            this.paneldashbrd.Name = "paneldashbrd";
            this.paneldashbrd.Size = new System.Drawing.Size(333, 358);
            this.paneldashbrd.TabIndex = 55;
            this.paneldashbrd.Paint += new System.Windows.Forms.PaintEventHandler(this.panelvehid_Paint);
            // 
            // btnrent
            // 
            this.btnrent.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrent.Location = new System.Drawing.Point(101, 256);
            this.btnrent.Name = "btnrent";
            this.btnrent.Size = new System.Drawing.Size(129, 38);
            this.btnrent.TabIndex = 70;
            this.btnrent.Text = "RENT";
            this.btnrent.UseVisualStyleBackColor = true;
            this.btnrent.Click += new System.EventHandler(this.btnrent_Click_1);
            // 
            // btncustom
            // 
            this.btncustom.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustom.Location = new System.Drawing.Point(101, 42);
            this.btncustom.Name = "btncustom";
            this.btncustom.Size = new System.Drawing.Size(129, 38);
            this.btncustom.TabIndex = 69;
            this.btncustom.Text = "CUSTOMER";
            this.btncustom.UseVisualStyleBackColor = true;
            this.btncustom.Click += new System.EventHandler(this.btncustom_Click_1);
            // 
            // btndriver
            // 
            this.btndriver.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndriver.Location = new System.Drawing.Point(101, 158);
            this.btndriver.Name = "btndriver";
            this.btndriver.Size = new System.Drawing.Size(129, 38);
            this.btndriver.TabIndex = 68;
            this.btndriver.Text = "DRIVER";
            this.btndriver.UseVisualStyleBackColor = true;
            this.btndriver.Click += new System.EventHandler(this.btndriver_Click_1);
            // 
            // btnhire
            // 
            this.btnhire.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhire.Location = new System.Drawing.Point(101, 202);
            this.btnhire.Name = "btnhire";
            this.btnhire.Size = new System.Drawing.Size(129, 38);
            this.btnhire.TabIndex = 66;
            this.btnhire.Text = "HIRE";
            this.btnhire.UseVisualStyleBackColor = true;
            this.btnhire.Click += new System.EventHandler(this.btnhire_Click_1);
            // 
            // btnvehicle
            // 
            this.btnvehicle.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvehicle.Location = new System.Drawing.Point(101, 101);
            this.btnvehicle.Name = "btnvehicle";
            this.btnvehicle.Size = new System.Drawing.Size(129, 38);
            this.btnvehicle.TabIndex = 65;
            this.btnvehicle.Text = "VEHICLE ";
            this.btnvehicle.UseVisualStyleBackColor = true;
            this.btnvehicle.Click += new System.EventHandler(this.btnvehicle_Click_1);
            // 
            // txtvid
            // 
            this.txtvid.Location = new System.Drawing.Point(124, -21);
            this.txtvid.Name = "txtvid";
            this.txtvid.Size = new System.Drawing.Size(165, 20);
            this.txtvid.TabIndex = 64;
            // 
            // lblvid
            // 
            this.lblvid.AutoSize = true;
            this.lblvid.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvid.Location = new System.Drawing.Point(-8, -21);
            this.lblvid.Name = "lblvid";
            this.lblvid.Size = new System.Drawing.Size(65, 15);
            this.lblvid.TabIndex = 54;
            this.lblvid.Text = "Vehicle ID";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::WindowsFormsApp17.Properties.Resources.istockphoto_1281935531_170667a1;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.paneldashbrd);
            this.Controls.Add(this.btnback);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.paneldashbrd.ResumeLayout(false);
            this.paneldashbrd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel paneldashbrd;
        private System.Windows.Forms.TextBox txtvid;
        private System.Windows.Forms.Label lblvid;
        private System.Windows.Forms.Button btnrent;
        private System.Windows.Forms.Button btncustom;
        private System.Windows.Forms.Button btndriver;
        private System.Windows.Forms.Button btnhire;
        private System.Windows.Forms.Button btnvehicle;
    }
}