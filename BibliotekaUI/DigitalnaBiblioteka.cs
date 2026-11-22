using BibliotekaLibrary;
using System.Media;
using System.Text;

namespace BibliotekaUI
{
    public partial class DigitalnaBiblioteka : Form
    {
        public DigitalnaBiblioteka()
        {
            InitializeComponent();
        }

        private void DigitalnaBiblioteka_Load(object sender, EventArgs e)
        {
            //Slanje backup-a
            GlobalConfig.Veze.NapraviBackup();
        }

        private void buttonZaduziRazduzi_Click(object sender, EventArgs e)
        {
            buttonZaduzi.Visible = !buttonZaduzi.Visible;
            buttonRazduzi.Visible = !buttonRazduzi.Visible;

            buttonPretraziKnjigu.Visible = false;
            buttonPretraziKorisnika.Visible = false;
            buttonDodajKorisnika.Visible = false;
            buttonDodajKnjigu.Visible = false;
        }

        private void buttonPretrazi_Click(object sender, EventArgs e)
        {
            buttonPretraziKnjigu.Visible = !buttonPretraziKnjigu.Visible;
            buttonPretraziKorisnika.Visible = !buttonPretraziKorisnika.Visible;

            buttonDodajKorisnika.Visible = false;
            buttonDodajKnjigu.Visible = false;
            buttonZaduzi.Visible = false;
            buttonRazduzi.Visible = false;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            buttonDodajKorisnika.Visible = !buttonDodajKorisnika.Visible;
            buttonDodajKnjigu.Visible = !buttonDodajKnjigu.Visible;

            buttonZaduzi.Visible = false;
            buttonRazduzi.Visible = false;
            buttonPretraziKnjigu.Visible = false;
            buttonPretraziKorisnika.Visible = false;
        }

        private void buttonDodajKorisnika_Click(object sender, EventArgs e)
        {
            new DodajKorisnikaForm().ShowDialog();
        }

        private void buttonDodajKnjigu_Click(object sender, EventArgs e)
        {
            new DodajKnjiguForm().ShowDialog();
        }

        private void buttonPretraziKorisnika_Click(object sender, EventArgs e)
        {
            new PretraziKorisnikaForm().ShowDialog();
        }

        private void buttonPretraziKnjigu_Click(object sender, EventArgs e)
        {
            new PretraziKnjiguForm().ShowDialog();
        }

        private void buttonZaduzi_Click(object sender, EventArgs e)
        {
            new ZaduziKnjiguForm().ShowDialog();
        }

        private void buttonRazduzi_Click(object sender, EventArgs e)
        {
            new RazduziKnjiguForm().ShowDialog();
        }

        //Izveštaji
        private void sviZaduženiUčeniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialogZadUcenici.ShowDialog() == DialogResult.OK)
            {
                printZaduzeniUcenici.Print();
            }
        }
        private void printZaduzeniUcenici_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<Ucenik> ucenici = GlobalConfig.Veze.NadjiSveUcenikeSaZaduzenjem();
            List<Ucenik> uceniciSortirano = ucenici.OrderBy(x => x.Razred).ThenBy(x => x.Odeljenje).ToList();

            StringBuilder text = new StringBuilder();
            foreach(Ucenik u in uceniciSortirano)
            {
                text.AppendLine($"{u.PunoIme} {u.Razred}-{u.Odeljenje}\n");
                List<Zaduzenje> zaduzenja = GlobalConfig.Veze.NadjiZaduzenja_Korisnik(u.ID);
                //text.AppendLine("___________________________________________________________");
                foreach(Zaduzenje z in zaduzenja)
                {
                    Knjiga k = GlobalConfig.Veze.NadjiKnjige_ID(z.IDKnjige).First();
                    text.AppendLine($"{k.Naziv}\nRok za vraćanje: {z.DatumVracanja.ToShortDateString()}");
                }
                text.AppendLine("______________________________________________________________________________\n");
                e.Graphics.DrawString(text.ToString(), new Font("Arial", 12), Brushes.Black, new PointF(50, 50));
                
            }
        }
        private void sviZaduženiProfesoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialogZadProf.ShowDialog() == DialogResult.OK)
            {
                printZaduzeniProfesori.Print();
            }
        }
        private void printZaduzeniProfesori_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<Profesor> profesori = GlobalConfig.Veze.NadjiSveProfesoreSaZaduzenjem();

            StringBuilder text = new StringBuilder();
            foreach (Profesor p in profesori)
            {
                text.AppendLine(p.PunoIme);
                List<Zaduzenje> zaduzenja = GlobalConfig.Veze.NadjiZaduzenja_Korisnik(p.ID);
                //text.AppendLine("___________________________________________________________");
                foreach (Zaduzenje z in zaduzenja)
                {
                    Knjiga k = GlobalConfig.Veze.NadjiKnjige_ID(z.IDKnjige).First();
                    text.AppendLine($"{k.Naziv}\nRok za vraćanje: {z.DatumVracanja.ToShortDateString()}");
                }
                text.AppendLine("______________________________________________________________________________\n");
                e.Graphics.DrawString(text.ToString(), new Font("Arial", 12), Brushes.Black, new PointF(50, 50));

            }
        }
        private void sviUčeniciKojiKasneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialogUceniciKojiKasne.ShowDialog() == DialogResult.OK)
            {
                printUceniciKojiKasne.Print();
            }
        }
        private void printUceniciKojiKasne_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<Ucenik> ucenici = GlobalConfig.Veze.NadjiSveUcenikeKojiKasne();
            List<Ucenik> uceniciSortirano = ucenici.OrderBy(x => x.Razred).ThenBy(x => x.Odeljenje).ToList();

            StringBuilder text = new StringBuilder();
            foreach (Ucenik u in uceniciSortirano)
            {
                text.AppendLine($"{u.PunoIme} {u.Razred}-{u.Odeljenje}\n");
                List<Zaduzenje> zaduzenja = GlobalConfig.Veze.NadjiZaduzenja_Korisnik(u.ID);
                //text.AppendLine("___________________________________________________________");
                foreach (Zaduzenje z in zaduzenja)
                {
                    Knjiga k = GlobalConfig.Veze.NadjiKnjige_ID(z.IDKnjige).First();
                    text.AppendLine($"{k.Naziv}\nRok za vraćanje: {z.DatumVracanja.ToShortDateString()}");
                }
                text.AppendLine("______________________________________________________________________________\n");
                e.Graphics.DrawString(text.ToString(), new Font("Arial", 12), Brushes.Black, new PointF(50, 50));

            }
        }
        private void sveKnjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialogSveKnjige.ShowDialog() == DialogResult.OK)
            {
                printSveKnjige.Print();
            }
        }
        private void printSveKnjige_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<Knjiga> knjige = GlobalConfig.Veze.NadjiKnjige_Naslov("");
            List<Knjiga> knjigeSortirano = knjige.OrderBy(x => x.Naziv).ToList();

            StringBuilder text = new StringBuilder();
            foreach (Knjiga k in knjigeSortirano)
            {
                text.AppendLine($"{k.ID} {k.Naziv}, {k.Pisac}\tBroj primeraka: {k.BrDostupnih}/{k.BrPrimeraka}\n");

                e.Graphics.DrawString(text.ToString(), new Font("Arial", 12), Brushes.Black, new PointF(50, 50));
            }
        }


        //Email obaveštenja
        private void višeOd1DanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Ucenik> ucenici = GlobalConfig.Veze.NadjiSveUcenikeKojiKasne(1);

            foreach(Ucenik u in ucenici)
            {
                Zaduzenje z = GlobalConfig.Veze.NadjiZaduzenja_Korisnik(u.ID).OrderBy(x => x.DatumVracanja).ToList().First();
                Email.ObavestiUcenikaOKasnjenju(u, GlobalConfig.Veze.NadjiKnjige_ID(z.IDKnjige).First(), z);
            }

            SystemSounds.Beep.Play();
            MessageBox.Show("Obaveštenje poslato.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void višeOd14DanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Ucenik> ucenici = GlobalConfig.Veze.NadjiSveUcenikeKojiKasne(14);

            foreach (Ucenik u in ucenici)
            {
                Zaduzenje z = GlobalConfig.Veze.NadjiZaduzenja_Korisnik(u.ID).OrderBy(x => x.DatumVracanja).ToList().First();
                Email.ObavestiUcenikaOKasnjenju(u, GlobalConfig.Veze.NadjiKnjige_ID(z.IDKnjige).First(), z);
            }

            SystemSounds.Beep.Play();
            MessageBox.Show("Obaveštenje poslato.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void višeOd30DanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Ucenik> ucenici = GlobalConfig.Veze.NadjiSveUcenikeKojiKasne(30);

            foreach (Ucenik u in ucenici)
            {
                Zaduzenje z = GlobalConfig.Veze.NadjiZaduzenja_Korisnik(u.ID).OrderBy(x => x.DatumVracanja).ToList().First();
                Email.ObavestiUcenikaOKasnjenju(u, GlobalConfig.Veze.NadjiKnjige_ID(z.IDKnjige).First(), z);
            }

            SystemSounds.Beep.Play();
            MessageBox.Show("Obaveštenje poslato.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void višeOd1DanaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<Profesor> profesori = GlobalConfig.Veze.NadjiSveProfesoreKojiKasne(1);

            foreach (Profesor p in profesori)
            {
                Zaduzenje z = GlobalConfig.Veze.NadjiZaduzenja_Korisnik(p.ID).OrderBy(x => x.DatumVracanja).ToList().First();
                Email.ObavestiProfesoraOKasnjenju(p, GlobalConfig.Veze.NadjiKnjige_ID(z.IDKnjige).First(), z);
            }

            SystemSounds.Beep.Play();
            MessageBox.Show("Obaveštenje poslato.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void višeOd14DanaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<Profesor> profesori = GlobalConfig.Veze.NadjiSveProfesoreKojiKasne(14);

            foreach (Profesor p in profesori)
            {
                Zaduzenje z = GlobalConfig.Veze.NadjiZaduzenja_Korisnik(p.ID).OrderBy(x => x.DatumVracanja).ToList().First();
                Email.ObavestiProfesoraOKasnjenju(p, GlobalConfig.Veze.NadjiKnjige_ID(z.IDKnjige).First(), z);
            }

            SystemSounds.Beep.Play();
            MessageBox.Show("Obaveštenje poslato.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void višeOd30DanaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<Profesor> profesori = GlobalConfig.Veze.NadjiSveProfesoreKojiKasne(30);

            foreach (Profesor p in profesori)
            {
                Zaduzenje z = GlobalConfig.Veze.NadjiZaduzenja_Korisnik(p.ID).OrderBy(x => x.DatumVracanja).ToList().First();
                Email.ObavestiProfesoraOKasnjenju(p, GlobalConfig.Veze.NadjiKnjige_ID(z.IDKnjige).First(), z);
            }

            SystemSounds.Beep.Play();
            MessageBox.Show("Obaveštenje poslato.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void knjiguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UkloniKnjiguForm().ShowDialog();
        }

        private void učenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UkloniUcenikaForm().ShowDialog();
        }

        private void profesoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UkloniProfesoraForm().ShowDialog();
        }

        private void označiKrajŠkolskeGodineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(GlobalConfig.Veze.NadjiSveUcenikeSaZaduzenjem().Count() == 0)
            {
                if (MessageBox.Show($"Označavanjem kraja godine svi učenici će biti prebačeni u sledeći razred. \nSvi učenici koji su završili četvrti razred biće uklonjeni iz sistema. \n\nDa li ste sigurni da to želite da uradite?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SystemSounds.Beep.Play();
                    GlobalConfig.Veze.OznaciKrajGodine();
                }
            }
            else
            {
                MessageBox.Show("Nije moguće zaključiti školsku godinu zato što postoje učenici koji nisu izmirili svoje obaveze!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void generišiQRKodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GenerisiQRForm().ShowDialog();
        }
    }
}