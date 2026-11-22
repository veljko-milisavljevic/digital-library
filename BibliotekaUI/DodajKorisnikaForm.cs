using BibliotekaLibrary;
using System.Media;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace BibliotekaUI
{
    public partial class DodajKorisnikaForm : Form
    {
        public DodajKorisnikaForm()
        {
            InitializeComponent();
        }

        private void buttonProveri_Click(object sender, EventArgs e)
        {
            bool provera = true;
            if (checkBoxProfesor.Checked && (string.IsNullOrEmpty(textBoxIme.Text) || string.IsNullOrEmpty(textBoxPrezime.Text) || string.IsNullOrEmpty(textBoxID.Text) || (DateTime.Now.Year - dateTimePicker.Value.Year < 18)))
            {
                provera = false;
            }

            if(!checkBoxProfesor.Checked && (string.IsNullOrEmpty(textBoxImeRoditelja.Text) || string.IsNullOrEmpty(textBoxAdresa.Text) || string.IsNullOrEmpty(textBoxTelefon.Text) || (DateTime.Now.Year - dateTimePicker.Value.Year < 14)))
            {
                provera = false;
            }

            

            if (provera)
            {
                if (GlobalConfig.Veze.NadjiUcenike_ID(textBoxID.Text).Count > 0 || GlobalConfig.Veze.NadjiProfesore_ID(textBoxID.Text).Count > 0)
                {
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Već postoji korisnik sa unetim ID brojem!\nPokušajte ponovo.", "Greška!", buttons, icon);
                    textBoxID.Text = "";
                }
                else
                {
                    buttonDodaj.Visible = true;
                    textBoxIme.Enabled = false;
                    textBoxPrezime.Enabled = false;
                    textBoxImeRoditelja.Enabled = false;
                    textBoxAdresa.Enabled = false;
                    textBoxTelefon.Enabled = false;
                    dateTimePicker.Enabled = false;
                    textBoxID.Enabled = false;
                    numericRazred.Enabled = false;
                    numericOdeljenje.Enabled = false;
                    buttonProveri.Enabled = false;
                }
            }
            else
            {
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Pogrešno uneti podaci!\nPokušajte ponovo.", "Greška!", buttons, icon);
            }

        }
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (!checkBoxProfesor.Checked)
            {
                Ucenik model = new Ucenik(textBoxID.Text, textBoxIme.Text, textBoxPrezime.Text, textBoxImeRoditelja.Text, dateTimePicker.Value, textBoxAdresa.Text, textBoxTelefon.Text, (int)numericRazred.Value, (int)numericOdeljenje.Value);
                GlobalConfig.Veze.DodajUcenika(model);

                //Generisi QR kod ucenika
                string ID = model.ID;
                string path = $"C:\\DigitalnaBiblioteka\\Clanske karte\\{ID}.png";
                BarcodeWriter barcodeWriter = new BarcodeWriter();
                EncodingOptions encodingOptions = new EncodingOptions() { Width = 300, Height = 300, Margin = 0, PureBarcode = false };
                encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
                barcodeWriter.Renderer = new BitmapRenderer();
                barcodeWriter.Options = encodingOptions;
                barcodeWriter.Format = BarcodeFormat.QR_CODE;
                Bitmap bitmap = barcodeWriter.Write(ID);
                
                bitmap.Save(path, System.Drawing.Imaging.ImageFormat.Png);
                Email.ObavestiUcenikaOUclanjenju(model, path);
                //File.Delete(path);
            }
            else
            {
                Profesor model = new Profesor(textBoxID.Text, textBoxIme.Text, textBoxPrezime.Text, textBoxImeRoditelja.Text, dateTimePicker.Value, textBoxAdresa.Text, textBoxTelefon.Text);
                GlobalConfig.Veze.DodajProfesora(model);
            }
           

            SystemSounds.Beep.Play();

            textBoxID.Text = "";
            textBoxIme.Text = "";
            textBoxPrezime.Text = "";
            textBoxImeRoditelja.Text = "";
            textBoxAdresa.Text = "";
            textBoxTelefon.Text = "";
            numericRazred.Value = 1;
            numericOdeljenje.Value = 1;
            checkBoxProfesor.Checked = false;

            textBoxIme.Enabled = true;
            textBoxPrezime.Enabled = true;
            textBoxImeRoditelja.Enabled = true;
            textBoxAdresa.Enabled = true;
            textBoxTelefon.Enabled = true;
            dateTimePicker.Enabled = true;
            textBoxID.Enabled = true;
            numericRazred.Enabled = true;
            numericOdeljenje.Enabled = true;

            buttonDodaj.Visible = false;
            buttonProveri.Enabled = true;
        }
        private void checkBoxProfesor_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = !checkBoxProfesor.Checked;
            label8.Visible = !checkBoxProfesor.Checked;
            numericRazred.Visible = !checkBoxProfesor.Checked;
            numericOdeljenje.Visible = !checkBoxProfesor.Checked;
        }
        private void DodajKorisnikaForm_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = new DateTime(DateTime.Now.Year - 15, DateTime.Now.Month, DateTime.Now.Day);
        }
    }
}
