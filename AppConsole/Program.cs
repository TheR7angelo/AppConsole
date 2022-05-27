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
     *      3.1 Si porte droite = Il tombe sur des des gardes Game Over.
     *      3.2 Si gauche = Il trouve la princesse WINNE
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
            const string perdu = "Vous avez perdu";
            //string dir;
            Console.WriteLine(Introduction());

            if (Chapitre_1() == false)
            {
                Quitter($"Vous etes tombé dans une failaise.\n{perdu}");
            }

            if (Chapitre_2() == false)
            {
                Quitter($"Un garde vous a vue.\n{perdu}");
            }

            if (Chapitre_3() == false)
            {
                Quitter($"La porte que vous avez ouvert vous à menez tout droit dans la salle de repos des gardes et malheuresement pour vous des gardes étais en train de jouer au carte.\n{perdu}");
            }

            Quitter("Vous avez trouver la princesse, vous avez gagner !!!");

        }

        private static bool Chapitre_1()
        {
            string[] choix = {"ouest", "est"};

            Console.WriteLine("\nVous etes dans une foret et vous avez deux chemin devant vous");
            Console.WriteLine("Vous pouvez prendre le chemin en direction de l'ouest ou bien en direction de l'est");
            Console.WriteLine("Quelle chemin allez vous choisir ?");

            return Solution_possible(choix, "est");
        }

        private static bool Chapitre_2()
        {
            string[] choix = {"porte", "fenetre"};

            Console.WriteLine("\nVous arrivez devant le chateau mais comment allez vous rentrer ?");
            Console.WriteLine("Vous pouvez renter par la porte ou bien la fenetre");
            Console.WriteLine("Quelle chemin allez vous choisir ?");

            return Solution_possible(choix, "fenetre");
        }
        
        private static bool Chapitre_3()
        {
            string[] choix = {"gauche", "droite"};

            Console.WriteLine("\nVous arrivez dans un couloirs mais il y a deux portes ?");
            Console.WriteLine("Vous pouvez ouvrir une seule porte, celle de gauche ou celle de droite.");
            Console.WriteLine("Quelle porte allez vous choisir ?");

            return Solution_possible(choix, "gauche");

        }

        private static bool Solution_possible(string[] choix, string reponse)
        {
            string tentative = "";
            string possible = String.Join(", ", choix);
            while (choix.Contains(tentative) == false)
            {
                tentative = Console.ReadLine().ToLower();
                if (choix.Contains(tentative) == false)
                {
                    Console.WriteLine($"Mauvaise rentrer de texte veuillez écrire:\n{possible}");
                }
            }

            if (tentative == reponse)
            {
                return true;
            }

            return false;
        } 
        
        private static bool Gagner()
        {
            const string message = "Vous avez récuperer la princesse";
            Console.WriteLine(message);
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