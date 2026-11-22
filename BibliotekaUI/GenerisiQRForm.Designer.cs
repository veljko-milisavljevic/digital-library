namespace BibliotekaUI
{
    partial class GenerisiQRForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerisiQRForm));
            this.buttonHome = new System.Windows.Forms.Button();
            this.checkBoxUzastopni = new System.Windows.Forms.CheckBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
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
            this.buttonHome.TabIndex = 3;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // checkBoxUzastopni
            // 
            this.checkBoxUzastopni.AutoSize = true;
            this.checkBoxUzastopni.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxUzastopni.Location = new System.Drawing.Point(12, 146);
            this.checkBoxUzastopni.Name = "checkBoxUzastopni";
            this.checkBoxUzastopni.Size = new System.Drawing.Size(364, 36);
            this.checkBoxUzastopni.TabIndex = 5;
            this.checkBoxUzastopni.Text = "Generiši uzastopne QR kodove";
            this.checkBoxUzastopni.UseVisualStyleBackColor = true;
            this.checkBoxUzastopni.CheckedChanged += new System.EventHandler(this.checkBoxUzastopni_CheckedChanged);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(272, 200);
            this.numericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(104, 43);
            this.numericUpDown.TabIndex = 6;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Visible = false;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(67, 89);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(150, 43);
            this.textBoxID.TabIndex = 7;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Broj uzastopnih:";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(316, 387);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Generiši";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(503, 89);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(205, 205);
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "Uzorak:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(76, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(615, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Molim sačekajte, ovo može trajati par minuta. Ne zatvarajte program.";
            this.label4.Visible = false;
            // 
            // GenerisiQRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.checkBoxUzastopni);
            this.Controls.Add(this.buttonHome);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GenerisiQRForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generiši QR kod";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonHome;
        private CheckBox checkBoxUzastopni;
        private NumericUpDown numericUpDown;
        private TextBox textBoxID;
        private Label label1;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox;
        private PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private Label label3;
        private Label label4;
    }
}