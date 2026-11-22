namespace BibliotekaUI
{
    partial class ZaduziKnjiguForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZaduziKnjiguForm));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIDKnjige = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonZaduzi = new System.Windows.Forms.Button();
            this.buttonPotvrdi = new System.Windows.Forms.Button();
            this.labelIme = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxIDKorisnika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.buttonHome = new System.Windows.Forms.Button();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.checkBoxProfesor = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.monthCalendar1.Location = new System.Drawing.Point(18, 263);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 68;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(18, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 37);
            this.label5.TabIndex = 67;
            this.label5.Text = "Datum Vraćanja:";
            // 
            // textBoxIDKnjige
            // 
            this.textBoxIDKnjige.Location = new System.Drawing.Point(600, 106);
            this.textBoxIDKnjige.Name = "textBoxIDKnjige";
            this.textBoxIDKnjige.PlaceholderText = "12345678";
            this.textBoxIDKnjige.Size = new System.Drawing.Size(130, 43);
            this.textBoxIDKnjige.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(466, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 37);
            this.label4.TabIndex = 65;
            this.label4.Text = "ID knjige:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDatum.Location = new System.Drawing.Point(235, 217);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(130, 37);
            this.labelDatum.TabIndex = 64;
            this.labelDatum.Text = "<datum>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(18, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 37);
            this.label3.TabIndex = 63;
            this.label3.Text = "Naslov Knjige:";
            // 
            // buttonZaduzi
            // 
            this.buttonZaduzi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonZaduzi.Location = new System.Drawing.Point(361, 435);
            this.buttonZaduzi.Name = "buttonZaduzi";
            this.buttonZaduzi.Size = new System.Drawing.Size(220, 46);
            this.buttonZaduzi.TabIndex = 62;
            this.buttonZaduzi.Text = "Zaduži Knjigu";
            this.buttonZaduzi.UseVisualStyleBackColor = true;
            this.buttonZaduzi.Click += new System.EventHandler(this.buttonZaduzi_Click);
            // 
            // buttonPotvrdi
            // 
            this.buttonPotvrdi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonPotvrdi.Location = new System.Drawing.Point(600, 175);
            this.buttonPotvrdi.Name = "buttonPotvrdi";
            this.buttonPotvrdi.Size = new System.Drawing.Size(130, 40);
            this.buttonPotvrdi.TabIndex = 3;
            this.buttonPotvrdi.Text = "Potvrdi";
            this.buttonPotvrdi.UseVisualStyleBackColor = true;
            this.buttonPotvrdi.Click += new System.EventHandler(this.buttonPotvrdi_Click);
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelIme.Location = new System.Drawing.Point(79, 63);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(97, 37);
            this.labelIme.TabIndex = 60;
            this.labelIme.Text = "<ime>";
            // 
            // pictureBox
            // 
            this.pictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox.Location = new System.Drawing.Point(736, 15);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 200);
            this.pictureBox.TabIndex = 59;
            this.pictureBox.TabStop = false;
            // 
            // textBoxIDKorisnika
            // 
            this.textBoxIDKorisnika.Location = new System.Drawing.Point(600, 43);
            this.textBoxIDKorisnika.Name = "textBoxIDKorisnika";
            this.textBoxIDKorisnika.PlaceholderText = "12345678";
            this.textBoxIDKorisnika.Size = new System.Drawing.Size(130, 43);
            this.textBoxIDKorisnika.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(545, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 37);
            this.label2.TabIndex = 57;
            this.label2.Text = "ID:";
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNaziv.Location = new System.Drawing.Point(18, 63);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(67, 37);
            this.labelNaziv.TabIndex = 56;
            this.labelNaziv.Text = "Ime:";
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(40, 40);
            this.buttonHome.TabIndex = 55;
            this.buttonHome.TabStop = false;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNaslov.Location = new System.Drawing.Point(197, 137);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(129, 37);
            this.labelNaslov.TabIndex = 69;
            this.labelNaslov.Text = "<naslov>";
            // 
            // checkBoxProfesor
            // 
            this.checkBoxProfesor.AutoSize = true;
            this.checkBoxProfesor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxProfesor.Location = new System.Drawing.Point(444, 174);
            this.checkBoxProfesor.Name = "checkBoxProfesor";
            this.checkBoxProfesor.Size = new System.Drawing.Size(137, 41);
            this.checkBoxProfesor.TabIndex = 70;
            this.checkBoxProfesor.Text = "Profesor";
            this.checkBoxProfesor.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 400;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ZaduziKnjiguForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonHome;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxProfesor);
            this.Controls.Add(this.labelNaslov);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxIDKnjige);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonZaduzi);
            this.Controls.Add(this.buttonPotvrdi);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBoxIDKorisnika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.buttonHome);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ZaduziKnjiguForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zaduži Knjigu";
            this.Load += new System.EventHandler(this.ZaduziKnjiguForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label label5;
        private TextBox textBoxIDKnjige;
        private Label label4;
        private Label labelDatum;
        private Label label3;
        private Button buttonZaduzi;
        private Button buttonPotvrdi;
        private Label labelIme;
        private PictureBox pictureBox;
        private TextBox textBoxIDKorisnika;
        private Label label2;
        private Label labelNaziv;
        private Button buttonHome;
        private Label labelNaslov;
        private CheckBox checkBoxProfesor;
        private System.Windows.Forms.Timer timer;
    }
}