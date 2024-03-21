using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class carte
{
    private int val;
    private string couleur;

    // Constructeur de classe avec paramètre par defaut a 0 et null
    public carte(int a=0,string b="nul")
    {
        val = a;
        couleur = b;
    }

    //Methode get / set
    public int getval()
    {
        return val;
    }

    public void setval(int a)
    {
        val = a;
    }
    public string getcouleur()
    {
        return couleur;
    }
    public void setcouleur(string a)
    {
        couleur = a;
    }
}

public class jeu
{
    private int nb_joueur;
    private Random random = new Random();
    
    public carte Tirer_carte(carte a)
    {
        a.setval(random.Next(1, 14));                     //tire une valeur de carte aléatoire entre 1 et 14 exclus
        string[] liste_couleur = { "pic", "coeur", "trefle","carreau" };
        a.setcouleur(liste_couleur[random.Next(1, 5)-1]);    //tire un aléatoirement une valeur dans la liste des différentes couleur

        return a;
    }

    
}

public class joueur
{
    private int numero;
    private int compt;
    private int nb_carte;
    private carte[] cartes;

    public joueur(int a)
    {
        numero = a;
        compt = 0;
        nb_carte = 0;
        cartes= new carte[10];
    }

}


