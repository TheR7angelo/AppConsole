//using System;

namespace AppConsole
{
    /*
     *  1. Le joueur est dans une foret. Il peut aller à l'est ou à l'ouest.
     *      1.1 Si le choix est est alors il tombe et à perdu
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
        private static void Main(string[] args)
        {
            //string dir;
            Console.WriteLine(Introduction());

            if (Chapitre_1() == false)
            {
                Quitter("Vous etes tombé dans une failaise\nVous avez perdu");
            }

            Quitter("La partie est terminé");

        }

        private static bool Chapitre_1()
        {
            string direction = "";
            string[] choix = {"ouest", "est"};

            Console.WriteLine("Vous etes dans une foret et vous avez deux chemin devant vous");
            Console.WriteLine("Vous pouvez prendre le chemin en direction de l'ouest ou bien en direction de l'est");
            Console.WriteLine("Quelle chemin allez vous choisir ?");
            
            while (choix.Contains(direction) == false)
            {
                direction = Console.ReadLine();
                if (choix.Contains(direction) == false)
                {
                    Console.WriteLine("Mauvaise rentrer de texte veuiller écrire sois \"ouest\", \"est\"");
                }
            }
            
            if (direction == "est")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private static bool Chapitre_2()
        {
            return true;
        }
        
        private static bool Chapitre_3()
        {
            return true;
        }

        private static string Introduction()
        {
            
            const string presentation = "Bienvenue dans ce jeux \"AppConsole\".\n";
            const string objectif = "L'objectif de ce jeux est de sauver la princesse sans mourir et sans ce faire voir";
            
            return $"{Titre()}\n{presentation}\n{objectif}\n";
        }

        private static string Titre()
        {
            // https://patorjk.com/software/taag/#p=testall&f=Blocks&t=AppConsole

            const string text = @"
                        _____                      _      
     /\                / ____|                    | |     
    /  \   _ __  _ __ | |     ___  _ __  ___  ___ | | ___ 
   / /\ \ | '_ \| '_ \| |    / _ \| '_ \/ __|/ _ \| |/ _ \
  / ____ \| |_) | |_) | |___| (_) | | | \__ \ (_) | |  __/
 /_/    \_\ .__/| .__/ \_____\___/|_| |_|___/\___/|_|\___|
          | |   | |                                       
          |_|   |_|                                       
";

            return text;

        }

        private static void Quitter(string message="")
        {
            Console.WriteLine($"\n{message}\n\nAppuyer sur \"Enter\" pour quitter");
            Console.ReadLine();
            Environment.Exit(0);
        }

    }
}