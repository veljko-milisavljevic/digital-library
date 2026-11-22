namespace BibliotekaUI
{
    partial class DodajKnjiguForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajKnjiguForm));
            this.buttonHome = new System.Windows.Forms.Button();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.textBoxPisac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonProveri = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(12, 54);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(89, 37);
            this.labelNaziv.TabIndex = 3;
            this.labelNaziv.Text = "Naziv:";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(107, 51);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(258, 43);
            this.textBoxNaziv.TabIndex = 1;
            // 
            // textBoxPisac
            // 
            this.textBoxPisac.Location = new System.Drawing.Point(107, 124);
            this.textBoxPisac.Name = "textBoxPisac";
            this.textBoxPisac.Size = new System.Drawing.Size(258, 43);
            this.textBoxPisac.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pisac:";
            // 
            // buttonProveri
            // 
            this.buttonProveri.Location = new System.Drawing.Point(12, 382);
            this.buttonProveri.Name = "buttonProveri";
            this.buttonProveri.Size = new System.Drawing.Size(122, 50);
            this.buttonProveri.TabIndex = 4;
            this.buttonProveri.Text = "Proveri";
            this.buttonProveri.UseVisualStyleBackColor = true;
            this.buttonProveri.Click += new System.EventHandler(this.buttonProveri_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(243, 382);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(122, 50);
            this.buttonDodaj.TabIndex = 5;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Visible = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(215, 262);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(150, 43);
            this.textBoxID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Inventarni Broj:";
            // 
            // DodajKnjiguForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonHome;
            this.ClientSize = new System.Drawing.Size(377, 493);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.buttonProveri);
            this.Controls.Add(this.textBoxPisac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.buttonHome);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "DodajKnjiguForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Knjigu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonHome;
        private Label labelNaziv;
        private TextBox textBoxNaziv;
        private TextBox textBoxPisac;
        private Label label1;
        private Button buttonProveri;
        private Button buttonDodaj;
        private TextBox textBoxID;
        private Label label3;
    }
}