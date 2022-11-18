namespace WindowsFormsApp17
{
    partial class Customer
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
            this.panelcustde = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtcustcontno = new System.Windows.Forms.TextBox();
            this.txtcustaddress = new System.Windows.Forms.TextBox();
            this.txtcustname = new System.Windows.Forms.TextBox();
            this.txtcustid = new System.Windows.Forms.TextBox();
            this.lblcustaddress = new System.Windows.Forms.Label();
            this.lblcustname = new System.Windows.Forms.Label();
            this.lblcustcontno = new System.Windows.Forms.Label();
            this.lblcustid = new System.Windows.Forms.Label();
            this.txtvid = new System.Windows.Forms.TextBox();
            this.lblvid = new System.Windows.Forms.Label();
            this.panelcustde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcustde
            // 
            this.panelcustde.BackColor = System.Drawing.Color.AliceBlue;
            this.panelcustde.Controls.Add(this.dataGridView1);
            this.panelcustde.Controls.Add(this.btndelete);
            this.panelcustde.Controls.Add(this.btnupdate);
            this.panelcustde.Controls.Add(this.btnadd);
            this.panelcustde.Controls.Add(this.txtcustcontno);
            this.panelcustde.Controls.Add(this.txtcustaddress);
            this.panelcustde.Controls.Add(this.txtcustname);
            this.panelcustde.Controls.Add(this.txtcustid);
            this.panelcustde.Controls.Add(this.lblcustaddress);
            this.panelcustde.Controls.Add(this.lblcustname);
            this.panelcustde.Controls.Add(this.lblcustcontno);
            this.panelcustde.Controls.Add(this.lblcustid);
            this.panelcustde.Controls.Add(this.txtvid);
            this.panelcustde.Controls.Add(this.lblvid);
            this.panelcustde.Location = new System.Drawing.Point(33, 30);
            this.panelcustde.Name = "panelcustde";
            this.panelcustde.Size = new System.Drawing.Size(473, 385);
            this.panelcustde.TabIndex = 55;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(31, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 160);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "C_ID";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Address";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Contact_No";
            this.Column2.Name = "Column2";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(370, 94);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 78;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(370, 65);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 77;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(370, 33);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 76;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtcustcontno
            // 
            this.txtcustcontno.Location = new System.Drawing.Point(154, 142);
            this.txtcustcontno.Name = "txtcustcontno";
            this.txtcustcontno.Size = new System.Drawing.Size(181, 20);
            this.txtcustcontno.TabIndex = 73;
            // 
            // txtcustaddress
            // 
            this.txtcustaddress.Location = new System.Drawing.Point(154, 102);
            this.txtcustaddress.Name = "txtcustaddress";
            this.txtcustaddress.Size = new System.Drawing.Size(181, 20);
            this.txtcustaddress.TabIndex = 72;
            // 
            // txtcustname
            // 
            this.txtcustname.Location = new System.Drawing.Point(154, 68);
            this.txtcustname.Name = "txtcustname";
            this.txtcustname.Size = new System.Drawing.Size(181, 20);
            this.txtcustname.TabIndex = 71;
            // 
            // txtcustid
            // 
            this.txtcustid.Location = new System.Drawing.Point(154, 33);
            this.txtcustid.Name = "txtcustid";
            this.txtcustid.Size = new System.Drawing.Size(181, 20);
            this.txtcustid.TabIndex = 70;
            // 
            // lblcustaddress
            // 
            this.lblcustaddress.AutoSize = true;
            this.lblcustaddress.BackColor = System.Drawing.Color.White;
            this.lblcustaddress.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustaddress.Location = new System.Drawing.Point(28, 107);
            this.lblcustaddress.Name = "lblcustaddress";
            this.lblcustaddress.Size = new System.Drawing.Size(58, 15);
            this.lblcustaddress.TabIndex = 69;
            this.lblcustaddress.Text = "Address";
            // 
            // lblcustname
            // 
            this.lblcustname.AutoSize = true;
            this.lblcustname.BackColor = System.Drawing.Color.White;
            this.lblcustname.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustname.Location = new System.Drawing.Point(28, 68);
            this.lblcustname.Name = "lblcustname";
            this.lblcustname.Size = new System.Drawing.Size(40, 15);
            this.lblcustname.TabIndex = 65;
            this.lblcustname.Text = "Name";
            // 
            // lblcustcontno
            // 
            this.lblcustcontno.AutoSize = true;
            this.lblcustcontno.BackColor = System.Drawing.Color.White;
            this.lblcustcontno.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustcontno.Location = new System.Drawing.Point(29, 147);
            this.lblcustcontno.Name = "lblcustcontno";
            this.lblcustcontno.Size = new System.Drawing.Size(75, 15);
            this.lblcustcontno.TabIndex = 66;
            this.lblcustcontno.Text = "Contact No";
            // 
            // lblcustid
            // 
            this.lblcustid.AutoSize = true;
            this.lblcustid.BackColor = System.Drawing.Color.White;
            this.lblcustid.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustid.Location = new System.Drawing.Point(28, 33);
            this.lblcustid.Name = "lblcustid";
            this.lblcustid.Size = new System.Drawing.Size(82, 15);
            this.lblcustid.TabIndex = 67;
            this.lblcustid.Text = "Customer ID";
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
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp17.Properties.Resources.istockphoto_1281935531_170667a1;
            this.ClientSize = new System.Drawing.Size(555, 427);
            this.Controls.Add(this.panelcustde);
            this.Name = "Customer";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panelcustde.ResumeLayout(false);
            this.panelcustde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcustde;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtcustcontno;
        private System.Windows.Forms.TextBox txtcustaddress;
        private System.Windows.Forms.TextBox txtcustname;
        private System.Windows.Forms.TextBox txtcustid;
        private System.Windows.Forms.Label lblcustaddress;
        private System.Windows.Forms.Label lblcustname;
        private System.Windows.Forms.Label lblcustcontno;
        private System.Windows.Forms.Label lblcustid;
        private System.Windows.Forms.TextBox txtvid;
        private System.Windows.Forms.Label lblvid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}