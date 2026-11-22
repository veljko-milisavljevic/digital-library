using BibliotekaLibrary;
using System.Media;

namespace BibliotekaUI
{
    public partial class DodajKnjiguForm : Form
    {
        public DodajKnjiguForm()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonProveri_Click(object sender, EventArgs e)
        {
            bool provera = true;
            if (string.IsNullOrEmpty(textBoxNaziv.Text) || string.IsNullOrEmpty(textBoxID.Text))
            {
                provera = false;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Pogrešno uneti podaci!\nPokušajte ponovo.", "Greška!", buttons, icon);
            }


            if(GlobalConfig.Veze.NadjiKnjige_ID(textBoxID.Text).Count() > 0)
            {
                provera = false;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Već postoji knjiga sa unetim inventarnim brojem!\nPokušajte ponovo.", "Greška!", buttons, icon);
            }

            if (provera)
            {
                textBoxID.Enabled = false;
                textBoxNaziv.Enabled = false;
                textBoxPisac.Enabled = false;
                buttonDodaj.Visible = true;
            }

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            List<Knjiga> isteKnjige = GlobalConfig.Veze.NadjiIsteKnjige(textBoxNaziv.Text, textBoxPisac.Text);
            Knjiga model;
            if (isteKnjige.Count > 0)
            {
                model = new Knjiga(textBoxID.Text, textBoxNaziv.Text, textBoxPisac.Text, isteKnjige[0].BrPrimeraka + 1, isteKnjige[0].BrDostupnih + 1);
                GlobalConfig.Veze.DodajPrimerak(textBoxNaziv.Text, textBoxPisac.Text);
            }
            else
            {
                model = new Knjiga(textBoxID.Text, textBoxNaziv.Text, textBoxPisac.Text, 1);
            }
            

            GlobalConfig.Veze.DodajKnjigu(model);

            SystemSounds.Beep.Play();

            textBoxID.Text = "";
            textBoxNaziv.Text = "";
            textBoxPisac.Text = "";

            buttonDodaj.Visible = false;
        }
    }
}
