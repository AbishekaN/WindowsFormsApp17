namespace WindowsFormsApp17
{
    partial class Hire
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
            this.panelhired = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbovtype2 = new System.Windows.Forms.ComboBox();
            this.btncalculatehire = new System.Windows.Forms.Button();
            this.txtovernightchages = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbltprice = new System.Windows.Forms.Label();
            this.txttotalpricehire = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtendkm = new System.Windows.Forms.TextBox();
            this.txtstkm = new System.Windows.Forms.TextBox();
            this.lblstartkm = new System.Windows.Forms.Label();
            this.lblendtime = new System.Windows.Forms.Label();
            this.lblstrttime = new System.Windows.Forms.Label();
            this.lblovernughtchrges = new System.Windows.Forms.Label();
            this.lblhirevtype = new System.Windows.Forms.Label();
            this.lblpackage = new System.Windows.Forms.Label();
            this.panelhired.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(12, 382);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 30;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // panelhired
            // 
            this.panelhired.BackColor = System.Drawing.Color.AliceBlue;
            this.panelhired.Controls.Add(this.comboBox1);
            this.panelhired.Controls.Add(this.cbovtype2);
            this.panelhired.Controls.Add(this.btncalculatehire);
            this.panelhired.Controls.Add(this.txtovernightchages);
            this.panelhired.Controls.Add(this.dateTimePicker2);
            this.panelhired.Controls.Add(this.dateTimePicker1);
            this.panelhired.Controls.Add(this.lbltprice);
            this.panelhired.Controls.Add(this.txttotalpricehire);
            this.panelhired.Controls.Add(this.label4);
            this.panelhired.Controls.Add(this.txtendkm);
            this.panelhired.Controls.Add(this.txtstkm);
            this.panelhired.Controls.Add(this.lblstartkm);
            this.panelhired.Controls.Add(this.lblendtime);
            this.panelhired.Controls.Add(this.lblstrttime);
            this.panelhired.Controls.Add(this.lblovernughtchrges);
            this.panelhired.Controls.Add(this.lblhirevtype);
            this.panelhired.Controls.Add(this.lblpackage);
            this.panelhired.Location = new System.Drawing.Point(64, 33);
            this.panelhired.Name = "panelhired";
            this.panelhired.Size = new System.Drawing.Size(393, 330);
            this.panelhired.TabIndex = 31;
            this.panelhired.Paint += new System.Windows.Forms.PaintEventHandler(this.panelhired_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Smaller Car ",
            "KDH Van ",
            "Mini Van ",
            "Sedan Car "});
            this.comboBox1.Location = new System.Drawing.Point(178, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 92;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbovtype2
            // 
            this.cbovtype2.FormattingEnabled = true;
            this.cbovtype2.Items.AddRange(new object[] {
            "Airport Drop ",
            "Airport Pickup ",
            "100KM Package",
            "200KM Package"});
            this.cbovtype2.Location = new System.Drawing.Point(178, 25);
            this.cbovtype2.Name = "cbovtype2";
            this.cbovtype2.Size = new System.Drawing.Size(157, 21);
            this.cbovtype2.TabIndex = 91;
            this.cbovtype2.SelectedIndexChanged += new System.EventHandler(this.cbovtype2_SelectedIndexChanged);
            // 
            // btncalculatehire
            // 
            this.btncalculatehire.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculatehire.Location = new System.Drawing.Point(275, 272);
            this.btncalculatehire.Name = "btncalculatehire";
            this.btncalculatehire.Size = new System.Drawing.Size(88, 42);
            this.btncalculatehire.TabIndex = 90;
            this.btncalculatehire.Text = "Calculate";
            this.btncalculatehire.UseVisualStyleBackColor = true;
            this.btncalculatehire.Click += new System.EventHandler(this.btncalculatehire_Click);
            // 
            // txtovernightchages
            // 
            this.txtovernightchages.Location = new System.Drawing.Point(178, 99);
            this.txtovernightchages.Name = "txtovernightchages";
            this.txtovernightchages.Size = new System.Drawing.Size(157, 20);
            this.txtovernightchages.TabIndex = 89;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(178, 151);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker2.TabIndex = 88;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 87;
            // 
            // lbltprice
            // 
            this.lbltprice.AutoSize = true;
            this.lbltprice.BackColor = System.Drawing.Color.White;
            this.lbltprice.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltprice.Location = new System.Drawing.Point(65, 277);
            this.lbltprice.Name = "lbltprice";
            this.lbltprice.Size = new System.Drawing.Size(70, 15);
            this.lbltprice.TabIndex = 85;
            this.lbltprice.Text = "Total Price";
            // 
            // txttotalpricehire
            // 
            this.txttotalpricehire.Location = new System.Drawing.Point(157, 272);
            this.txttotalpricehire.Name = "txttotalpricehire";
            this.txttotalpricehire.Size = new System.Drawing.Size(97, 20);
            this.txttotalpricehire.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 83;
            this.label4.Text = "Ending KM";
            // 
            // txtendkm
            // 
            this.txtendkm.Location = new System.Drawing.Point(178, 222);
            this.txtendkm.Name = "txtendkm";
            this.txtendkm.Size = new System.Drawing.Size(157, 20);
            this.txtendkm.TabIndex = 84;
            // 
            // txtstkm
            // 
            this.txtstkm.Location = new System.Drawing.Point(178, 185);
            this.txtstkm.Name = "txtstkm";
            this.txtstkm.Size = new System.Drawing.Size(157, 20);
            this.txtstkm.TabIndex = 83;
            // 
            // lblstartkm
            // 
            this.lblstartkm.AutoSize = true;
            this.lblstartkm.BackColor = System.Drawing.Color.White;
            this.lblstartkm.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstartkm.Location = new System.Drawing.Point(30, 190);
            this.lblstartkm.Name = "lblstartkm";
            this.lblstartkm.Size = new System.Drawing.Size(75, 15);
            this.lblstartkm.TabIndex = 82;
            this.lblstartkm.Text = "Starting KM";
            // 
            // lblendtime
            // 
            this.lblendtime.AutoSize = true;
            this.lblendtime.BackColor = System.Drawing.Color.White;
            this.lblendtime.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendtime.Location = new System.Drawing.Point(30, 161);
            this.lblendtime.Name = "lblendtime";
            this.lblendtime.Size = new System.Drawing.Size(62, 15);
            this.lblendtime.TabIndex = 81;
            this.lblendtime.Text = "End Time";
            // 
            // lblstrttime
            // 
            this.lblstrttime.AutoSize = true;
            this.lblstrttime.BackColor = System.Drawing.Color.White;
            this.lblstrttime.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstrttime.Location = new System.Drawing.Point(30, 130);
            this.lblstrttime.Name = "lblstrttime";
            this.lblstrttime.Size = new System.Drawing.Size(69, 15);
            this.lblstrttime.TabIndex = 80;
            this.lblstrttime.Text = "Start Time";
            // 
            // lblovernughtchrges
            // 
            this.lblovernughtchrges.AutoSize = true;
            this.lblovernughtchrges.BackColor = System.Drawing.Color.White;
            this.lblovernughtchrges.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblovernughtchrges.Location = new System.Drawing.Point(28, 97);
            this.lblovernughtchrges.Name = "lblovernughtchrges";
            this.lblovernughtchrges.Size = new System.Drawing.Size(118, 15);
            this.lblovernughtchrges.TabIndex = 79;
            this.lblovernughtchrges.Text = "Overnight Charges";
            // 
            // lblhirevtype
            // 
            this.lblhirevtype.AutoSize = true;
            this.lblhirevtype.BackColor = System.Drawing.Color.White;
            this.lblhirevtype.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhirevtype.Location = new System.Drawing.Point(30, 64);
            this.lblhirevtype.Name = "lblhirevtype";
            this.lblhirevtype.Size = new System.Drawing.Size(82, 15);
            this.lblhirevtype.TabIndex = 77;
            this.lblhirevtype.Text = "Vehicle Type";
            // 
            // lblpackage
            // 
            this.lblpackage.AutoSize = true;
            this.lblpackage.BackColor = System.Drawing.Color.White;
            this.lblpackage.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpackage.Location = new System.Drawing.Point(28, 27);
            this.lblpackage.Name = "lblpackage";
            this.lblpackage.Size = new System.Drawing.Size(59, 15);
            this.lblpackage.TabIndex = 75;
            this.lblpackage.Text = "Package ";
            // 
            // Hire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::WindowsFormsApp17.Properties.Resources.istockphoto_1281935531_170667a1;
            this.ClientSize = new System.Drawing.Size(507, 448);
            this.Controls.Add(this.panelhired);
            this.Controls.Add(this.btnback);
            this.Name = "Hire";
            this.Text = "Hire";
            this.Load += new System.EventHandler(this.Hire_Load);
            this.panelhired.ResumeLayout(false);
            this.panelhired.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel panelhired;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbltprice;
        private System.Windows.Forms.TextBox txttotalpricehire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtendkm;
        private System.Windows.Forms.TextBox txtstkm;
        private System.Windows.Forms.Label lblstartkm;
        private System.Windows.Forms.Label lblendtime;
        private System.Windows.Forms.Label lblstrttime;
        private System.Windows.Forms.Label lblovernughtchrges;
        private System.Windows.Forms.Label lblhirevtype;
        private System.Windows.Forms.Label lblpackage;
        private System.Windows.Forms.Button btncalculatehire;
        private System.Windows.Forms.TextBox txtovernightchages;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbovtype2;
    }
}