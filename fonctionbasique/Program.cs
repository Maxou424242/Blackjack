using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System;

namespace fonctionbasique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            jeu game;
            game = new jeu();
            carte a = new carte();
            game.Tirer_carte(a);
            Console.WriteLine(a.getcouleur());
            Console.WriteLine(a.getval());
            string[] liste_couleur = { "pic", "coeur", "trefle", "carreau" };


        }
    }
}