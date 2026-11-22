namespace BibliotekaUI
{
    partial class PretraziKnjiguForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PretraziKnjiguForm));
            this.buttonHome = new System.Windows.Forms.Button();
            this.textBoxNaslov = new System.Windows.Forms.TextBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.textBoxPisac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonPretrazi = new System.Windows.Forms.Button();
            this.listViewPretraga = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Knjiga = new System.Windows.Forms.ColumnHeader();
            this.Pisac = new System.Windows.Forms.ColumnHeader();
            this.NaStanju = new System.Windows.Forms.ColumnHeader();
            this.Ukupno = new System.Windows.Forms.ColumnHeader();
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
            // textBoxNaslov
            // 
            this.textBoxNaslov.Location = new System.Drawing.Point(142, 56);
            this.textBoxNaslov.Name = "textBoxNaslov";
            this.textBoxNaslov.Size = new System.Drawing.Size(258, 43);
            this.textBoxNaslov.TabIndex = 10;
            this.textBoxNaslov.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNaziv.Location = new System.Drawing.Point(12, 59);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(104, 37);
            this.labelNaziv.TabIndex = 9;
            this.labelNaziv.Text = "Naslov:";
            // 
            // textBoxPisac
            // 
            this.textBoxPisac.Location = new System.Drawing.Point(142, 105);
            this.textBoxPisac.Name = "textBoxPisac";
            this.textBoxPisac.Size = new System.Drawing.Size(258, 43);
            this.textBoxPisac.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pisac:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(528, 169);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(200, 43);
            this.textBoxID.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(528, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Inventarni broj:";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(730, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 200);
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            // 
            // buttonPretrazi
            // 
            this.buttonPretrazi.Location = new System.Drawing.Point(528, 232);
            this.buttonPretrazi.Name = "buttonPretrazi";
            this.buttonPretrazi.Size = new System.Drawing.Size(402, 40);
            this.buttonPretrazi.TabIndex = 32;
            this.buttonPretrazi.Text = "Pretraži";
            this.buttonPretrazi.UseVisualStyleBackColor = true;
            this.buttonPretrazi.Click += new System.EventHandler(this.buttonPretrazi_Click);
            // 
            // listViewPretraga
            // 
            this.listViewPretraga.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Knjiga,
            this.Pisac,
            this.NaStanju,
            this.Ukupno});
            this.listViewPretraga.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewPretraga.Location = new System.Drawing.Point(12, 292);
            this.listViewPretraga.Name = "listViewPretraga";
            this.listViewPretraga.Size = new System.Drawing.Size(918, 189);
            this.listViewPretraga.TabIndex = 33;
            this.listViewPretraga.UseCompatibleStateImageBehavior = false;
            this.listViewPretraga.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "Inventarni br.";
            this.ID.Width = 150;
            // 
            // Knjiga
            // 
            this.Knjiga.Text = "Knjiga";
            this.Knjiga.Width = 300;
            // 
            // Pisac
            // 
            this.Pisac.Text = "Pisac";
            this.Pisac.Width = 220;
            // 
            // NaStanju
            // 
            this.NaStanju.Text = "Na Stanju";
            this.NaStanju.Width = 115;
            // 
            // Ukupno
            // 
            this.Ukupno.Text = "Ukupno";
            this.Ukupno.Width = 100;
            // 
            // timer
            // 
            this.timer.Interval = 400;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // PretraziKnjiguForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonHome;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.ControlBox = false;
            this.Controls.Add(this.listViewPretraga);
            this.Controls.Add(this.buttonPretrazi);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPisac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNaslov);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.buttonHome);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "PretraziKnjiguForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraži Knjigu";
            this.Load += new System.EventHandler(this.PretraziKnjiguForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonHome;
        private TextBox textBoxNaslov;
        private Label labelNaziv;
        private TextBox textBoxPisac;
        private Label label1;
        private TextBox textBoxID;
        private Label label2;
        private PictureBox pictureBox;
        private Button buttonPretrazi;
        private ListView listViewPretraga;
        private ColumnHeader ID;
        private ColumnHeader Knjiga;
        private ColumnHeader Pisac;
        private ColumnHeader NaStanju;
        private ColumnHeader Ukupno;
        private System.Windows.Forms.Timer timer;
    }
}