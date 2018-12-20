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
            this.label1.Location = new System.Drawing.Point(263, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Seznam aut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "SPZ";
            // 
            // spzText
            // 
            this.spzText.Location = new System.Drawing.Point(71, 14);
            this.spzText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spzText.Name = "spzText";
            this.spzText.Size = new System.Drawing.Size(175, 22);
            this.spzText.TabIndex = 40;
            // 
            // stkJN
            // 
            this.stkJN.Location = new System.Drawing.Point(21, 57);
            this.stkJN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stkJN.Name = "stkJN";
            this.stkJN.Size = new System.Drawing.Size(129, 21);
            this.stkJN.TabIndex = 54;
            this.stkJN.Text = "Neplatné STK";
            this.stkJN.UseVisualStyleBackColor = true;
            this.stkJN.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(25, 82);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(221, 32);
            this.button7.TabIndex = 55;
            this.button7.Text = "Vyhledat";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Seznam náhradních aut";
            // 
            // seznamAut
            // 
            this.seznamAut.FormattingEnabled = true;
            this.seznamAut.ItemHeight = 16;
            this.seznamAut.Location = new System.Drawing.Point(267, 30);
            this.seznamAut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seznamAut.Name = "seznamAut";
            this.seznamAut.Size = new System.Drawing.Size(261, 308);
            this.seznamAut.TabIndex = 30;
            this.seznamAut.SelectedIndexChanged += new System.EventHandler(this.seznamAut_SelectedIndexChanged);
            // 
            // seznamNahrAut
            // 
            this.seznamNahrAut.FormattingEnabled = true;
            this.seznamNahrAut.ItemHeight = 16;
            this.seznamNahrAut.Location = new System.Drawing.Point(560, 30);
            this.seznamNahrAut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seznamNahrAut.Name = "seznamNahrAut";
            this.seznamNahrAut.Size = new System.Drawing.Size(255, 308);
            this.seznamNahrAut.TabIndex = 56;
            // 
            // najitNahradni
            // 
            this.najitNahradni.Location = new System.Drawing.Point(424, 343);
            this.najitNahradni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 1);
            this.najitNahradni.Name = "najitNahradni";
            this.najitNahradni.Size = new System.Drawing.Size(104, 32);
            this.najitNahradni.TabIndex = 58;
            this.najitNahradni.Text = "Najít náhradní";
            this.najitNahradni.UseVisualStyleBackColor = true;
            this.najitNahradni.Click += new System.EventHandler(this.button1_Click);
            // 
            // nahradit
            // 
            this.nahradit.Location = new System.Drawing.Point(560, 343);
            this.nahradit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 1);
            this.nahradit.Name = "nahradit";
            this.nahradit.Size = new System.Drawing.Size(116, 32);
            this.nahradit.TabIndex = 59;
            this.nahradit.Text = "Nahradit";
            this.nahradit.UseVisualStyleBackColor = true;
            // 
            // vyraditA
            // 
            this.vyraditA.Location = new System.Drawing.Point(267, 343);
            this.vyraditA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 1);
            this.vyraditA.Name = "vyraditA";
            this.vyraditA.Size = new System.Drawing.Size(104, 32);
            this.vyraditA.TabIndex = 61;
            this.vyraditA.Text = "Vyřadit";
            this.vyraditA.UseVisualStyleBackColor = true;
            this.vyraditA.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // VyraditAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 427);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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