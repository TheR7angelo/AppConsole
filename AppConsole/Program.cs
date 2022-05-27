using System;

namespace AppConsole
{
    /*
     *  1. Le joueur est dans une foret. Il peut aller à l'est ou à l'ouest.
     *      1.1 Si le choix est est zlors il tombe et à perdu
     *      1.2 Si ouest alors le jeux continue
     *  2. Le joueur est devant le chateau. Il peut entrer par la porte ou par la fenetre.
     *      2.1 Si porte = Un garde l'arrete Game Over
     *      2.2 Si fenetre alors le jeu continue
     *  3. Le joueur est dans le couloir du chateau. Il peut ouvrir la porte de droite ou bien de gauche.
     *      3.1 Si porte gauche = Il tombe sur des des gardes Game Over.
     *      3.2 Si droite = Il trouve la princesse WINNE
     *
     *  Suite :
     *      - Ajouter un inventaire, clef, objet.
     *      - Plus de route.
     *      - Système de score, vie, magie.
     */

    class Game
    {
        static void Main(String[] args)
        {
            string dir;
            Console.WriteLine(Introduction());
            
            Quitter();

        }

        private static string Introduction()
        {
            string presentation = "Bienvenue dans ce jeux \"AppConsole\".\n";
            string objectif = "L'objectif de ce jeux est de sauver la princesse sans mourir et sans ce faire voir";
            
            return $"{presentation}\n{objectif}";
        }

        private static void Quitter(string message="Appuyer sur un touche pour quitter")
        {
            Console.WriteLine($"\n{message}");
            Console.ReadLine();
            Environment.Exit(0);
        }

    }

}