namespace WindowsFormsApp17
{
    partial class Rent
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
            this.panelrentd = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtmonthlyrent = new System.Windows.Forms.TextBox();
            this.lblmonthlyrent = new System.Windows.Forms.Label();
            this.txtweeklyrent = new System.Windows.Forms.TextBox();
            this.lblweeklyrent = new System.Windows.Forms.Label();
            this.txtdailyrent = new System.Windows.Forms.TextBox();
            this.lbldailyrent = new System.Windows.Forms.Label();
            this.lblvehitype = new System.Windows.Forms.Label();
            this.Cbovehicletype = new System.Windows.Forms.ComboBox();
            this.txtdrivercost = new System.Windows.Forms.TextBox();
            this.lbldrivercost = new System.Windows.Forms.Label();
            this.dtpreturndate = new System.Windows.Forms.DateTimePicker();
            this.dtprenteddate = new System.Windows.Forms.DateTimePicker();
            this.btncalculaterent = new System.Windows.Forms.Button();
            this.txtTamount = new System.Windows.Forms.TextBox();
            this.txtvehicleidrent = new System.Windows.Forms.TextBox();
            this.lblTamountrent = new System.Windows.Forms.Label();
            this.lblreturneddate = new System.Windows.Forms.Label();
            this.lblrentdriverinclu = new System.Windows.Forms.Label();
            this.lblrenteddate = new System.Windows.Forms.Label();
            this.lblrentvehino = new System.Windows.Forms.Label();
            this.panelrentd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelrentd
            // 
            this.panelrentd.BackColor = System.Drawing.Color.AliceBlue;
            this.panelrentd.Controls.Add(this.comboBox1);
            this.panelrentd.Controls.Add(this.txtmonthlyrent);
            this.panelrentd.Controls.Add(this.lblmonthlyrent);
            this.panelrentd.Controls.Add(this.txtweeklyrent);
            this.panelrentd.Controls.Add(this.lblweeklyrent);
            this.panelrentd.Controls.Add(this.txtdailyrent);
            this.panelrentd.Controls.Add(this.lbldailyrent);
            this.panelrentd.Controls.Add(this.lblvehitype);
            this.panelrentd.Controls.Add(this.Cbovehicletype);
            this.panelrentd.Controls.Add(this.txtdrivercost);
            this.panelrentd.Controls.Add(this.lbldrivercost);
            this.panelrentd.Controls.Add(this.dtpreturndate);
            this.panelrentd.Controls.Add(this.dtprenteddate);
            this.panelrentd.Controls.Add(this.btncalculaterent);
            this.panelrentd.Controls.Add(this.txtTamount);
            this.panelrentd.Controls.Add(this.txtvehicleidrent);
            this.panelrentd.Controls.Add(this.lblTamountrent);
            this.panelrentd.Controls.Add(this.lblreturneddate);
            this.panelrentd.Controls.Add(this.lblrentdriverinclu);
            this.panelrentd.Controls.Add(this.lblrenteddate);
            this.panelrentd.Controls.Add(this.lblrentvehino);
            this.panelrentd.Location = new System.Drawing.Point(45, 38);
            this.panelrentd.Name = "panelrentd";
            this.panelrentd.Size = new System.Drawing.Size(514, 421);
            this.panelrentd.TabIndex = 53;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yes ",
            "No"});
            this.comboBox1.Location = new System.Drawing.Point(154, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 85;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtmonthlyrent
            // 
            this.txtmonthlyrent.Location = new System.Drawing.Point(154, 280);
            this.txtmonthlyrent.Name = "txtmonthlyrent";
            this.txtmonthlyrent.Size = new System.Drawing.Size(196, 20);
            this.txtmonthlyrent.TabIndex = 84;
            // 
            // lblmonthlyrent
            // 
            this.lblmonthlyrent.AutoSize = true;
            this.lblmonthlyrent.BackColor = System.Drawing.Color.White;
            this.lblmonthlyrent.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonthlyrent.Location = new System.Drawing.Point(23, 282);
            this.lblmonthlyrent.Name = "lblmonthlyrent";
            this.lblmonthlyrent.Size = new System.Drawing.Size(84, 15);
            this.lblmonthlyrent.TabIndex = 83;
            this.lblmonthlyrent.Text = "Monthly Rent";
            // 
            // txtweeklyrent
            // 
            this.txtweeklyrent.Location = new System.Drawing.Point(154, 246);
            this.txtweeklyrent.Name = "txtweeklyrent";
            this.txtweeklyrent.Size = new System.Drawing.Size(196, 20);
            this.txtweeklyrent.TabIndex = 82;
            // 
            // lblweeklyrent
            // 
            this.lblweeklyrent.AutoSize = true;
            this.lblweeklyrent.BackColor = System.Drawing.Color.White;
            this.lblweeklyrent.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblweeklyrent.Location = new System.Drawing.Point(23, 248);
            this.lblweeklyrent.Name = "lblweeklyrent";
            this.lblweeklyrent.Size = new System.Drawing.Size(83, 15);
            this.lblweeklyrent.TabIndex = 81;
            this.lblweeklyrent.Text = "Weekly Rent ";
            // 
            // txtdailyrent
            // 
            this.txtdailyrent.Location = new System.Drawing.Point(154, 209);
            this.txtdailyrent.Name = "txtdailyrent";
            this.txtdailyrent.Size = new System.Drawing.Size(196, 20);
            this.txtdailyrent.TabIndex = 80;
            // 
            // lbldailyrent
            // 
            this.lbldailyrent.AutoSize = true;
            this.lbldailyrent.BackColor = System.Drawing.Color.White;
            this.lbldailyrent.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldailyrent.Location = new System.Drawing.Point(24, 211);
            this.lbldailyrent.Name = "lbldailyrent";
            this.lbldailyrent.Size = new System.Drawing.Size(66, 15);
            this.lbldailyrent.TabIndex = 79;
            this.lbldailyrent.Text = "Daily Rent";
            // 
            // lblvehitype
            // 
            this.lblvehitype.AutoSize = true;
            this.lblvehitype.BackColor = System.Drawing.Color.White;
            this.lblvehitype.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvehitype.Location = new System.Drawing.Point(24, 42);
            this.lblvehitype.Name = "lblvehitype";
            this.lblvehitype.Size = new System.Drawing.Size(82, 15);
            this.lblvehitype.TabIndex = 78;
            this.lblvehitype.Text = "Vehicle Type";
            // 
            // Cbovehicletype
            // 
            this.Cbovehicletype.FormattingEnabled = true;
            this.Cbovehicletype.Items.AddRange(new object[] {
            "Smalll Car ",
            "MIni Van",
            "Sedan Car ",
            "KDH Van "});
            this.Cbovehicletype.Location = new System.Drawing.Point(154, 42);
            this.Cbovehicletype.Name = "Cbovehicletype";
            this.Cbovehicletype.Size = new System.Drawing.Size(196, 21);
            this.Cbovehicletype.TabIndex = 77;
            this.Cbovehicletype.SelectedIndexChanged += new System.EventHandler(this.cbovtype2_SelectedIndexChanged);
            // 
            // txtdrivercost
            // 
            this.txtdrivercost.Location = new System.Drawing.Point(154, 324);
            this.txtdrivercost.Name = "txtdrivercost";
            this.txtdrivercost.Size = new System.Drawing.Size(196, 20);
            this.txtdrivercost.TabIndex = 74;
            // 
            // lbldrivercost
            // 
            this.lbldrivercost.AutoSize = true;
            this.lbldrivercost.BackColor = System.Drawing.Color.White;
            this.lbldrivercost.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldrivercost.Location = new System.Drawing.Point(23, 326);
            this.lbldrivercost.Name = "lbldrivercost";
            this.lbldrivercost.Size = new System.Drawing.Size(76, 15);
            this.lbldrivercost.TabIndex = 73;
            this.lbldrivercost.Text = "Driver Cost";
            // 
            // dtpreturndate
            // 
            this.dtpreturndate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpreturndate.Location = new System.Drawing.Point(154, 108);
            this.dtpreturndate.Name = "dtpreturndate";
            this.dtpreturndate.Size = new System.Drawing.Size(196, 20);
            this.dtpreturndate.TabIndex = 72;
            // 
            // dtprenteddate
            // 
            this.dtprenteddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtprenteddate.Location = new System.Drawing.Point(154, 77);
            this.dtprenteddate.Name = "dtprenteddate";
            this.dtprenteddate.Size = new System.Drawing.Size(196, 20);
            this.dtprenteddate.TabIndex = 71;
            // 
            // btncalculaterent
            // 
            this.btncalculaterent.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculaterent.Location = new System.Drawing.Point(418, 365);
            this.btncalculaterent.Name = "btncalculaterent";
            this.btncalculaterent.Size = new System.Drawing.Size(74, 26);
            this.btncalculaterent.TabIndex = 69;
            this.btncalculaterent.Text = "Calculate";
            this.btncalculaterent.UseVisualStyleBackColor = true;
            this.btncalculaterent.Click += new System.EventHandler(this.btncalculaterent_Click);
            // 
            // txtTamount
            // 
            this.txtTamount.Location = new System.Drawing.Point(265, 369);
            this.txtTamount.Name = "txtTamount";
            this.txtTamount.Size = new System.Drawing.Size(138, 20);
            this.txtTamount.TabIndex = 61;
            // 
            // txtvehicleidrent
            // 
            this.txtvehicleidrent.Location = new System.Drawing.Point(154, 139);
            this.txtvehicleidrent.Name = "txtvehicleidrent";
            this.txtvehicleidrent.Size = new System.Drawing.Size(196, 20);
            this.txtvehicleidrent.TabIndex = 60;
            // 
            // lblTamountrent
            // 
            this.lblTamountrent.AutoSize = true;
            this.lblTamountrent.BackColor = System.Drawing.Color.White;
            this.lblTamountrent.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamountrent.Location = new System.Drawing.Point(136, 371);
            this.lblTamountrent.Name = "lblTamountrent";
            this.lblTamountrent.Size = new System.Drawing.Size(89, 15);
            this.lblTamountrent.TabIndex = 58;
            this.lblTamountrent.Text = "Total Amount";
            // 
            // lblreturneddate
            // 
            this.lblreturneddate.AutoSize = true;
            this.lblreturneddate.BackColor = System.Drawing.Color.White;
            this.lblreturneddate.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreturneddate.Location = new System.Drawing.Point(25, 108);
            this.lblreturneddate.Name = "lblreturneddate";
            this.lblreturneddate.Size = new System.Drawing.Size(97, 15);
            this.lblreturneddate.TabIndex = 57;
            this.lblreturneddate.Text = "Returned Date ";
            // 
            // lblrentdriverinclu
            // 
            this.lblrentdriverinclu.AutoSize = true;
            this.lblrentdriverinclu.BackColor = System.Drawing.Color.White;
            this.lblrentdriverinclu.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrentdriverinclu.Location = new System.Drawing.Point(24, 179);
            this.lblrentdriverinclu.Name = "lblrentdriverinclu";
            this.lblrentdriverinclu.Size = new System.Drawing.Size(103, 15);
            this.lblrentdriverinclu.TabIndex = 56;
            this.lblrentdriverinclu.Text = "Driver Included?";
            // 
            // lblrenteddate
            // 
            this.lblrenteddate.AutoSize = true;
            this.lblrenteddate.BackColor = System.Drawing.Color.White;
            this.lblrenteddate.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrenteddate.Location = new System.Drawing.Point(25, 77);
            this.lblrenteddate.Name = "lblrenteddate";
            this.lblrenteddate.Size = new System.Drawing.Size(81, 15);
            this.lblrenteddate.TabIndex = 53;
            this.lblrenteddate.Text = "Rented Date";
            // 
            // lblrentvehino
            // 
            this.lblrentvehino.AutoSize = true;
            this.lblrentvehino.BackColor = System.Drawing.Color.White;
            this.lblrentvehino.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrentvehino.Location = new System.Drawing.Point(24, 144);
            this.lblrentvehino.Name = "lblrentvehino";
            this.lblrentvehino.Size = new System.Drawing.Size(69, 15);
            this.lblrentvehino.TabIndex = 54;
            this.lblrentvehino.Text = "Vehicle No";
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp17.Properties.Resources.istockphoto_1281935531_170667a2;
            this.ClientSize = new System.Drawing.Size(590, 519);
            this.Controls.Add(this.panelrentd);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Rent";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Rent_Load);
            this.panelrentd.ResumeLayout(false);
            this.panelrentd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelrentd;
        private System.Windows.Forms.DateTimePicker dtpreturndate;
        private System.Windows.Forms.DateTimePicker dtprenteddate;
        private System.Windows.Forms.Button btncalculaterent;
        private System.Windows.Forms.TextBox txtTamount;
        private System.Windows.Forms.TextBox txtvehicleidrent;
        private System.Windows.Forms.Label lblTamountrent;
        private System.Windows.Forms.Label lblreturneddate;
        private System.Windows.Forms.Label lblrentdriverinclu;
        private System.Windows.Forms.Label lblrenteddate;
        private System.Windows.Forms.Label lblrentvehino;
        private System.Windows.Forms.TextBox txtdrivercost;
        private System.Windows.Forms.Label lbldrivercost;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtmonthlyrent;
        private System.Windows.Forms.Label lblmonthlyrent;
        private System.Windows.Forms.TextBox txtweeklyrent;
        private System.Windows.Forms.Label lblweeklyrent;
        private System.Windows.Forms.TextBox txtdailyrent;
        private System.Windows.Forms.Label lbldailyrent;
        private System.Windows.Forms.Label lblvehitype;
        private System.Windows.Forms.ComboBox Cbovehicletype;
    }
}