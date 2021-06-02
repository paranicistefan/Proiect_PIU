
namespace Interfata
{
    partial class Adaugare_Clienti
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
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblCNP = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.btnAdaugaClient = new System.Windows.Forms.Button();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.errLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAdresa
            // 
            this.txtAdresa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdresa.Location = new System.Drawing.Point(470, 86);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.PlaceholderText = "Introduceti adresa dvs";
            this.txtAdresa.Size = new System.Drawing.Size(257, 30);
            this.txtAdresa.TabIndex = 20;
            this.txtAdresa.TextChanged += new System.EventHandler(this.txtAdresa_TextChanged);
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblAdresa.Location = new System.Drawing.Point(468, 40);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(81, 28);
            this.lblAdresa.TabIndex = 19;
            this.lblAdresa.Text = "Adresa";
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCNP.Location = new System.Drawing.Point(47, 219);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(60, 28);
            this.lblCNP.TabIndex = 18;
            this.lblCNP.Text = "CNP";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrenume.Location = new System.Drawing.Point(47, 171);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.PlaceholderText = "Introduceti Prenumele";
            this.txtPrenume.Size = new System.Drawing.Size(257, 30);
            this.txtPrenume.TabIndex = 17;
            this.txtPrenume.TextChanged += new System.EventHandler(this.txtPrenume_TextChanged);
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPrenume.Location = new System.Drawing.Point(45, 129);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(102, 28);
            this.lblPrenume.TabIndex = 16;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNume.Location = new System.Drawing.Point(45, 40);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(71, 28);
            this.lblNume.TabIndex = 14;
            this.lblNume.Text = "Nume";
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNume.Location = new System.Drawing.Point(47, 86);
            this.txtNume.Name = "txtNume";
            this.txtNume.PlaceholderText = "Introduceti Numele";
            this.txtNume.Size = new System.Drawing.Size(257, 30);
            this.txtNume.TabIndex = 28;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // txtCNP
            // 
            this.txtCNP.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCNP.Location = new System.Drawing.Point(47, 261);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.PlaceholderText = "Introduceti CNP-ul";
            this.txtCNP.Size = new System.Drawing.Size(257, 30);
            this.txtCNP.TabIndex = 29;
            this.txtCNP.TextChanged += new System.EventHandler(this.txtCNP_TextChanged);
            // 
            // btnAdaugaClient
            // 
            this.btnAdaugaClient.Location = new System.Drawing.Point(296, 352);
            this.btnAdaugaClient.Name = "btnAdaugaClient";
            this.btnAdaugaClient.Size = new System.Drawing.Size(230, 53);
            this.btnAdaugaClient.TabIndex = 30;
            this.btnAdaugaClient.Text = "Adauga";
            this.btnAdaugaClient.UseVisualStyleBackColor = true;
            this.btnAdaugaClient.Click += new System.EventHandler(this.btnAdaugaClient_Click);
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSerie.Location = new System.Drawing.Point(470, 171);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.PlaceholderText = "Introduceti Seria de buletin";
            this.txtSerie.Size = new System.Drawing.Size(257, 30);
            this.txtSerie.TabIndex = 32;
            this.txtSerie.TextChanged += new System.EventHandler(this.txtSerie_TextChanged);
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSerie.Location = new System.Drawing.Point(470, 129);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(143, 28);
            this.lblSerie.TabIndex = 31;
            this.lblSerie.Text = "Serie Buletin";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefon.Location = new System.Drawing.Point(470, 261);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.PlaceholderText = "Introduceti telefonul dvs";
            this.txtTelefon.Size = new System.Drawing.Size(257, 30);
            this.txtTelefon.TabIndex = 34;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTelefon.Location = new System.Drawing.Point(470, 219);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(87, 28);
            this.lblTelefon.TabIndex = 33;
            this.lblTelefon.Text = "Telefon";
            // 
            // errLabel
            // 
            this.errLabel.AutoSize = true;
            this.errLabel.Font = new System.Drawing.Font("Sitka Subheading", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.errLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errLabel.Location = new System.Drawing.Point(241, 310);
            this.errLabel.Name = "errLabel";
            this.errLabel.Size = new System.Drawing.Size(347, 26);
            this.errLabel.TabIndex = 35;
            this.errLabel.Text = "**Completati Campurle marcate cu rosu";
            this.errLabel.Visible = false;
            // 
            // Adaugare_Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.errLabel);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.btnAdaugaClient);
            this.Controls.Add(this.txtCNP);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblCNP);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Name = "Adaugare_Clienti";
            this.Text = "Adaugare_Clienti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.Button btnAdaugaClient;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label errLabel;
    }
}