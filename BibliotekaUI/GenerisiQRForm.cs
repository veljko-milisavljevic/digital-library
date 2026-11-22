using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace BibliotekaUI
{
    public partial class GenerisiQRForm : Form
    {
        public GenerisiQRForm()
        {
            InitializeComponent();
        }

        BarcodeWriter barcodeWriter = new BarcodeWriter();

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxID.Text.Length > 0)
            {
                //if (numericUpDown.Value > 1000) MessageBox.Show("Zbog tehničkih limitacija računara biće generisano samo 1000 uzastopnih kodova.");
                
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    label4.Visible = true;
                    button1.Visible = false;
                    printDocument.Print();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Niste uneli ID!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int brojac = 0;
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 150, Height = 150, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;

            Bitmap bm = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));
            
            if(checkBoxUzastopni.Checked)
            {
                int x = 25;
                int y = 25;
                int textIndent = 55;
                while (brojac <= (int)numericUpDown.Value)
                {
                    if (int.Parse(textBoxID.Text) + brojac > 99) textIndent = 50;
                    if (int.Parse(textBoxID.Text) + brojac > 999) textIndent = 45;
                    e.Graphics.DrawImage(bm, x, y);
                    e.Graphics.DrawString($"{int.Parse(textBoxID.Text)+brojac}", new Font("Arial", 11), Brushes.Black, x + textIndent, y + 125);

                    x += 165;
                    if (x > 700)
                    {
                        x = 25;
                        y += 165;
                    }

                    if(y > 850)
                    {
                        x = 25;
                        y = 25;
                        e.HasMorePages = true;
                    }

                    brojac++;
                    bm = barcodeWriter.Write($"{int.Parse(textBoxID.Text) + brojac}");
                    if (e.HasMorePages) return;
                }
            }
            else
            {
                e.Graphics.DrawImage(bm, 25, 25);
                e.Graphics.DrawString($"{int.Parse(textBoxID.Text) + brojac}", new Font("Arial", 11), Brushes.Black, 75, 150);
            }
            bm.Dispose();
        }

        private void checkBoxUzastopni_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown.Visible = !numericUpDown.Visible;
            label2.Visible = !label2.Visible;
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 150, Height = 150, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap;
            if (textBoxID.Text.Length > 0)
            {
                bitmap = barcodeWriter.Write(textBoxID.Text);
                pictureBox.Image = bitmap;
            }            
        }
    }
}
