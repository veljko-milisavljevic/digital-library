using BibliotekaLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekaUI
{
    public partial class UkloniUcenikaForm : Form
    {
        public UkloniUcenikaForm()
        {
            InitializeComponent();
        }

        private void buttonUkloni_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Length > 0)
            {
                if (GlobalConfig.Veze.NadjiUcenike_ID(textBoxID.Text).Count > 0)
                {
                    Ucenik u = GlobalConfig.Veze.NadjiUcenike_ID(textBoxID.Text).First();

                    if(GlobalConfig.Veze.NadjiZaduzenja_Korisnik(u.ID).Count == 0)
                    {
                        if (MessageBox.Show($"Uklonite učenika {u.Ime} {u.Prezime}, {u.Razred}-{u.Odeljenje}?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            GlobalConfig.Veze.UkloniUcenika(u);
                            SystemSounds.Beep.Play();
                            this.Close();
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Nije moguće ukloniti učenika zato što nije izmirio sva zaduženja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ne postoji učenik sa unetim ID brojem!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Niste uneli ID broj!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
