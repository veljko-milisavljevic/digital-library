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
    public partial class UkloniKnjiguForm : Form
    {
        public UkloniKnjiguForm()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUkloni_Click(object sender, EventArgs e)
        {
            if(textBoxID.Text.Length > 0)
            {
                if(GlobalConfig.Veze.NadjiKnjige_ID(textBoxID.Text).Count > 0)
                {
                    Knjiga k = GlobalConfig.Veze.NadjiKnjige_ID(textBoxID.Text).First();
                    if (MessageBox.Show($"Uklonite knjigu {k.Naziv}, {k.Pisac}?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        GlobalConfig.Veze.UkloniKnjigu(k);
                        SystemSounds.Beep.Play();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ne postoji knjiga sa unetim inventarnim brojem!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Niste uneli inventarni broj!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
