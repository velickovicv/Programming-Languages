namespace WinFormeVezbanje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtboxProizvodjac = new TextBox();
            txtboxModel = new TextBox();
            label1 = new Label();
            label2 = new Label();
            numZapremina = new NumericUpDown();
            label3 = new Label();
            dtpDatum = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            Benzin = new RadioButton();
            Gas = new RadioButton();
            Dizel = new RadioButton();
            chAtest = new CheckBox();
            btnDodaj = new Button();
            listBoxPregled = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numZapremina).BeginInit();
            SuspendLayout();
            // 
            // txtboxProizvodjac
            // 
            txtboxProizvodjac.Location = new Point(216, 45);
            txtboxProizvodjac.Name = "txtboxProizvodjac";
            txtboxProizvodjac.Size = new Size(150, 27);
            txtboxProizvodjac.TabIndex = 1;
            txtboxProizvodjac.TextChanged += txtboxProzivodjac_TextChanged;
            // 
            // txtboxModel
            // 
            txtboxModel.Location = new Point(216, 92);
            txtboxModel.Name = "txtboxModel";
            txtboxModel.Size = new Size(150, 27);
            txtboxModel.TabIndex = 2;
            txtboxModel.TextChanged += txtboxModel_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 45);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 3;
            label1.Text = "Prozivodjac:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 95);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 4;
            label2.Text = "Model:";
            // 
            // numZapremina
            // 
            numZapremina.Location = new Point(216, 142);
            numZapremina.Name = "numZapremina";
            numZapremina.Size = new Size(150, 27);
            numZapremina.TabIndex = 5;
            numZapremina.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 149);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 6;
            label3.Text = "Zapremina Motora:";
            // 
            // dtpDatum
            // 
            dtpDatum.Format = DateTimePickerFormat.Short;
            dtpDatum.Location = new Point(216, 191);
            dtpDatum.Margin = new Padding(2);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(150, 27);
            dtpDatum.TabIndex = 7;
            dtpDatum.ValueChanged += dateTimeDatumProizvodnje_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 198);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 8;
            label4.Text = "Datum proizvodnje: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 244);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 9;
            label5.Text = "Vrsta goriva:";
            // 
            // Benzin
            // 
            Benzin.AutoSize = true;
            Benzin.Location = new Point(73, 276);
            Benzin.Name = "Benzin";
            Benzin.Size = new Size(74, 24);
            Benzin.TabIndex = 14;
            Benzin.TabStop = true;
            Benzin.Text = "Benzin";
            Benzin.UseVisualStyleBackColor = true;
            Benzin.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Gas
            // 
            Gas.AutoSize = true;
            Gas.Location = new Point(242, 276);
            Gas.Name = "Gas";
            Gas.Size = new Size(54, 24);
            Gas.TabIndex = 15;
            Gas.TabStop = true;
            Gas.Text = "Gas";
            Gas.UseVisualStyleBackColor = true;
            Gas.CheckedChanged += Gas_CheckedChanged;
            // 
            // Dizel
            // 
            Dizel.AutoSize = true;
            Dizel.Location = new Point(155, 276);
            Dizel.Name = "Dizel";
            Dizel.Size = new Size(64, 24);
            Dizel.TabIndex = 16;
            Dizel.TabStop = true;
            Dizel.Text = "Dizel";
            Dizel.UseVisualStyleBackColor = true;
            Dizel.CheckedChanged += Dizel_CheckedChanged;
            // 
            // chAtest
            // 
            chAtest.AutoSize = true;
            chAtest.Location = new Point(73, 318);
            chAtest.Name = "chAtest";
            chAtest.Size = new Size(94, 24);
            chAtest.TabIndex = 17;
            chAtest.Text = "Ima Atest";
            chAtest.UseVisualStyleBackColor = true;
            chAtest.CheckedChanged += imaAtest_CheckedChanged;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(73, 357);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 18;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // listBoxPregled
            // 
            listBoxPregled.FormattingEnabled = true;
            listBoxPregled.Location = new Point(73, 400);
            listBoxPregled.Name = "listBoxPregled";
            listBoxPregled.Size = new Size(502, 104);
            listBoxPregled.TabIndex = 19;
            listBoxPregled.SelectedIndexChanged += listBoxPregled_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 516);
            Controls.Add(listBoxPregled);
            Controls.Add(btnDodaj);
            Controls.Add(chAtest);
            Controls.Add(Dizel);
            Controls.Add(Gas);
            Controls.Add(Benzin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpDatum);
            Controls.Add(label3);
            Controls.Add(numZapremina);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtboxModel);
            Controls.Add(txtboxProizvodjac);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numZapremina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxProizvodjac;
        private TextBox txtboxModel;
        private Label label1;
        private Label label2;
        private NumericUpDown numZapremina;
        private Label label3;
        private DateTimePicker dtpDatum;
        private Label label4;
        private Label label5;
        private RadioButton Benzin;
        private RadioButton Gas;
        private RadioButton Dizel;
        private CheckBox chAtest;
        private Button btnDodaj;
        private ListBox listBoxPregled;
    }
}
