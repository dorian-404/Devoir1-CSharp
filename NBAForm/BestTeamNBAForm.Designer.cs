namespace NBAForm
{
    partial class BestTeamNBAForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestTeamNBAForm));
            this.titreLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionJoueurLbael = new System.Windows.Forms.Label();
            this.titreDescriptionLabel = new System.Windows.Forms.Label();
            this.impressionLogoRadioButton = new System.Windows.Forms.RadioButton();
            this.impressionImageRadioButton = new System.Windows.Forms.RadioButton();
            this.impressionGroupBox = new System.Windows.Forms.GroupBox();
            this.imprimerButton = new System.Windows.Forms.Button();
            this.siteLabel = new System.Windows.Forms.Label();
            this.listeSiteTextBox = new System.Windows.Forms.TextBox();
            this.bioLabel = new System.Windows.Forms.Label();
            this.programmeurLabel = new System.Windows.Forms.Label();
            this.fermerButton = new System.Windows.Forms.Button();
            this.nbaPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.nbaPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.michaelImagePictureBox = new System.Windows.Forms.PictureBox();
            this.nbaLogoPictureBox2 = new System.Windows.Forms.PictureBox();
            this.nbaLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.impressionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.michaelImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbaLogoPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbaLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titreLabel
            // 
            this.titreLabel.AutoSize = true;
            this.titreLabel.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titreLabel.Location = new System.Drawing.Point(360, 46);
            this.titreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titreLabel.Name = "titreLabel";
            this.titreLabel.Size = new System.Drawing.Size(439, 46);
            this.titreLabel.TabIndex = 0;
            this.titreLabel.Text = "Meilleur joueur NBA";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionLabel.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.descriptionLabel.Location = new System.Drawing.Point(489, 175);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(362, 112);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "  - Le nombre de PlayOffs remportes\r\n  - Le nombre de M.V.P recus\r\n  - Le nombre " +
    "de points marques \r\n  - Le nombre de passes delivres \r\n  - Le nombre de 3 points" +
    " marques";
            // 
            // descriptionJoueurLbael
            // 
            this.descriptionJoueurLbael.AutoSize = true;
            this.descriptionJoueurLbael.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionJoueurLbael.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.descriptionJoueurLbael.Location = new System.Drawing.Point(485, 335);
            this.descriptionJoueurLbael.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionJoueurLbael.Name = "descriptionJoueurLbael";
            this.descriptionJoueurLbael.Size = new System.Drawing.Size(650, 88);
            this.descriptionJoueurLbael.TabIndex = 5;
            this.descriptionJoueurLbael.Text = resources.GetString("descriptionJoueurLbael.Text");
            this.descriptionJoueurLbael.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titreDescriptionLabel
            // 
            this.titreDescriptionLabel.AutoSize = true;
            this.titreDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreDescriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titreDescriptionLabel.Location = new System.Drawing.Point(485, 133);
            this.titreDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titreDescriptionLabel.Name = "titreDescriptionLabel";
            this.titreDescriptionLabel.Size = new System.Drawing.Size(83, 20);
            this.titreDescriptionLabel.TabIndex = 6;
            this.titreDescriptionLabel.Text = "Criteres:";
            // 
            // impressionLogoRadioButton
            // 
            this.impressionLogoRadioButton.AutoSize = true;
            this.impressionLogoRadioButton.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impressionLogoRadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.impressionLogoRadioButton.Location = new System.Drawing.Point(64, 33);
            this.impressionLogoRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.impressionLogoRadioButton.Name = "impressionLogoRadioButton";
            this.impressionLogoRadioButton.Size = new System.Drawing.Size(66, 24);
            this.impressionLogoRadioButton.TabIndex = 7;
            this.impressionLogoRadioButton.TabStop = true;
            this.impressionLogoRadioButton.Text = "Logo";
            this.impressionLogoRadioButton.UseVisualStyleBackColor = true;
            // 
            // impressionImageRadioButton
            // 
            this.impressionImageRadioButton.AutoSize = true;
            this.impressionImageRadioButton.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impressionImageRadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.impressionImageRadioButton.Location = new System.Drawing.Point(64, 65);
            this.impressionImageRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.impressionImageRadioButton.Name = "impressionImageRadioButton";
            this.impressionImageRadioButton.Size = new System.Drawing.Size(75, 24);
            this.impressionImageRadioButton.TabIndex = 8;
            this.impressionImageRadioButton.TabStop = true;
            this.impressionImageRadioButton.Text = "Image";
            this.impressionImageRadioButton.UseVisualStyleBackColor = true;
            // 
            // impressionGroupBox
            // 
            this.impressionGroupBox.Controls.Add(this.imprimerButton);
            this.impressionGroupBox.Controls.Add(this.impressionImageRadioButton);
            this.impressionGroupBox.Controls.Add(this.impressionLogoRadioButton);
            this.impressionGroupBox.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impressionGroupBox.Location = new System.Drawing.Point(52, 470);
            this.impressionGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.impressionGroupBox.Name = "impressionGroupBox";
            this.impressionGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.impressionGroupBox.Size = new System.Drawing.Size(403, 143);
            this.impressionGroupBox.TabIndex = 9;
            this.impressionGroupBox.TabStop = false;
            this.impressionGroupBox.Text = "Impression";
            // 
            // imprimerButton
            // 
            this.imprimerButton.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimerButton.Location = new System.Drawing.Point(64, 102);
            this.imprimerButton.Margin = new System.Windows.Forms.Padding(4);
            this.imprimerButton.Name = "imprimerButton";
            this.imprimerButton.Size = new System.Drawing.Size(100, 28);
            this.imprimerButton.TabIndex = 9;
            this.imprimerButton.Text = "&Imprimer";
            this.imprimerButton.UseVisualStyleBackColor = true;
            this.imprimerButton.Click += new System.EventHandler(this.imprimerButton_Click);
            // 
            // siteLabel
            // 
            this.siteLabel.AutoSize = true;
            this.siteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.siteLabel.Location = new System.Drawing.Point(485, 450);
            this.siteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.siteLabel.Name = "siteLabel";
            this.siteLabel.Size = new System.Drawing.Size(225, 20);
            this.siteLabel.TabIndex = 10;
            this.siteLabel.Text = "Sites pour en savoir plus:";
            // 
            // listeSiteTextBox
            // 
            this.listeSiteTextBox.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeSiteTextBox.Location = new System.Drawing.Point(489, 487);
            this.listeSiteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.listeSiteTextBox.Multiline = true;
            this.listeSiteTextBox.Name = "listeSiteTextBox";
            this.listeSiteTextBox.Size = new System.Drawing.Size(608, 95);
            this.listeSiteTextBox.TabIndex = 11;
            this.listeSiteTextBox.Text = "https://www.netflix.com/ca-fr/title/80203144\r\nhttps://www.nba.com/stats/player/89" +
    "3/career\r\nhttps://www.britannica.com/biography/Michael-Jordan\r\nhttps://www.micha" +
    "eljordansworld.com/achievements.htm";
            // 
            // bioLabel
            // 
            this.bioLabel.AutoSize = true;
            this.bioLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bioLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bioLabel.Location = new System.Drawing.Point(485, 298);
            this.bioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bioLabel.Name = "bioLabel";
            this.bioLabel.Size = new System.Drawing.Size(112, 20);
            this.bioLabel.TabIndex = 12;
            this.bioLabel.Text = "Description:";
            // 
            // programmeurLabel
            // 
            this.programmeurLabel.AutoSize = true;
            this.programmeurLabel.Font = new System.Drawing.Font("Cascadia Code", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programmeurLabel.ForeColor = System.Drawing.Color.Blue;
            this.programmeurLabel.Location = new System.Drawing.Point(48, 650);
            this.programmeurLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.programmeurLabel.Name = "programmeurLabel";
            this.programmeurLabel.Size = new System.Drawing.Size(390, 22);
            this.programmeurLabel.TabIndex = 13;
            this.programmeurLabel.Text = "Programmeurs : Dorian et Franck Gildas";
            // 
            // fermerButton
            // 
            this.fermerButton.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermerButton.Location = new System.Drawing.Point(983, 635);
            this.fermerButton.Margin = new System.Windows.Forms.Padding(4);
            this.fermerButton.Name = "fermerButton";
            this.fermerButton.Size = new System.Drawing.Size(116, 36);
            this.fermerButton.TabIndex = 14;
            this.fermerButton.Text = "Fermer";
            this.fermerButton.UseVisualStyleBackColor = true;
            this.fermerButton.Click += new System.EventHandler(this.fermerButton_Click);
            // 
            // nbaPrintPreviewDialog
            // 
            this.nbaPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.nbaPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.nbaPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.nbaPrintPreviewDialog.Document = this.nbaPrintDocument;
            this.nbaPrintPreviewDialog.Enabled = true;
            this.nbaPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("nbaPrintPreviewDialog.Icon")));
            this.nbaPrintPreviewDialog.Name = "nbaPrintPreviewDialog";
            this.nbaPrintPreviewDialog.Visible = false;
            // 
            // nbaPrintDocument
            // 
            this.nbaPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.nbaPrintDocument_PrintPage);
            // 
            // michaelImagePictureBox
            // 
            this.michaelImagePictureBox.BackColor = System.Drawing.Color.Brown;
            this.michaelImagePictureBox.Image = global::NBAForm.Properties.Resources.Michael_Jordan;
            this.michaelImagePictureBox.Location = new System.Drawing.Point(52, 130);
            this.michaelImagePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.michaelImagePictureBox.Name = "michaelImagePictureBox";
            this.michaelImagePictureBox.Size = new System.Drawing.Size(403, 288);
            this.michaelImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.michaelImagePictureBox.TabIndex = 4;
            this.michaelImagePictureBox.TabStop = false;
            // 
            // nbaLogoPictureBox2
            // 
            this.nbaLogoPictureBox2.Image = global::NBAForm.Properties.Resources.nbaLogo;
            this.nbaLogoPictureBox2.Location = new System.Drawing.Point(932, 25);
            this.nbaLogoPictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.nbaLogoPictureBox2.Name = "nbaLogoPictureBox2";
            this.nbaLogoPictureBox2.Size = new System.Drawing.Size(137, 102);
            this.nbaLogoPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nbaLogoPictureBox2.TabIndex = 2;
            this.nbaLogoPictureBox2.TabStop = false;
            // 
            // nbaLogoPictureBox
            // 
            this.nbaLogoPictureBox.Image = global::NBAForm.Properties.Resources.nbaLogo;
            this.nbaLogoPictureBox.Location = new System.Drawing.Point(101, 25);
            this.nbaLogoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.nbaLogoPictureBox.Name = "nbaLogoPictureBox";
            this.nbaLogoPictureBox.Size = new System.Drawing.Size(143, 108);
            this.nbaLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nbaLogoPictureBox.TabIndex = 1;
            this.nbaLogoPictureBox.TabStop = false;
            // 
            // BestTeamNBAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1183, 700);
            this.Controls.Add(this.fermerButton);
            this.Controls.Add(this.programmeurLabel);
            this.Controls.Add(this.bioLabel);
            this.Controls.Add(this.listeSiteTextBox);
            this.Controls.Add(this.siteLabel);
            this.Controls.Add(this.impressionGroupBox);
            this.Controls.Add(this.titreDescriptionLabel);
            this.Controls.Add(this.descriptionJoueurLbael);
            this.Controls.Add(this.michaelImagePictureBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nbaLogoPictureBox2);
            this.Controls.Add(this.nbaLogoPictureBox);
            this.Controls.Add(this.titreLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BestTeamNBAForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meilleur joueur NBA";
            this.Load += new System.EventHandler(this.BestTeamNBAForm_Load);
            this.impressionGroupBox.ResumeLayout(false);
            this.impressionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.michaelImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbaLogoPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbaLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titreLabel;
        private System.Windows.Forms.PictureBox nbaLogoPictureBox;
        private System.Windows.Forms.PictureBox nbaLogoPictureBox2;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.PictureBox michaelImagePictureBox;
        private System.Windows.Forms.Label descriptionJoueurLbael;
        private System.Windows.Forms.Label titreDescriptionLabel;
        private System.Windows.Forms.RadioButton impressionLogoRadioButton;
        private System.Windows.Forms.RadioButton impressionImageRadioButton;
        private System.Windows.Forms.GroupBox impressionGroupBox;
        private System.Windows.Forms.Button imprimerButton;
        private System.Windows.Forms.Label siteLabel;
        private System.Windows.Forms.TextBox listeSiteTextBox;
        private System.Windows.Forms.Label bioLabel;
        private System.Windows.Forms.Label programmeurLabel;
        private System.Windows.Forms.Button fermerButton;
        private System.Windows.Forms.PrintPreviewDialog nbaPrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument nbaPrintDocument;
    }
}

