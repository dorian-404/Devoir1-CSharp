/*
    Programmeur:    Dorian Wontcheu & Franck G.
    Date:           Septembre

    Solution:       NBAForm.sln
    Projet:         NBAForm.csproj
    Classe:         NBAForm.cs

    But:            Aperçu avant impression du rapport des meilleurs joueurs de la NBA.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NBAForm
{
    public partial class BestTeamNBAForm : Form
    {

        #region Initialisations
        public BestTeamNBAForm()
        {
            InitializeComponent();
        }

        private void BestTeamNBAForm_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Imprimer les sites
        private void imprimerButton_Click(object sender, EventArgs e)
        {
            nbaPrintPreviewDialog.ShowDialog();
        }

        private void nbaPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // defintion des polices pour l'entete, des titres
            Graphics g = e.Graphics;

            Font titreFont = new Font("Cooper Black", 24, FontStyle.Italic ^ FontStyle.Bold);
            Font enteteFont = new Font("MS Sans Serif", 14, FontStyle.Regular ^ FontStyle.Bold);
            Font descriptionFont = new Font("Cascadia Code", 10);
            Font dateFont = new Font("Cascadia Code", 18);

            // definition du titre du rapport et mesure 
            string nomString = "Dorian & Franck";

            // Date d'aujourd'hui
            string dateString = DateTime.Today.ToLongDateString();
            string nomDateString = nomString + ", date = " + dateString;

            // Polices du nom et date ensembles

            Font nomDateFont = new Font("Magneto", 16, FontStyle.Italic ^ FontStyle.Bold);


            string titreString = titreLabel.Text + " - " + nomString;
            Single largeurTitreSingle = g.MeasureString(titreString, titreFont).Width;

            string enteteString = "Sites pour en savoir plus";
            Single largeurEnteteSingle = g.MeasureString(enteteString, enteteFont).Width;

            // taille des polices
            Single taillePoliceTitreSingle = titreFont.GetHeight();
            Single taillePoliceEntetesingle = enteteFont.GetHeight();
            Single taillePoliceDescriptionSingle = descriptionFont.GetHeight();

            // Taille de l'image en pixels
            //Single largeurLogoSingle;

            Single largeurDuLogoSingle;
            Single hauteurDuLogoSingle;

            Image logo;

            if (impressionLogoRadioButton.Checked)
            {
                largeurDuLogoSingle = (nbaLogoPictureBox.Image.Width / nbaLogoPictureBox.Image.HorizontalResolution) * 50.0F;
                hauteurDuLogoSingle = (nbaLogoPictureBox.Image.Height / nbaLogoPictureBox.Image.VerticalResolution) * 50.0F;

                logo = Properties.Resources.nbaLogo;
            }
            else
            {
                largeurDuLogoSingle = (michaelImagePictureBox.Image.Width / michaelImagePictureBox.Image.HorizontalResolution) * 50.0F;
                hauteurDuLogoSingle = (michaelImagePictureBox.Image.Height / michaelImagePictureBox.Image.VerticalResolution) * 50.0F;

                logo = Properties.Resources.Michael_Jordan;
            }

            // Position initiale du crayon

            Single xSingle = e.MarginBounds.X;
            Single ySingle = e.MarginBounds.Y;

            Size nouvelleTaille = new Size((int)largeurDuLogoSingle, (int)hauteurDuLogoSingle);

            logo = ImageRedimensionner(logo, nouvelleTaille);

            g.DrawImage(logo, xSingle + (e.MarginBounds.Width - largeurDuLogoSingle) / 2, ySingle);

            ySingle += hauteurDuLogoSingle + 20.0F;

            g.DrawString(titreString, titreFont, Brushes.DarkRed, xSingle, ySingle);
            g.DrawRectangle(Pens.DarkSlateBlue, xSingle, ySingle, largeurTitreSingle, taillePoliceTitreSingle);

            ySingle += taillePoliceTitreSingle * 2.0F;

            g.DrawString(enteteString, enteteFont, Brushes.DarkViolet, xSingle, ySingle);

            ySingle += taillePoliceEntetesingle + 5;

            g.DrawLine(new Pen(Color.Goldenrod, 7.0F), xSingle, ySingle, xSingle + e.MarginBounds.Width, ySingle);

            ySingle += taillePoliceTitreSingle;

            for (int i = 0; i < listeSiteTextBox.Lines.Length; i++)
            {
                g.DrawString((i + 1) + "     " + listeSiteTextBox.Lines[i], descriptionFont, Brushes.DarkRed, xSingle, ySingle);

                ySingle += taillePoliceDescriptionSingle;
            }

            ySingle += taillePoliceTitreSingle * 2.0F;

            g.DrawString(nomDateString, nomDateFont, Brushes.DeepPink, xSingle, ySingle);
        }

        private Image ImageRedimensionner(Image imgARedimensionner, Size taille)
        {
            return (Image)(new Bitmap(imgARedimensionner, taille));
        }

        #endregion

        #region Fermer l'Application
        private void fermerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
