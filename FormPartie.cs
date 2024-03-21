using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Code_MS_BlackJack;
using Code_MS_BlackJack.Properties;

namespace Code_MS_BlackJack
{
    public partial class FormPartie : Form
    {
        public FormPartie()
        {
            InitializeComponent();

            Classes.carte[] Carte_h = { };
            for (int i = 0; i < 13; i++)
            {
                Carte_h[i] = new Classes.carte(i + 1, "Coeur");
            }

            Classes.carte[] Carte_d = { };
            for (int i = 0; i < 13; i++)
            {
                Carte_d[i] = new Classes.carte(i + 1, "Carreau");
            }

            Classes.carte[] Carte_s = { };
            for (int i = 0; i < 13; i++)
            {
                Carte_s[i] = new Classes.carte(i + 1, "Pique");
            }

            Classes.carte[] Carte_c = { };
            for (int i = 0; i < 13; i++)
            {
                Carte_c[i] = new Classes.carte(i + 1, "Trèfle");
            }


        }

        private void FormPartie_Load(object sender, EventArgs e)
        {

        }


    }
}
