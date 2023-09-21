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
        public BestTeamNBAForm()
        {
            InitializeComponent();
        }


        #region PrintPage
        private void nbaPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // defintion des polices pour l'entete, des titres
            Graphics g = e.Graphics;

            Font titreFont = new Font("Cooper Black", 24, FontStyle.Italic ^ FontStyle.Bold);
            Font enteteFont = new Font("MS Sans Serif", 14, FontStyle.Italic ^ FontStyle.Underline);
            Font descriptionFont = new Font("Cascadia Code", 10);
            Font dateFont = new Font ("Cascadia Code", 18);

            // definition du titre du rapport et mesure 
            string nomString = "Dorian & Franck";

            string titreString = titreLabel.Text + " - " + nomString;
            SizeF largeurTitreSizeF = g.MeasureString(titreString, titreFont);

            string enteteString = "Sites pour en savoir plus";

            // taille des polices
            Single taillePoliceTitreSingle = titreFont.GetHeight();
            Single taillePoliceEntetesingle = enteteFont.GetHeight();
            Single taillePoliceDescriptionSingle = descriptionFont.GetHeight();

            // Taille de l'image en pixels
            //Single largeurLogoSingle;

        }

        #endregion

        #region Imprimer
        private void ImprimerButton_Click(object sender, EventArgs e)
        {
            nbaPrintPreviewDialog.ShowDialog();

        }

        #endregion

        private void BestTeamNBAForm_Load(object sender, EventArgs e)
        {

        }
    }
}
