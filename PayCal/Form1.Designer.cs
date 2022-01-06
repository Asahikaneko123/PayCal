
namespace PayCal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.Stat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EC = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.FN = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.LN = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.DES = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.CONT = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.circularPictureBox1 = new PayCal.CircularPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(234, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stat
            // 
            this.Stat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Stat.FormattingEnabled = true;
            this.Stat.Items.AddRange(new object[] {
            "Full-Time ",
            "Part-Time ",
            "Intern "});
            this.Stat.Location = new System.Drawing.Point(234, 421);
            this.Stat.Name = "Stat";
            this.Stat.Size = new System.Drawing.Size(174, 21);
            this.Stat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "ADD EMPLOYEE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EC
            // 
            this.EC.Location = new System.Drawing.Point(234, 281);
            this.EC.Name = "EC";
            this.EC.Size = new System.Drawing.Size(174, 20);
            this.EC.TabIndex = 9;
            this.EC.WaterMark = "Employee Code";
            this.EC.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.EC.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EC.WaterMarkForeColor = System.Drawing.Color.LightGray;
            this.EC.TextChanged += new System.EventHandler(this.cTextBox1_TextChanged);
            // 
            // FN
            // 
            this.FN.Location = new System.Drawing.Point(234, 307);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(174, 20);
            this.FN.TabIndex = 10;
            this.FN.WaterMark = "First Name";
            this.FN.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.FN.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FN.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // LN
            // 
            this.LN.Location = new System.Drawing.Point(234, 333);
            this.LN.Name = "LN";
            this.LN.Size = new System.Drawing.Size(174, 20);
            this.LN.TabIndex = 11;
            this.LN.WaterMark = "Last Name";
            this.LN.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.LN.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LN.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // DES
            // 
            this.DES.Location = new System.Drawing.Point(234, 359);
            this.DES.Name = "DES";
            this.DES.Size = new System.Drawing.Size(174, 20);
            this.DES.TabIndex = 12;
            this.DES.WaterMark = "Designation";
            this.DES.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.DES.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DES.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // CONT
            // 
            this.CONT.Location = new System.Drawing.Point(234, 385);
            this.CONT.Name = "CONT";
            this.CONT.Size = new System.Drawing.Size(174, 20);
            this.CONT.TabIndex = 13;
            this.CONT.WaterMark = "Contact";
            this.CONT.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.CONT.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONT.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.circularPictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(117, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 518);
            this.panel1.TabIndex = 16;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.Image")));
            this.circularPictureBox1.Location = new System.Drawing.Point(117, 83);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(174, 143);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.circularPictureBox1.TabIndex = 14;
            this.circularPictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 616);
            this.Controls.Add(this.CONT);
            this.Controls.Add(this.DES);
            this.Controls.Add(this.LN);
            this.Controls.Add(this.FN);
            this.Controls.Add(this.EC);
            this.Controls.Add(this.Stat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Stat;
        private System.Windows.Forms.Label label1;
        private ChreneLib.Controls.TextBoxes.CTextBox EC;
        private ChreneLib.Controls.TextBoxes.CTextBox FN;
        private ChreneLib.Controls.TextBoxes.CTextBox LN;
        private ChreneLib.Controls.TextBoxes.CTextBox DES;
        private ChreneLib.Controls.TextBoxes.CTextBox CONT;
        private CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

