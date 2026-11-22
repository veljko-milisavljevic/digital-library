namespace BibliotekaUI
{
    partial class PretraziKorisnikaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PretraziKorisnikaForm));
            this.buttonHome = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonPretrazi = new System.Windows.Forms.Button();
            this.listViewZaduzenja = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Knjiga = new System.Windows.Forms.ColumnHeader();
            this.DatumUzimanja = new System.Windows.Forms.ColumnHeader();
            this.DatumVracanja = new System.Windows.Forms.ColumnHeader();
            this.Kasnjenje = new System.Windows.Forms.ColumnHeader();
            this.label8 = new System.Windows.Forms.Label();
            this.labelRadredOdeljenje = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonObavestiOKasnjenju = new System.Windows.Forms.Button();
            this.labelPodsetnik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(40, 40);
            this.buttonHome.TabIndex = 2;
            this.buttonHome.TabStop = false;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(730, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 200);
            this.pictureBox.TabIndex = 23;
            this.pictureBox.TabStop = false;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(594, 169);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.PlaceholderText = "12345678";
            this.textBoxID.Size = new System.Drawing.Size(130, 43);
            this.textBoxID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(594, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 37);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Adresa:";
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNaziv.Location = new System.Drawing.Point(12, 43);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(67, 37);
            this.labelNaziv.TabIndex = 17;
            this.labelNaziv.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 37);
            this.label3.TabIndex = 24;
            this.label3.Text = "Zaduženja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 37);
            this.label4.TabIndex = 25;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 37);
            this.label5.TabIndex = 26;
            this.label5.Text = "E-mail:";
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIme.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelIme.Location = new System.Drawing.Point(71, 48);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(86, 32);
            this.labelIme.TabIndex = 27;
            this.labelIme.Text = "<ime>";
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAdresa.Location = new System.Drawing.Point(122, 96);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(115, 32);
            this.labelAdresa.TabIndex = 28;
            this.labelAdresa.Text = "<adresa>";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTelefon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTelefon.Location = new System.Drawing.Point(122, 144);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(122, 32);
            this.labelTelefon.TabIndex = 29;
            this.labelTelefon.Text = "<telefon>";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelEmail.Location = new System.Drawing.Point(117, 192);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(104, 32);
            this.labelEmail.TabIndex = 30;
            this.labelEmail.Text = "<email>";
            // 
            // buttonPretrazi
            // 
            this.buttonPretrazi.Location = new System.Drawing.Point(594, 246);
            this.buttonPretrazi.Name = "buttonPretrazi";
            this.buttonPretrazi.Size = new System.Drawing.Size(336, 40);
            this.buttonPretrazi.TabIndex = 3;
            this.buttonPretrazi.Text = "Pretraži";
            this.buttonPretrazi.UseVisualStyleBackColor = true;
            this.buttonPretrazi.Click += new System.EventHandler(this.buttonPretrazi_Click);
            // 
            // listViewZaduzenja
            // 
            this.listViewZaduzenja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Knjiga,
            this.DatumUzimanja,
            this.DatumVracanja,
            this.Kasnjenje});
            this.listViewZaduzenja.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewZaduzenja.Location = new System.Drawing.Point(12, 292);
            this.listViewZaduzenja.Name = "listViewZaduzenja";
            this.listViewZaduzenja.Size = new System.Drawing.Size(918, 189);
            this.listViewZaduzenja.TabIndex = 32;
            this.listViewZaduzenja.UseCompatibleStateImageBehavior = false;
            this.listViewZaduzenja.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 110;
            // 
            // Knjiga
            // 
            this.Knjiga.Text = "Knjiga";
            this.Knjiga.Width = 320;
            // 
            // DatumUzimanja
            // 
            this.DatumUzimanja.Text = "Datum uzimanja";
            this.DatumUzimanja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DatumUzimanja.Width = 180;
            // 
            // DatumVracanja
            // 
            this.DatumVracanja.Text = "Datum Vraćanja";
            this.DatumVracanja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DatumVracanja.Width = 180;
            // 
            // Kasnjenje
            // 
            this.Kasnjenje.Text = "Kašnjenje";
            this.Kasnjenje.Width = 120;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(427, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 32);
            this.label8.TabIndex = 34;
            this.label8.Text = "Odeljenje:";
            // 
            // labelRadredOdeljenje
            // 
            this.labelRadredOdeljenje.AutoSize = true;
            this.labelRadredOdeljenje.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRadredOdeljenje.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelRadredOdeljenje.Location = new System.Drawing.Point(543, 48);
            this.labelRadredOdeljenje.Name = "labelRadredOdeljenje";
            this.labelRadredOdeljenje.Size = new System.Drawing.Size(115, 32);
            this.labelRadredOdeljenje.TabIndex = 35;
            this.labelRadredOdeljenje.Text = "<razIOd>";
            // 
            // timer
            // 
            this.timer.Interval = 400;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonObavestiOKasnjenju
            // 
            this.buttonObavestiOKasnjenju.Location = new System.Drawing.Point(548, 246);
            this.buttonObavestiOKasnjenju.Name = "buttonObavestiOKasnjenju";
            this.buttonObavestiOKasnjenju.Size = new System.Drawing.Size(40, 40);
            this.buttonObavestiOKasnjenju.TabIndex = 2;
            this.buttonObavestiOKasnjenju.UseVisualStyleBackColor = true;
            this.buttonObavestiOKasnjenju.Click += new System.EventHandler(this.buttonObavestiOKasnjenju_Click);
            // 
            // labelPodsetnik
            // 
            this.labelPodsetnik.AutoSize = true;
            this.labelPodsetnik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPodsetnik.Location = new System.Drawing.Point(350, 251);
            this.labelPodsetnik.Name = "labelPodsetnik";
            this.labelPodsetnik.Size = new System.Drawing.Size(192, 32);
            this.labelPodsetnik.TabIndex = 36;
            this.labelPodsetnik.Text = "Pošalji podsetnik";
            // 
            // PretraziKorisnikaForm
            // 
            this.AcceptButton = this.buttonPretrazi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonHome;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.ControlBox = false;
            this.Controls.Add(this.labelPodsetnik);
            this.Controls.Add(this.buttonObavestiOKasnjenju);
            this.Controls.Add(this.labelRadredOdeljenje);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listViewZaduzenja);
            this.Controls.Add(this.buttonPretrazi);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelAdresa);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.buttonHome);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "PretraziKorisnikaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraži Korisnika";
            this.Load += new System.EventHandler(this.PretraziKorisnikaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonHome;
        private PictureBox pictureBox;
        private TextBox textBoxID;
        private Label label2;
        private Label label1;
        private Label labelNaziv;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelIme;
        private Label labelAdresa;
        private Label labelTelefon;
        private Label labelEmail;
        private Button buttonPretrazi;
        private ListView listViewZaduzenja;
        private ColumnHeader ID;
        private ColumnHeader Knjiga;
        private ColumnHeader DatumUzimanja;
        private ColumnHeader DatumVracanja;
        private Label label8;
        private Label labelRadredOdeljenje;
        private ColumnHeader Kasnjenje;
        private System.Windows.Forms.Timer timer;
        private Button buttonObavestiOKasnjenju;
        private Label labelPodsetnik;
    }
}