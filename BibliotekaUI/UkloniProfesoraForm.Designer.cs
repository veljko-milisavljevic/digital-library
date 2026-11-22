namespace BibliotekaUI
{
    partial class UkloniProfesoraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UkloniProfesoraForm));
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUkloni = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(218, 75);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(150, 43);
            this.textBoxID.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 37);
            this.label3.TabIndex = 23;
            this.label3.Text = "ID profesora:";
            // 
            // buttonUkloni
            // 
            this.buttonUkloni.Location = new System.Drawing.Point(127, 191);
            this.buttonUkloni.Name = "buttonUkloni";
            this.buttonUkloni.Size = new System.Drawing.Size(122, 50);
            this.buttonUkloni.TabIndex = 22;
            this.buttonUkloni.Text = "Ukloni";
            this.buttonUkloni.UseVisualStyleBackColor = true;
            this.buttonUkloni.Click += new System.EventHandler(this.buttonUkloni_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(3, 3);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(40, 40);
            this.buttonHome.TabIndex = 21;
            this.buttonHome.TabStop = false;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // UkloniProfesoraForm
            // 
            this.AcceptButton = this.buttonUkloni;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonHome;
            this.ClientSize = new System.Drawing.Size(377, 253);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonUkloni);
            this.Controls.Add(this.buttonHome);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UkloniProfesoraForm";
            this.Text = "Ukloni Profesora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxID;
        private Label label3;
        private Button buttonUkloni;
        private Button buttonHome;
    }
}