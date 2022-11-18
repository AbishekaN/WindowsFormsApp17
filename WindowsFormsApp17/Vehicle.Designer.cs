namespace WindowsFormsApp17
{
    partial class Vehicle
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
            this.panelvehid = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtvehicleno = new System.Windows.Forms.TextBox();
            this.txtvehicleid = new System.Windows.Forms.TextBox();
            this.lblvehino = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtvid = new System.Windows.Forms.TextBox();
            this.cbobrands = new System.Windows.Forms.ComboBox();
            this.cbovehitype = new System.Windows.Forms.ComboBox();
            this.lblbrand = new System.Windows.Forms.Label();
            this.lblvtypevdetails = new System.Windows.Forms.Label();
            this.lblvehiclid = new System.Windows.Forms.Label();
            this.lblvid = new System.Windows.Forms.Label();
            this.panelvehid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelvehid
            // 
            this.panelvehid.BackColor = System.Drawing.Color.AliceBlue;
            this.panelvehid.Controls.Add(this.btnupdate);
            this.panelvehid.Controls.Add(this.dgv1);
            this.panelvehid.Controls.Add(this.txtvehicleno);
            this.panelvehid.Controls.Add(this.txtvehicleid);
            this.panelvehid.Controls.Add(this.lblvehino);
            this.panelvehid.Controls.Add(this.btndelete);
            this.panelvehid.Controls.Add(this.btnadd);
            this.panelvehid.Controls.Add(this.txtvid);
            this.panelvehid.Controls.Add(this.cbobrands);
            this.panelvehid.Controls.Add(this.cbovehitype);
            this.panelvehid.Controls.Add(this.lblbrand);
            this.panelvehid.Controls.Add(this.lblvtypevdetails);
            this.panelvehid.Controls.Add(this.lblvehiclid);
            this.panelvehid.Controls.Add(this.lblvid);
            this.panelvehid.Location = new System.Drawing.Point(33, 43);
            this.panelvehid.Name = "panelvehid";
            this.panelvehid.Size = new System.Drawing.Size(468, 397);
            this.panelvehid.TabIndex = 54;
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(341, 60);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(97, 22);
            this.btnupdate.TabIndex = 75;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv1.Location = new System.Drawing.Point(12, 194);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(445, 181);
            this.dgv1.TabIndex = 74;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "V_ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "V_NO";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Type";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Brand";
            this.Column4.Name = "Column4";
            // 
            // txtvehicleno
            // 
            this.txtvehicleno.Location = new System.Drawing.Point(133, 58);
            this.txtvehicleno.Name = "txtvehicleno";
            this.txtvehicleno.Size = new System.Drawing.Size(180, 20);
            this.txtvehicleno.TabIndex = 73;
            // 
            // txtvehicleid
            // 
            this.txtvehicleid.Location = new System.Drawing.Point(133, 25);
            this.txtvehicleid.Name = "txtvehicleid";
            this.txtvehicleid.Size = new System.Drawing.Size(180, 20);
            this.txtvehicleid.TabIndex = 72;
            // 
            // lblvehino
            // 
            this.lblvehino.AutoSize = true;
            this.lblvehino.BackColor = System.Drawing.Color.White;
            this.lblvehino.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvehino.Location = new System.Drawing.Point(32, 60);
            this.lblvehino.Name = "lblvehino";
            this.lblvehino.Size = new System.Drawing.Size(69, 15);
            this.lblvehino.TabIndex = 71;
            this.lblvehino.Text = "Vehicle No";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(341, 93);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(97, 22);
            this.btndelete.TabIndex = 70;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(341, 25);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(97, 22);
            this.btnadd.TabIndex = 68;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // txtvid
            // 
            this.txtvid.Location = new System.Drawing.Point(124, -21);
            this.txtvid.Name = "txtvid";
            this.txtvid.Size = new System.Drawing.Size(165, 20);
            this.txtvid.TabIndex = 64;
            // 
            // cbobrands
            // 
            this.cbobrands.AutoCompleteCustomSource.AddRange(new string[] {
            "Hyundai ",
            "Honda ",
            "Toyota ",
            "Nissan ",
            "Audi "});
            this.cbobrands.FormattingEnabled = true;
            this.cbobrands.Items.AddRange(new object[] {
            "Toyota",
            "Nissan",
            "Honda ",
            "Hyundai "});
            this.cbobrands.Location = new System.Drawing.Point(133, 133);
            this.cbobrands.Name = "cbobrands";
            this.cbobrands.Size = new System.Drawing.Size(180, 21);
            this.cbobrands.TabIndex = 62;
            // 
            // cbovehitype
            // 
            this.cbovehitype.AutoCompleteCustomSource.AddRange(new string[] {
            "Car ",
            "Van"});
            this.cbovehitype.FormattingEnabled = true;
            this.cbovehitype.Items.AddRange(new object[] {
            "Small Car ",
            "KDH Van ",
            "Mini Van ",
            "Sedan Car"});
            this.cbovehitype.Location = new System.Drawing.Point(133, 96);
            this.cbovehitype.Name = "cbovehitype";
            this.cbovehitype.Size = new System.Drawing.Size(180, 21);
            this.cbovehitype.TabIndex = 61;
            this.cbovehitype.SelectedIndexChanged += new System.EventHandler(this.cbovehitype_SelectedIndexChanged);
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.BackColor = System.Drawing.Color.White;
            this.lblbrand.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrand.Location = new System.Drawing.Point(27, 133);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblbrand.Size = new System.Drawing.Size(45, 15);
            this.lblbrand.TabIndex = 57;
            this.lblbrand.Text = "Brand ";
            // 
            // lblvtypevdetails
            // 
            this.lblvtypevdetails.AutoSize = true;
            this.lblvtypevdetails.BackColor = System.Drawing.Color.White;
            this.lblvtypevdetails.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvtypevdetails.Location = new System.Drawing.Point(33, 93);
            this.lblvtypevdetails.Name = "lblvtypevdetails";
            this.lblvtypevdetails.Size = new System.Drawing.Size(36, 15);
            this.lblvtypevdetails.TabIndex = 56;
            this.lblvtypevdetails.Text = "Type";
            this.lblvtypevdetails.Click += new System.EventHandler(this.lblvtypevdetails_Click);
            // 
            // lblvehiclid
            // 
            this.lblvehiclid.AutoSize = true;
            this.lblvehiclid.BackColor = System.Drawing.Color.White;
            this.lblvehiclid.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvehiclid.Location = new System.Drawing.Point(33, 25);
            this.lblvehiclid.Name = "lblvehiclid";
            this.lblvehiclid.Size = new System.Drawing.Size(65, 15);
            this.lblvehiclid.TabIndex = 55;
            this.lblvehiclid.Text = "Vehicle ID";
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
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp17.Properties.Resources.istockphoto_1281935531_170667a1;
            this.ClientSize = new System.Drawing.Size(529, 464);
            this.Controls.Add(this.panelvehid);
            this.Name = "Vehicle";
            this.Load += new System.EventHandler(this.Vehicle_Load);
            this.panelvehid.ResumeLayout(false);
            this.panelvehid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelvehid;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtvid;
        private System.Windows.Forms.ComboBox cbobrands;
        private System.Windows.Forms.ComboBox cbovehitype;
        private System.Windows.Forms.Label lblbrand;
        private System.Windows.Forms.Label lblvtypevdetails;
        private System.Windows.Forms.Label lblvehiclid;
        private System.Windows.Forms.Label lblvid;
        private System.Windows.Forms.TextBox txtvehicleid;
        private System.Windows.Forms.Label lblvehino;
        private System.Windows.Forms.TextBox txtvehicleno;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnupdate;
    }
}