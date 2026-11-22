using BibliotekaLibrary;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Media;

namespace BibliotekaUI
{
    public partial class PretraziKnjiguForm : Form
    {
        private List<Knjiga> rezultatiPretrage = new List<Knjiga>();
        public PretraziKnjiguForm()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice kamera;

        private void PretraziKnjiguForm_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e) //Trenutno nefunkcionalno
        {

        }

        private void buttonPretrazi_Click(object sender, EventArgs e)
        {
            listViewPretraga.Items.Clear();
            if (!string.IsNullOrEmpty(textBoxID.Text))
            {
                rezultatiPretrage = GlobalConfig.Veze.NadjiKnjige_ID(textBoxID.Text);
            }
            else if(textBoxNaslov.Text.Length > 0)
            {
                rezultatiPretrage = GlobalConfig.Veze.NadjiKnjige_Naslov(textBoxNaslov.Text);
            }
            else //if(textBoxPisac.Text.Length > 0)
            {
                rezultatiPretrage = GlobalConfig.Veze.NadjiKnjige_Pisac(textBoxPisac.Text);
            }

            if (rezultatiPretrage.Count > 0)
            {
                foreach (Knjiga k in rezultatiPretrage)
                {
                    ListViewItem item = new ListViewItem(k.ID);
                    item.SubItems.Add(k.Naziv);
                    item.SubItems.Add(k.Pisac);
                    item.SubItems.Add($"{k.BrDostupnih}");
                    item.SubItems.Add($"{k.BrPrimeraka}");
                    listViewPretraga.Items.Add(item);
                }
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Ne postoji knjiga koja ispunjava unete kriterijume.");
            }

            
            //textBoxID.Text = "";
            textBoxNaslov.Text = "";
            textBoxPisac.Text = "";
            kamera.Start();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(pictureBox.Image != null)
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
    }
}
