namespace Biblioteka
{
    public partial class Form1 : Form
    {

        private List<Knjiga> knjige = new List<Knjiga>();
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(Enum.GetNames(typeof(Zanr)));
            comboBox1.SelectedIndex = 0;

            numIzdavanje.Minimum = 0;
            numIzdavanje.Maximum = 3000;
            dtpDatum.Enabled = false;
            numIzdavanje.Value = 0;

            dtpDatum.Format = DateTimePickerFormat.Short;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNaslov_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numIzdavanje_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chIzdata_CheckedChanged(object sender, EventArgs e)
        {
            if(chIzdata.Checked)
            {
                dtpDatum.Enabled = true;

                dtpDatum.Value = DateTime.Now.AddDays(14);

                numIzdavanje.Value = numIzdavanje.Value + 1;
            }
            else
            {
                dtpDatum.Enabled = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNaslov.Text))
            {
                MessageBox.Show("Dodajte naslov!");
                txtNaslov.Focus();
                return;
            }
            if(string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("Unesite autora!");
                txtAutor.Focus();
                return;
            }

            string naslov = txtNaslov.Text.Trim();
            string autor = txtAutor.Text.Trim();
            string zanr = comboBox1.SelectedItem.ToString();
            int broj = (int)numIzdavanje.Value;
            bool izdata = chIzdata.Checked;
            DateTime datum = dtpDatum.Value;

            Knjiga novaKnjiga = new Knjiga(naslov, autor, zanr, broj, izdata, datum);
            knjige.Add(novaKnjiga);

            osveziListu();
        }

        private void boxLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxLista.SelectedIndex == -1)
            {
                MessageBox.Show("Nije selektovana knjiga");
                return;
            }

            Knjiga k = knjige[boxLista.SelectedIndex];

            txtNaslov.Text = k.Naslov;
            txtAutor.Text = k.Autor;
            comboBox1.SelectedItem = k.Zanr;
            numIzdavanje.Value = k.Broj;
            chIzdata.Checked = k.Izdata;

            if(k.Izdata)
            {
                dtpDatum.Enabled = true;
                dtpDatum.Value = k.Datum;
            }
            else
            {
                dtpDatum.Enabled = false;
            }
        }

        private void osveziListu()
        {
            boxLista.Items.Clear();

            foreach(Knjiga k in knjige)
            {
                string prikaz = $"{k.Naslov} - {k.Autor} - {k.Zanr} - {k.Broj} - {k.Izdata}";

                if(k.Izdata)
                {
                    prikaz += $"{k.Datum:dd.MM.yyyy}";
                }

                boxLista.Items.Add(prikaz);
            }
        }
    }
}
