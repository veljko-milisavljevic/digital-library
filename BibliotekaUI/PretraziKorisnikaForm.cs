using BibliotekaLibrary;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace BibliotekaUI
{
    public partial class PretraziKorisnikaForm : Form
    {
        List<Zaduzenje> zaduzenjaKorisnika;
        List<IKorisnik> rezultatiPretrage = new List<IKorisnik>();

        public PretraziKorisnikaForm()
        {
            InitializeComponent();

            buttonObavestiOKasnjenju.Visible = false;
            labelPodsetnik.Visible = false;
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice kamera;
        private void PretraziKorisnikaForm_Load(object sender, EventArgs e)
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

        private void buttonPretrazi_Click(object sender, EventArgs e)
        {
            listViewZaduzenja.Items.Clear();

            if (textBoxID.Text.Length > 0)
            {
                if (GlobalConfig.Veze.NadjiUcenike_ID(textBoxID.Text).Count == 0 && GlobalConfig.Veze.NadjiProfesore_ID(textBoxID.Text).Count == 0)
                {
                    MessageBox.Show("Ne postoji korisnik sa unetim ID brojem!\nPokušajte ponovo.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxID.Text = "";
                }
                else
                {
                    if (GlobalConfig.Veze.NadjiUcenike_ID(textBoxID.Text).Count != 0) rezultatiPretrage.Add(GlobalConfig.Veze.NadjiUcenike_ID(textBoxID.Text).First());
                    else rezultatiPretrage.Add(GlobalConfig.Veze.NadjiProfesore_ID(textBoxID.Text).First());

                    if (rezultatiPretrage[0].PunoIme.Length > 29)
                    {
                        labelIme.Text = $"{rezultatiPretrage[0].PunoIme.Substring(0, 27)}...";
                    }
                    else
                    {
                        labelIme.Text = rezultatiPretrage[0].PunoIme;
                    }

                    if (rezultatiPretrage[0].Adresa.Length > 40)
                    {
                        labelAdresa.Text = $"{rezultatiPretrage[0].Adresa.Substring(0, 38)}...";
                    }
                    else
                    {
                        labelAdresa.Text = rezultatiPretrage[0].Adresa;
                    }

                    labelTelefon.Text = rezultatiPretrage[0].BrTelefona;
                    labelEmail.Text = rezultatiPretrage[0].Email;

                    if (rezultatiPretrage.First() is Profesor)
                    {
                        labelRadredOdeljenje.Text = "/";
                    }
                    else
                    {
                        Ucenik u = (Ucenik)rezultatiPretrage[0];
                        labelRadredOdeljenje.Text = $"{u.Razred}/{u.Odeljenje}";
                    }

                    zaduzenjaKorisnika = GlobalConfig.Veze.NadjiZaduzenja_Korisnik(rezultatiPretrage.First().ID);
                    foreach (Zaduzenje z in zaduzenjaKorisnika)
                    {
                        Knjiga k = GlobalConfig.Veze.NadjiKnjige_ID(z.IDKnjige).First();
                        ListViewItem item = new ListViewItem(k.ID);
                        item.SubItems.Add(k.Naziv);
                        item.SubItems.Add($"{z.DatumUzimanja.Day}.{z.DatumUzimanja.Month}.{z.DatumUzimanja.Year}.");
                        item.SubItems.Add($"{z.DatumVracanja.Day}.{z.DatumVracanja.Month}.{z.DatumVracanja.Year}.");

                        int kasnjenje = (int)DateTime.Now.Subtract(z.DatumVracanja).TotalHours;
                        if (kasnjenje > 0) 
                        {
                            item.SubItems.Add($"{kasnjenje / 24 + 1} dana");
                            buttonObavestiOKasnjenju.Visible = true;
                            labelPodsetnik.Visible = true;
                        }

                        listViewZaduzenja.Items.Add(item);
                    }
                }

                
            }
            else
            {
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Niste uneli ID korisnika!\nPokušajte ponovo.", "Greška!", buttons, icon);
            }

            kamera.Start();
            timer.Start();
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
                    textBoxID.Text = rezultat.ToString();
                    timer.Stop();
                    kamera.SignalToStop();
                }
            }
        }

        private void buttonObavestiOKasnjenju_Click(object sender, EventArgs e)
        {
            foreach(Zaduzenje z in zaduzenjaKorisnika)
            {
                int kasnjenje = (int)DateTime.Now.Subtract(z.DatumVracanja).TotalHours;
                if (kasnjenje > 0) 
                {
                    Email.ObavestiUcenikaOKasnjenju(rezultatiPretrage.First(), GlobalConfig.Veze.NadjiKnjige_ID(z.IDKnjige).First(), z);
                }
            }
            buttonObavestiOKasnjenju.Visible = false;
            labelPodsetnik.Visible = false;
        }
    }
}
