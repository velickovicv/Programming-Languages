namespace WinFormeVezbanje
{
    public partial class Form1 : Form
    {
        private List<Automobil> automobili = new List<Automobil>();
        public Form1()
        {
            InitializeComponent();

            numZapremina.Minimum = 0.5m;
            numZapremina.Maximum = 10m;
            numZapremina.DecimalPlaces = 3;
            numZapremina.Increment = 0.1m;
            numZapremina.Value = 0.5m;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtboxProzivodjac_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeDatumProizvodnje_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Dizel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Gas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void imaAtest_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtboxProizvodjac.Text))
            {
                MessageBox.Show("Unesite proizvodjaca!");
                txtboxProizvodjac.Focus();
                return;
            }
            if(string.IsNullOrWhiteSpace(txtboxModel.Text))
            {
                MessageBox.Show("Unesite model!");
                txtboxModel.Focus();
                return;
            }

            // Citanje podataka

            string proizvodjac = txtboxProizvodjac.Text.Trim();
            string model = txtboxModel.Text.Trim();
            double zapremina = (double)numZapremina.Value;
            DateTime datum = dtpDatum.Value;

            VrstaGoriva gorivo;
            if (Benzin.Checked)
                gorivo = VrstaGoriva.Benzin;
            else if (Dizel.Checked)
                gorivo = VrstaGoriva.Dizel;
            else
                gorivo = VrstaGoriva.Gas;

            bool imaAtest = (gorivo == VrstaGoriva.Gas) && chAtest.Checked;

            Automobil auto = new Automobil(proizvodjac, model, zapremina, datum, gorivo, imaAtest);
            automobili.Add(auto);

            OsveziListu();

            txtboxProizvodjac.Clear();
            txtboxModel.Clear();
            numZapremina.Value = 0.5m;
            Benzin.Checked = true;
            chAtest.Checked = false;
            txtboxProizvodjac.Focus();
        }

        private void OsveziListu()
        {
            listBoxPregled.Items.Clear();

            foreach (Automobil a in automobili)
            {
                string prikaz = $"{a.Proizvodjac} {a.Model} - {a.ZapreminaMotora:F3}L - {a.DatumProizvodnje:dd.MM.yyyy} - {a.Gorivo}";

                if (a.Gorivo == VrstaGoriva.Gas)
                {
                    prikaz += a.ImaAtest ? " - Atest: DA" : " - Atest: NE";

                    
                }
                listBoxPregled.Items.Add(prikaz);
            }
        }
        private void listBoxPregled_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
