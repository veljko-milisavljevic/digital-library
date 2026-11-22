using System.Media;
using BibliotekaLibrary;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace BibliotekaUI
{
    public partial class ZaduziKnjiguForm : Form
    {
        DateTime datumVracanja = DateTime.Now.AddDays(15);
        

        Ucenik ucenik;
        Profesor profesor;
        Knjiga knjiga;
        Zaduzenje zaduzenje;
        int faza;
        public ZaduziKnjiguForm()
        {
            InitializeComponent();
            buttonZaduzi.Visible = false;
            faza = 1;

            datumVracanja = new DateTime(datumVracanja.Year, datumVracanja.Month, datumVracanja.Day, 23, 59, 59);
            if (datumVracanja.DayOfWeek == DayOfWeek.Saturday) datumVracanja = datumVracanja.AddDays(2);
            if (datumVracanja.DayOfWeek == DayOfWeek.Sunday) datumVracanja = datumVracanja.AddDays(1);
            monthCalendar1.SetDate(datumVracanja);
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice kamera;

        private void ZaduziKnjiguForm_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            kamera = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            kamera.NewFrame += Kamera_NewFrame;
            kamera.Start();
            timer.Start();
        }

        private void Kamera_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            kamera.SignalToStop();
            timer.Stop();
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            datumVracanja = monthCalendar1.SelectionStart;
            datumVracanja = new DateTime(datumVracanja.Year, datumVracanja.Month, datumVracanja.Day, 23, 59, 59);
            labelDatum.Text = $"{datumVracanja.Day}.{datumVracanja.Month}.{datumVracanja.Year}.";
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            if(faza == 1)
            {
                if (textBoxIDKorisnika.Text.Length > 0)
                {
                    if (!checkBoxProfesor.Checked) //Učenik
                    {
                        List<Ucenik> ucenici = GlobalConfig.Veze.NadjiUcenike_ID(textBoxIDKorisnika.Text);
                        if (ucenici.Count > 0)
                        {
                            ucenik = ucenici.First();
                            if(GlobalConfig.Veze.NadjiZaduzenja_Korisnik(ucenik.ID).Count < 3)
                            {
                                faza = 2;
                                textBoxIDKorisnika.Enabled = false;
                                labelIme.Text = $"{ucenik.Ime} {ucenik.Prezime}";
                                SystemSounds.Beep.Play();
                            }
                            else
                            {
                                MessageBoxIcon icon = MessageBoxIcon.Error;
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                MessageBox.Show("Učenik je već zadužio 3 knjige!", "Greška!", buttons, icon);
                            }
                            
                        }
                        else
                        {
                            MessageBoxIcon icon = MessageBoxIcon.Error;
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show("Ne postoji učenik sa unetim ID brojem!\nPokušajte ponovo.", "Greška!", buttons, icon);
                        }
                    }
                    else //Profesor
                    {
                        List<Profesor> profesori = GlobalConfig.Veze.NadjiProfesore_ID(textBoxIDKorisnika.Text);
                        if (profesori.Count > 0)
                        {
                            profesor = profesori.First();
                            faza = 2;
                            textBoxIDKorisnika.Enabled = false;
                            labelIme.Text = $"{profesor.Ime} {profesor.Prezime}";
                            SystemSounds.Beep.Play();
                        }
                        else
                        {
                            MessageBoxIcon icon = MessageBoxIcon.Error;
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show("Ne postoji profesor sa unetim ID brojem!\nPokušajte ponovo.", "Greška!", buttons, icon);
                        }
                    }
                    kamera.Start();
                    timer.Start();
                }
                else //Greška pri unosu
                {
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Unesite ID broj korisnika!", "Greška!", buttons, icon);
                }
                
            }
            else if(faza == 2)
            {
                if (textBoxIDKnjige.Text.Length > 0)
                {
                    List<Knjiga> knjige = GlobalConfig.Veze.NadjiKnjige_ID(textBoxIDKnjige.Text);
                    if(knjige.Count > 0)
                    {
                        knjiga = knjige.First();
                        faza = 3;
                        textBoxIDKnjige.Enabled = false;
                        buttonZaduzi.Visible = true;
                        labelNaslov.Text = knjiga.Naziv;
                        SystemSounds.Beep.Play();
                    }
                    else
                    {
                        MessageBoxIcon icon = MessageBoxIcon.Error;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Ne postoji knjiga sa unetim inventarnim brojem!\nPokušajte ponovo.", "Greška!", buttons, icon);
                    }
                }
                else //Greška pri unosu
                {
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Unesite inventarni broj knjige!", "Greška!", buttons, icon);
                }
            }
            
        }

        private void buttonZaduzi_Click(object sender, EventArgs e)
        {
            if(!checkBoxProfesor.Checked)
            {
                zaduzenje = new Zaduzenje(ucenik.ID, knjiga.ID, DateTime.Now, datumVracanja);
                GlobalConfig.Veze.ZaduziPrimerak(knjiga.Naziv, knjiga.Pisac);
                GlobalConfig.Veze.DodajZaduzenje(zaduzenje);
                Email.ObavestiKorisnikaOZaduzenju(ucenik, knjiga, zaduzenje);
            }
            else
            {
                Zaduzenje zaduzenje = new Zaduzenje(profesor.ID, knjiga.ID, DateTime.Now, datumVracanja);
                GlobalConfig.Veze.ZaduziPrimerak(knjiga.Naziv, knjiga.Pisac);
                GlobalConfig.Veze.DodajZaduzenje(zaduzenje);
                Email.ObavestiKorisnikaOZaduzenju(profesor, knjiga, zaduzenje);
            }
            SystemSounds.Beep.Play();
            timer.Stop();
            kamera.SignalToStop();
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                BarcodeReader citac = new BarcodeReader();
                Bitmap bitmap = new Bitmap(pictureBox.Image);
                Result rezultat = citac.Decode(bitmap);
                if (rezultat != null)
                {
                    if (faza == 1) textBoxIDKorisnika.Text = rezultat.ToString();
                    else if (faza == 2) textBoxIDKnjige.Text = rezultat.ToString();
                    timer.Stop();
                    kamera.SignalToStop();
                }
            }
        }
    }
}
