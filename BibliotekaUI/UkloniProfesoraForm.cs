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
    public partial class UkloniProfesoraForm : Form
    {
        public UkloniProfesoraForm()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUkloni_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Length > 0)
            {
                if (GlobalConfig.Veze.NadjiProfesore_ID(textBoxID.Text).Count > 0)
                {
                    Profesor p = GlobalConfig.Veze.NadjiProfesore_ID(textBoxID.Text).First();

                    if (GlobalConfig.Veze.NadjiZaduzenja_Korisnik(p.ID).Count == 0)
                    {
                        if (MessageBox.Show($"Uklonite profesora {p.Ime} {p.Prezime}?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            GlobalConfig.Veze.UkloniProfesora(p);
                            SystemSounds.Beep.Play();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nije moguće ukloniti profesora zato što nije izmirio sva zaduženja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ne postoji profesor sa unetim ID brojem!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Niste uneli ID broj!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
