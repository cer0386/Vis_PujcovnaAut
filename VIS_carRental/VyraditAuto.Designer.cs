namespace VIS_carRental
{
    partial class VyraditAuto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.spzText = new System.Windows.Forms.TextBox();
            this.stkJN = new System.Windows.Forms.CheckBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.seznamAut = new System.Windows.Forms.ListBox();
            this.seznamNahrAut = new System.Windows.Forms.ListBox();
            this.najitNahradni = new System.Windows.Forms.Button();
            this.nahradit = new System.Windows.Forms.Button();
            this.vyraditA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Seznam aut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "SPZ";
            // 
            // spzText
            // 
            this.spzText.Location = new System.Drawing.Point(53, 11);
            this.spzText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.spzText.Name = "spzText";
            this.spzText.Size = new System.Drawing.Size(132, 20);
            this.spzText.TabIndex = 40;
            // 
            // stkJN
            // 
            this.stkJN.Location = new System.Drawing.Point(16, 46);
            this.stkJN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stkJN.Name = "stkJN";
            this.stkJN.Size = new System.Drawing.Size(97, 17);
            this.stkJN.TabIndex = 54;
            this.stkJN.Text = "Neplatné STK";
            this.stkJN.UseVisualStyleBackColor = true;
            this.stkJN.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(19, 67);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(166, 26);
            this.button7.TabIndex = 55;
            this.button7.Text = "Vyhledat";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Seznam náhradních aut";
            // 
            // seznamAut
            // 
            this.seznamAut.FormattingEnabled = true;
            this.seznamAut.Location = new System.Drawing.Point(200, 24);
            this.seznamAut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.seznamAut.Name = "seznamAut";
            this.seznamAut.Size = new System.Drawing.Size(197, 251);
            this.seznamAut.TabIndex = 30;
            this.seznamAut.SelectedIndexChanged += new System.EventHandler(this.seznamAut_SelectedIndexChanged);
            // 
            // seznamNahrAut
            // 
            this.seznamNahrAut.FormattingEnabled = true;
            this.seznamNahrAut.Location = new System.Drawing.Point(420, 24);
            this.seznamNahrAut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.seznamNahrAut.Name = "seznamNahrAut";
            this.seznamNahrAut.Size = new System.Drawing.Size(192, 251);
            this.seznamNahrAut.TabIndex = 56;
            // 
            // najitNahradni
            // 
            this.najitNahradni.Location = new System.Drawing.Point(318, 279);
            this.najitNahradni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.najitNahradni.Name = "najitNahradni";
            this.najitNahradni.Size = new System.Drawing.Size(78, 26);
            this.najitNahradni.TabIndex = 58;
            this.najitNahradni.Text = "Najít náhradní";
            this.najitNahradni.UseVisualStyleBackColor = true;
            this.najitNahradni.Click += new System.EventHandler(this.button1_Click);
            // 
            // nahradit
            // 
            this.nahradit.Location = new System.Drawing.Point(420, 279);
            this.nahradit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.nahradit.Name = "nahradit";
            this.nahradit.Size = new System.Drawing.Size(87, 26);
            this.nahradit.TabIndex = 59;
            this.nahradit.Text = "Nahradit";
            this.nahradit.UseVisualStyleBackColor = true;
            this.nahradit.Click += new System.EventHandler(this.nahradit_Click);
            // 
            // vyraditA
            // 
            this.vyraditA.Location = new System.Drawing.Point(200, 279);
            this.vyraditA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.vyraditA.Name = "vyraditA";
            this.vyraditA.Size = new System.Drawing.Size(78, 26);
            this.vyraditA.TabIndex = 61;
            this.vyraditA.Text = "Vyřadit";
            this.vyraditA.UseVisualStyleBackColor = true;
            this.vyraditA.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // VyraditAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 347);
            this.Controls.Add(this.vyraditA);
            this.Controls.Add(this.nahradit);
            this.Controls.Add(this.najitNahradni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seznamNahrAut);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.stkJN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.spzText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seznamAut);
            this.Name = "VyraditAuto";
            this.Text = "VyraditAuto";
            this.Load += new System.EventHandler(this.VyraditAuto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox spzText;
        private System.Windows.Forms.CheckBox stkJN;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox seznamAut;
        private System.Windows.Forms.ListBox seznamNahrAut;
        private System.Windows.Forms.Button najitNahradni;
        private System.Windows.Forms.Button nahradit;
        private System.Windows.Forms.Button vyraditA;
    }
}