using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_MS_BlackJack
{
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void FormAccueil_Load(object sender, EventArgs e)
        {
           
        }
        private void PictureBoxBackGround_click(object sender, EventArgs e)
        {

        }

        private void BoutonJouer_click(object sender, EventArgs e)
        {
            FormPartie partie = new FormPartie();
            partie.ShowDialog();
            Close();
        }

        private void TextAccueil_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoutonPseudo_click(object sender, EventArgs e)
        {
            FormPseudo pseudo = new FormPseudo();
            pseudo.ShowDialog();
            BoutonPseudo.Text = pseudo.TextBoxPseudo.Text;
        }

        private void BoutonJetons_click(object sender, EventArgs e)
        {

        }

    }
}
