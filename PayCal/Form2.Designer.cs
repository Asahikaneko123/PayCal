
namespace PayCal
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.CONT = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.DES = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.LN = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.FN = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.Stat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.circularPictureBox2 = new PayCal.CircularPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CONT
            // 
            this.CONT.Location = new System.Drawing.Point(117, 342);
            this.CONT.Name = "CONT";
            this.CONT.Size = new System.Drawing.Size(174, 20);
            this.CONT.TabIndex = 23;
            this.CONT.WaterMark = "Contact";
            this.CONT.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.CONT.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONT.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // DES
            // 
            this.DES.Location = new System.Drawing.Point(117, 316);
            this.DES.Name = "DES";
            this.DES.Size = new System.Drawing.Size(174, 20);
            this.DES.TabIndex = 22;
            this.DES.WaterMark = "Designation";
            this.DES.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.DES.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DES.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // LN
            // 
            this.LN.Location = new System.Drawing.Point(117, 290);
            this.LN.Name = "LN";
            this.LN.Size = new System.Drawing.Size(174, 20);
            this.LN.TabIndex = 21;
            this.LN.WaterMark = "Last Name";
            this.LN.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.LN.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LN.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // FN
            // 
            this.FN.Location = new System.Drawing.Point(117, 264);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(174, 20);
            this.FN.TabIndex = 20;
            this.FN.WaterMark = "First Name";
            this.FN.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.FN.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FN.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // Stat
            // 
            this.Stat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Stat.FormattingEnabled = true;
            this.Stat.Items.AddRange(new object[] {
            "Full-Time ",
            "Part-Time ",
            "Intern "});
            this.Stat.Location = new System.Drawing.Point(117, 368);
            this.Stat.Name = "Stat";
            this.Stat.Size = new System.Drawing.Size(174, 21);
            this.Stat.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(238, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Edit Employee";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.circularPictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Stat);
            this.panel1.Controls.Add(this.CONT);
            this.panel1.Controls.Add(this.FN);
            this.panel1.Controls.Add(this.DES);
            this.panel1.Controls.Add(this.LN);
            this.panel1.Location = new System.Drawing.Point(121, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 518);
            this.panel1.TabIndex = 25;
            // 
            // circularPictureBox2
            // 
            this.circularPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox2.Image")));
            this.circularPictureBox2.Location = new System.Drawing.Point(117, 87);
            this.circularPictureBox2.Name = "circularPictureBox2";
            this.circularPictureBox2.Size = new System.Drawing.Size(174, 143);
            this.circularPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.circularPictureBox2.TabIndex = 26;
            this.circularPictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "EDIT EMPLOYEE";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 606);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ChreneLib.Controls.TextBoxes.CTextBox CONT;
        private ChreneLib.Controls.TextBoxes.CTextBox DES;
        private ChreneLib.Controls.TextBoxes.CTextBox LN;
        private ChreneLib.Controls.TextBoxes.CTextBox FN;
        private System.Windows.Forms.ComboBox Stat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CircularPictureBox circularPictureBox2;
    }
}