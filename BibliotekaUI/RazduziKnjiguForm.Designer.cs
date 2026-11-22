namespace BibliotekaUI
{
    partial class RazduziKnjiguForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RazduziKnjiguForm));
            this.buttonHome = new System.Windows.Forms.Button();
            this.textBoxIDKnjige = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPotvrdi = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxIDKorisnika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRazduzi = new System.Windows.Forms.Button();
            this.labelKasnjenje = new System.Windows.Forms.Label();
            this.labelKazna = new System.Windows.Forms.Label();
            this.checkBoxProfesor = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
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
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // textBoxIDKnjige
            // 
            this.textBoxIDKnjige.Location = new System.Drawing.Point(594, 103);
            this.textBoxIDKnjige.Name = "textBoxIDKnjige";
            this.textBoxIDKnjige.PlaceholderText = "12345678";
            this.textBoxIDKnjige.Size = new System.Drawing.Size(130, 43);
            this.textBoxIDKnjige.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(460, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 37);
            this.label4.TabIndex = 71;
            this.label4.Text = "ID knjige:";
            // 
            // buttonPotvrdi
            // 
            this.buttonPotvrdi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonPotvrdi.Location = new System.Drawing.Point(594, 172);
            this.buttonPotvrdi.Name = "buttonPotvrdi";
            this.buttonPotvrdi.Size = new System.Drawing.Size(130, 40);
            this.buttonPotvrdi.TabIndex = 3;
            this.buttonPotvrdi.Text = "Potvrdi";
            this.buttonPotvrdi.UseVisualStyleBackColor = true;
            this.buttonPotvrdi.Click += new System.EventHandler(this.buttonPotvrdi_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox.Location = new System.Drawing.Point(730, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 200);
            this.pictureBox.TabIndex = 69;
            this.pictureBox.TabStop = false;
            // 
            // textBoxIDKorisnika
            // 
            this.textBoxIDKorisnika.Location = new System.Drawing.Point(594, 40);
            this.textBoxIDKorisnika.Name = "textBoxIDKorisnika";
            this.textBoxIDKorisnika.PlaceholderText = "12345678";
            this.textBoxIDKorisnika.Size = new System.Drawing.Size(130, 43);
            this.textBoxIDKorisnika.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(539, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 37);
            this.label2.TabIndex = 67;
            this.label2.Text = "ID:";
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelIme.Location = new System.Drawing.Point(101, 103);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(97, 37);
            this.labelIme.TabIndex = 74;
            this.labelIme.Text = "<ime>";
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNaziv.Location = new System.Drawing.Point(12, 103);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(67, 37);
            this.labelNaziv.TabIndex = 73;
            this.labelNaziv.Text = "Ime:";
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNaslov.Location = new System.Drawing.Point(204, 172);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(129, 37);
            this.labelNaslov.TabIndex = 76;
            this.labelNaslov.Text = "<naslov>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 37);
            this.label3.TabIndex = 75;
            this.label3.Text = "Naslov Knjige:";
            // 
            // buttonRazduzi
            // 
            this.buttonRazduzi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRazduzi.Location = new System.Drawing.Point(360, 435);
            this.buttonRazduzi.Name = "buttonRazduzi";
            this.buttonRazduzi.Size = new System.Drawing.Size(220, 46);
            this.buttonRazduzi.TabIndex = 77;
            this.buttonRazduzi.Text = "Razduži Knjigu";
            this.buttonRazduzi.UseVisualStyleBackColor = true;
            this.buttonRazduzi.Click += new System.EventHandler(this.buttonRazduzi_Click);
            // 
            // labelKasnjenje
            // 
            this.labelKasnjenje.AutoSize = true;
            this.labelKasnjenje.ForeColor = System.Drawing.Color.Firebrick;
            this.labelKasnjenje.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelKasnjenje.Location = new System.Drawing.Point(12, 241);
            this.labelKasnjenje.Name = "labelKasnjenje";
            this.labelKasnjenje.Size = new System.Drawing.Size(136, 37);
            this.labelKasnjenje.TabIndex = 78;
            this.labelKasnjenje.Text = "Kašnjenje:";
            this.labelKasnjenje.Visible = false;
            // 
            // labelKazna
            // 
            this.labelKazna.AutoSize = true;
            this.labelKazna.ForeColor = System.Drawing.Color.Firebrick;
            this.labelKazna.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelKazna.Location = new System.Drawing.Point(12, 310);
            this.labelKazna.Name = "labelKazna";
            this.labelKazna.Size = new System.Drawing.Size(94, 37);
            this.labelKazna.TabIndex = 80;
            this.labelKazna.Text = "Kazna:";
            this.labelKazna.Visible = false;
            // 
            // checkBoxProfesor
            // 
            this.checkBoxProfesor.AutoSize = true;
            this.checkBoxProfesor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxProfesor.Location = new System.Drawing.Point(443, 171);
            this.checkBoxProfesor.Name = "checkBoxProfesor";
            this.checkBoxProfesor.Size = new System.Drawing.Size(137, 41);
            this.checkBoxProfesor.TabIndex = 81;
            this.checkBoxProfesor.Text = "Profesor";
            this.checkBoxProfesor.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // RazduziKnjiguForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonHome;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxProfesor);
            this.Controls.Add(this.labelKazna);
            this.Controls.Add(this.labelKasnjenje);
            this.Controls.Add(this.buttonRazduzi);
            this.Controls.Add(this.labelNaslov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.textBoxIDKnjige);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonPotvrdi);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBoxIDKorisnika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonHome);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "RazduziKnjiguForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Razduži Knjigu";
            this.Load += new System.EventHandler(this.RazduziKnjiguForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonHome;
        private TextBox textBoxIDKnjige;
        private Label label4;
        private Button buttonPotvrdi;
        private PictureBox pictureBox;
        private TextBox textBoxIDKorisnika;
        private Label label2;
        private Label labelIme;
        private Label labelNaziv;
        private Label labelNaslov;
        private Label label3;
        private Button buttonRazduzi;
        private Label labelKasnjenje;
        private Label labelKazna;
        private CheckBox checkBoxProfesor;
        private System.Windows.Forms.Timer timer;
    }
}