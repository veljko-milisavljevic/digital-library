using BibliotekaLibrary;
using System.Media;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace BibliotekaUI
{
    public partial class RazduziKnjiguForm : Form
    {
        Ucenik ucenik;
        Profesor profesor;
        Knjiga knjiga;
        Zaduzenje zaduzenje;

        int faza;
        public RazduziKnjiguForm()
        {
            InitializeComponent();

            faza = 1;

            buttonRazduzi.Visible = false;
            labelKasnjenje.Visible = false;
            labelKazna.Visible = false;
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice kamera;

        private void RazduziKnjiguForm_Load(object sender, EventArgs e)
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
            timer.Stop();
            kamera.SignalToStop();
            this.Close();
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            if (faza == 1)
            {
                if (textBoxIDKorisnika.Text.Length > 0)
                {
                    if (!checkBoxProfesor.Checked) //Učenik
                    {
                        List<Ucenik> ucenici = GlobalConfig.Veze.NadjiUcenike_ID(textBoxIDKorisnika.Text);
                        if (ucenici.Count > 0)
                        {
                            ucenik = ucenici.First();
                            if (GlobalConfig.Veze.NadjiZaduzenja_Korisnik(ucenik.ID).Count > 0)
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
                                MessageBox.Show("Učenik nema zaduženih knjiga!", "Greška!", buttons, icon);
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
                            if (GlobalConfig.Veze.NadjiZaduzenja_Korisnik(profesor.ID).Count > 0)
                            {
                                faza = 2;
                                textBoxIDKorisnika.Enabled = false;
                                labelIme.Text = $"{profesor.Ime} {profesor.Prezime}";
                                SystemSounds.Beep.Play();
                            }
                            else
                            {
                                MessageBoxIcon icon = MessageBoxIcon.Error;
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                MessageBox.Show("Profesor nema zaduženih knjiga!", "Greška!", buttons, icon);
                            }
                            
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
            else if (faza == 2)
            {
                if (textBoxIDKnjige.Text.Length > 0)
                {
                    List<Knjiga> knjige = GlobalConfig.Veze.NadjiKnjige_ID(textBoxIDKnjige.Text);

                    string IDKorisnika;
                    if (!checkBoxProfesor.Checked) IDKorisnika = ucenik.ID;
                    else IDKorisnika = profesor.ID;

                    bool postojiZaduzenaKnjiga = false;

                    foreach(Zaduzenje z in GlobalConfig.Veze.NadjiZaduzenja_Korisnik(IDKorisnika))
                    {
                        if(knjige.Count > 0)
                        {
                            if (z.IDKnjige == knjige.First().ID) postojiZaduzenaKnjiga = true;
                        }
                        else
                        {
                            MessageBox.Show("Uneta knjiga ne postoji!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (postojiZaduzenaKnjiga)
                    {
                        knjiga = knjige.First();
                        faza = 3;
                        textBoxIDKnjige.Enabled = false;
                        buttonRazduzi.Visible = true;
                        labelNaslov.Text = knjiga.Naziv;

                        zaduzenje = GlobalConfig.Veze.NadjiZaduzenje(IDKorisnika, knjiga.ID);
                        int kasnjenje = (int)DateTime.Now.Subtract(zaduzenje.DatumVracanja).TotalHours;
                        if (kasnjenje > 0)
                        {
                            kasnjenje = kasnjenje / 24 + 1;
                            labelKasnjenje.Visible = true;
                            labelKasnjenje.Text = $"Kašnjenje: {kasnjenje} dana";

                            if(kasnjenje > 30)
                            {
                                labelKazna.Visible = true;
                                labelKazna.Text = $"Kazna: {(kasnjenje - 30) * 10} dinara";
                            }
                        }

                        SystemSounds.Beep.Play();
                    }
                    else
                    {
                        MessageBoxIcon icon = MessageBoxIcon.Error;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Korisnik nije zadužio knjigu sa unetim inventarnim brojem!\nPokušajte ponovo.", "Greška!", buttons, icon);
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

        private void buttonRazduzi_Click(object sender, EventArgs e)
        {
            GlobalConfig.Veze.RazduziPrimerak(knjiga.Naziv, knjiga.Pisac);
            GlobalConfig.Veze.UkloniZaduzenje(zaduzenje);

            SystemSounds.Beep.Play();
            this.Close();
            timer.Stop();
            kamera.SignalToStop();
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
