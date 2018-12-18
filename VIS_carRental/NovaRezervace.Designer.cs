namespace VIS_carRental
{
    partial class NovaRezervace
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
            this.pocetAut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.seznamAut = new System.Windows.Forms.ListBox();
            this.pridejAuto = new System.Windows.Forms.Button();
            this.seznamZak = new System.Windows.Forms.ListBox();
            this.pridejZak = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rekapRez = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.ridicak = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.prijmeni = new System.Windows.Forms.TextBox();
            this.jmeno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.typyAut = new System.Windows.Forms.ComboBox();
            this.pridejPocetAD = new System.Windows.Forms.Button();
            this.vyhledatZak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Datum vyzvednutí";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pocetAut
            // 
            this.pocetAut.Location = new System.Drawing.Point(12, 25);
            this.pocetAut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pocetAut.Name = "pocetAut";
            this.pocetAut.Size = new System.Drawing.Size(223, 22);
            this.pocetAut.TabIndex = 10;
            this.pocetAut.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Datum vrácení";
            // 
            // seznamAut
            // 
            this.seznamAut.FormattingEnabled = true;
            this.seznamAut.ItemHeight = 16;
            this.seznamAut.Location = new System.Drawing.Point(301, 12);
            this.seznamAut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seznamAut.Name = "seznamAut";
            this.seznamAut.Size = new System.Drawing.Size(183, 132);
            this.seznamAut.TabIndex = 20;
            // 
            // pridejAuto
            // 
            this.pridejAuto.Location = new System.Drawing.Point(301, 150);
            this.pridejAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pridejAuto.Name = "pridejAuto";
            this.pridejAuto.Size = new System.Drawing.Size(75, 23);
            this.pridejAuto.TabIndex = 21;
            this.pridejAuto.Text = "Přidat";
            this.pridejAuto.UseVisualStyleBackColor = true;
            this.pridejAuto.Click += new System.EventHandler(this.button1_Click);
            // 
            // seznamZak
            // 
            this.seznamZak.FormattingEnabled = true;
            this.seznamZak.ItemHeight = 16;
            this.seznamZak.Items.AddRange(new object[] {
            "Zákazník1",
            "Zákazník2",
            "Zákazník3"});
            this.seznamZak.Location = new System.Drawing.Point(301, 188);
            this.seznamZak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seznamZak.Name = "seznamZak";
            this.seznamZak.Size = new System.Drawing.Size(183, 132);
            this.seznamZak.TabIndex = 22;
            // 
            // pridejZak
            // 
            this.pridejZak.Location = new System.Drawing.Point(301, 326);
            this.pridejZak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pridejZak.Name = "pridejZak";
            this.pridejZak.Size = new System.Drawing.Size(75, 23);
            this.pridejZak.TabIndex = 23;
            this.pridejZak.Text = "Přidat";
            this.pridejZak.UseVisualStyleBackColor = true;
            this.pridejZak.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(540, 326);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 31);
            this.button3.TabIndex = 26;
            this.button3.Text = "Vytvořit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Počet aut";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Rekapitulace";
            // 
            // rekapRez
            // 
            this.rekapRez.FormattingEnabled = true;
            this.rekapRez.ItemHeight = 16;
            this.rekapRez.Location = new System.Drawing.Point(540, 28);
            this.rekapRez.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rekapRez.Name = "rekapRez";
            this.rekapRez.Size = new System.Drawing.Size(183, 292);
            this.rekapRez.TabIndex = 29;
            this.rekapRez.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 70);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(15, 114);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 17);
            this.label9.TabIndex = 68;
            this.label9.Text = "Číslo řidičského průkazu";
            // 
            // ridicak
            // 
            this.ridicak.Location = new System.Drawing.Point(12, 321);
            this.ridicak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ridicak.Name = "ridicak";
            this.ridicak.Size = new System.Drawing.Size(223, 22);
            this.ridicak.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 66;
            this.label10.Text = "Jméno";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 17);
            this.label13.TabIndex = 65;
            this.label13.Text = "Příjmení";
            // 
            // prijmeni
            // 
            this.prijmeni.Location = new System.Drawing.Point(76, 273);
            this.prijmeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prijmeni.Name = "prijmeni";
            this.prijmeni.Size = new System.Drawing.Size(159, 22);
            this.prijmeni.TabIndex = 64;
            // 
            // jmeno
            // 
            this.jmeno.Location = new System.Drawing.Point(76, 245);
            this.jmeno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jmeno.Name = "jmeno";
            this.jmeno.Size = new System.Drawing.Size(159, 22);
            this.jmeno.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 70;
            this.label3.Text = "Typ auta";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // typyAut
            // 
            this.typyAut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typyAut.FormattingEnabled = true;
            this.typyAut.Location = new System.Drawing.Point(94, 176);
            this.typyAut.Name = "typyAut";
            this.typyAut.Size = new System.Drawing.Size(121, 24);
            this.typyAut.TabIndex = 71;
            this.typyAut.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pridejPocetAD
            // 
            this.pridejPocetAD.Location = new System.Drawing.Point(15, 140);
            this.pridejPocetAD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pridejPocetAD.Name = "pridejPocetAD";
            this.pridejPocetAD.Size = new System.Drawing.Size(75, 23);
            this.pridejPocetAD.TabIndex = 72;
            this.pridejPocetAD.Text = "Přidat";
            this.pridejPocetAD.UseVisualStyleBackColor = true;
            // 
            // vyhledatZak
            // 
            this.vyhledatZak.Location = new System.Drawing.Point(160, 347);
            this.vyhledatZak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vyhledatZak.Name = "vyhledatZak";
            this.vyhledatZak.Size = new System.Drawing.Size(75, 23);
            this.vyhledatZak.TabIndex = 73;
            this.vyhledatZak.Text = "Přidat";
            this.vyhledatZak.UseVisualStyleBackColor = true;
            // 
            // NovaRezervace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 379);
            this.Controls.Add(this.vyhledatZak);
            this.Controls.Add(this.pridejPocetAD);
            this.Controls.Add(this.typyAut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ridicak);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.prijmeni);
            this.Controls.Add(this.jmeno);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rekapRez);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pridejZak);
            this.Controls.Add(this.seznamZak);
            this.Controls.Add(this.pridejAuto);
            this.Controls.Add(this.seznamAut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pocetAut);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NovaRezervace";
            this.Text = "NovaRezervace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pocetAut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox seznamAut;
        private System.Windows.Forms.Button pridejAuto;
        private System.Windows.Forms.ListBox seznamZak;
        private System.Windows.Forms.Button pridejZak;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox rekapRez;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ridicak;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox prijmeni;
        private System.Windows.Forms.TextBox jmeno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typyAut;
        private System.Windows.Forms.Button pridejPocetAD;
        private System.Windows.Forms.Button vyhledatZak;
    }
}