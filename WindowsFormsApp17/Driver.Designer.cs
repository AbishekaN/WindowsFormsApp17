namespace WindowsFormsApp17
{
    partial class Driver
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
            this.paneldriverd = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtlisenceno = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtdrivercontno = new System.Windows.Forms.TextBox();
            this.txtdremail = new System.Windows.Forms.TextBox();
            this.txtdrivername = new System.Windows.Forms.TextBox();
            this.txtdriveriid = new System.Windows.Forms.TextBox();
            this.lbldriverrate = new System.Windows.Forms.Label();
            this.lbllisenno = new System.Windows.Forms.Label();
            this.lbldrivername = new System.Windows.Forms.Label();
            this.lbldrivercontno = new System.Windows.Forms.Label();
            this.lbldriverid = new System.Windows.Forms.Label();
            this.txtvid = new System.Windows.Forms.TextBox();
            this.lblvid = new System.Windows.Forms.Label();
            this.paneldriverd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldriverd
            // 
            this.paneldriverd.BackColor = System.Drawing.Color.AliceBlue;
            this.paneldriverd.Controls.Add(this.dataGridView1);
            this.paneldriverd.Controls.Add(this.txtlisenceno);
            this.paneldriverd.Controls.Add(this.btndelete);
            this.paneldriverd.Controls.Add(this.btnupdate);
            this.paneldriverd.Controls.Add(this.btnadd);
            this.paneldriverd.Controls.Add(this.txtdrivercontno);
            this.paneldriverd.Controls.Add(this.txtdremail);
            this.paneldriverd.Controls.Add(this.txtdrivername);
            this.paneldriverd.Controls.Add(this.txtdriveriid);
            this.paneldriverd.Controls.Add(this.lbldriverrate);
            this.paneldriverd.Controls.Add(this.lbllisenno);
            this.paneldriverd.Controls.Add(this.lbldrivername);
            this.paneldriverd.Controls.Add(this.lbldrivercontno);
            this.paneldriverd.Controls.Add(this.lbldriverid);
            this.paneldriverd.Controls.Add(this.txtvid);
            this.paneldriverd.Controls.Add(this.lblvid);
            this.paneldriverd.Location = new System.Drawing.Point(42, 12);
            this.paneldriverd.Name = "paneldriverd";
            this.paneldriverd.Size = new System.Drawing.Size(473, 412);
            this.paneldriverd.TabIndex = 56;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(23, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(421, 165);
            this.dataGridView1.TabIndex = 94;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "D_ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cont_No";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Lisen_No";
            this.Column5.Name = "Column5";
            // 
            // txtlisenceno
            // 
            this.txtlisenceno.Location = new System.Drawing.Point(163, 185);
            this.txtlisenceno.Name = "txtlisenceno";
            this.txtlisenceno.Size = new System.Drawing.Size(176, 20);
            this.txtlisenceno.TabIndex = 93;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(355, 109);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 92;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(355, 73);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 91;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(355, 40);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 90;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtdrivercontno
            // 
            this.txtdrivercontno.Location = new System.Drawing.Point(163, 149);
            this.txtdrivercontno.Name = "txtdrivercontno";
            this.txtdrivercontno.Size = new System.Drawing.Size(176, 20);
            this.txtdrivercontno.TabIndex = 87;
            // 
            // txtdremail
            // 
            this.txtdremail.Location = new System.Drawing.Point(163, 109);
            this.txtdremail.Name = "txtdremail";
            this.txtdremail.Size = new System.Drawing.Size(176, 20);
            this.txtdremail.TabIndex = 86;
            // 
            // txtdrivername
            // 
            this.txtdrivername.Location = new System.Drawing.Point(163, 75);
            this.txtdrivername.Name = "txtdrivername";
            this.txtdrivername.Size = new System.Drawing.Size(176, 20);
            this.txtdrivername.TabIndex = 85;
            // 
            // txtdriveriid
            // 
            this.txtdriveriid.Location = new System.Drawing.Point(163, 40);
            this.txtdriveriid.Name = "txtdriveriid";
            this.txtdriveriid.Size = new System.Drawing.Size(176, 20);
            this.txtdriveriid.TabIndex = 84;
            // 
            // lbldriverrate
            // 
            this.lbldriverrate.AutoSize = true;
            this.lbldriverrate.BackColor = System.Drawing.Color.White;
            this.lbldriverrate.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldriverrate.Location = new System.Drawing.Point(41, 109);
            this.lbldriverrate.Name = "lbldriverrate";
            this.lbldriverrate.Size = new System.Drawing.Size(38, 15);
            this.lbldriverrate.TabIndex = 83;
            this.lbldriverrate.Text = "Email";
            // 
            // lbllisenno
            // 
            this.lbllisenno.AutoSize = true;
            this.lbllisenno.BackColor = System.Drawing.Color.White;
            this.lbllisenno.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllisenno.Location = new System.Drawing.Point(42, 190);
            this.lbllisenno.Name = "lbllisenno";
            this.lbllisenno.Size = new System.Drawing.Size(71, 15);
            this.lbllisenno.TabIndex = 82;
            this.lbllisenno.Text = "Lisence No";
            // 
            // lbldrivername
            // 
            this.lbldrivername.AutoSize = true;
            this.lbldrivername.BackColor = System.Drawing.Color.White;
            this.lbldrivername.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldrivername.Location = new System.Drawing.Point(41, 70);
            this.lbldrivername.Name = "lbldrivername";
            this.lbldrivername.Size = new System.Drawing.Size(40, 15);
            this.lbldrivername.TabIndex = 79;
            this.lbldrivername.Text = "Name";
            // 
            // lbldrivercontno
            // 
            this.lbldrivercontno.AutoSize = true;
            this.lbldrivercontno.BackColor = System.Drawing.Color.White;
            this.lbldrivercontno.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldrivercontno.Location = new System.Drawing.Point(42, 149);
            this.lbldrivercontno.Name = "lbldrivercontno";
            this.lbldrivercontno.Size = new System.Drawing.Size(75, 15);
            this.lbldrivercontno.TabIndex = 80;
            this.lbldrivercontno.Text = "Contact No";
            // 
            // lbldriverid
            // 
            this.lbldriverid.AutoSize = true;
            this.lbldriverid.BackColor = System.Drawing.Color.White;
            this.lbldriverid.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldriverid.Location = new System.Drawing.Point(41, 35);
            this.lbldriverid.Name = "lbldriverid";
            this.lbldriverid.Size = new System.Drawing.Size(59, 15);
            this.lbldriverid.TabIndex = 81;
            this.lbldriverid.Text = "Driver ID";
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
            // Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp17.Properties.Resources.istockphoto_1281935531_170667a1;
            this.ClientSize = new System.Drawing.Size(553, 436);
            this.Controls.Add(this.paneldriverd);
            this.Name = "Driver";
            this.Text = "Driver";
            this.Load += new System.EventHandler(this.Driver_Load);
            this.paneldriverd.ResumeLayout(false);
            this.paneldriverd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel paneldriverd;
        private System.Windows.Forms.TextBox txtvid;
        private System.Windows.Forms.Label lblvid;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtdrivercontno;
        private System.Windows.Forms.TextBox txtdremail;
        private System.Windows.Forms.TextBox txtdrivername;
        private System.Windows.Forms.TextBox txtdriveriid;
        private System.Windows.Forms.Label lbldriverrate;
        private System.Windows.Forms.Label lbllisenno;
        private System.Windows.Forms.Label lbldrivername;
        private System.Windows.Forms.Label lbldrivercontno;
        private System.Windows.Forms.Label lbldriverid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtlisenceno;
    }
}