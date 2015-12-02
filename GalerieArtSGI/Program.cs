using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGI;

namespace GalerieArtSGI
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Galerie gal = new Galerie();

            int valeurChoix = 0;

            while (valeurChoix != 8)
            {
                valeurChoix = afficheMenu();

                if (valeurChoix == 8)
                    return;

                //Prendre action / loadé le module correspondant
                if (valeurChoix == 1)  // Option 1 - Ajouter conservateur
                {
                    gal.AjouterConservateurs();
                }
                else if (valeurChoix == 2) // Option 2 - Ajouter artiste
                {
                    gal.AjouterArtiste();
                }
                else if (valeurChoix == 3) // Option 3 -Ajouter oeuvre
                {
                    //gal.AjouterOeuvre();
                }
                else if (valeurChoix == 4) // Option 4 - Afficher conservateur
                {
                    gal.AfficherConservateur();
                }
                else if (valeurChoix == 5) // Option 5 - Afficher artiste
                {
                    gal.AfficherArtiste();
                    
                }
                else if (valeurChoix == 6) // Options 6 - Afficher oeuvre
                {
                    //gal.AfficherOeuvre();
                }
                else if (valeurChoix == 7) // Options 7 - Vendre œuvre
                {
                    //gal.VendreOeuvre();
                }


            }
        }

        // Termine le menu
        /// <summary>
        /// Affiche un menu
        /// </summary>
        /// <returns>Retourne un Int representant le choix du l'usager</returns>
        private static int afficheMenu()
            {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("- Système de gallerie Informatisé -");
            Console.ResetColor();
            Console.WriteLine("- - - - - - - - - - - - - - - - - ");
            Console.WriteLine("1 - Ajouter conservateur");
            Console.WriteLine("2 - Ajouter artiste");
            Console.WriteLine("3 - Ajouter oeuvre");
            Console.WriteLine("4 - Afficher conservateur");
            Console.WriteLine("5 - Afficher artiste");
            Console.WriteLine("6 - Afficher oeuvre");
            Console.WriteLine("7 - Vendre oeuvre");
            Console.WriteLine("8 - Quitter");
            Console.WriteLine("- - - - - - - - - - - - - - - - - ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SVP entrez votre selection (nombre) et appuyer sur enter");
            Console.ResetColor();

            //recupéré la valeur
            int valeurChoix;

            try
            {
                // recup le nombre et faire un parse du resultat
                valeurChoix = int.Parse(Console.ReadLine());
                return valeurChoix;
            }
            catch
            {
                //erreur dans le nombre
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erreur SVP Sélectionnez un nombre");
                Console.ReadKey();
                Console.ResetColor();
                return 9;
            }
    }



    }
 }

