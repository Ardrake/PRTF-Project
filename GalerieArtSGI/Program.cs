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
            string modeTest = "O";
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
                    string[] infoConservateur = NouveauConservateur();
                    gal.AjouterConservateurs(infoConservateur[0], infoConservateur[1], infoConservateur[2]);
                                    }
                else if (valeurChoix == 2) // Option 2 - Ajouter artiste
                {
                    NouvelArtiste();
                    gal.AjouterArtiste();
                }
                else if (valeurChoix == 3) // Option 3 -Ajouter oeuvre
                {
                    NouvelleOeuvre();
                    //gal.AjouterOeuvre();
                }
                else if (valeurChoix == 4) // Option 4 - Afficher conservateur
                {
                    gal.AfficherConservateur();
                }
                else if (valeurChoix == 5) // Option 5 - Afficher artiste
                {
                    AfficherLesArtistes();
                    gal.AfficherArtiste();
                    
                }
                else if (valeurChoix == 6) // Options 6 - Afficher oeuvre
                {
                    //gal.AfficherOeuvre();
                }
                else if (valeurChoix == 7) // Options 7 - Vendre œuvre
                {
                    VendreUneOeuvre();
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
            if 
            Console.WriteLine("9 - Load Data Test");

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

        /// <summary>
        /// Fonction pour ajouter Artiste dans la base de donnée
        /// </summary>
        private static string NouvelArtiste()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Ajouter Artiste");
            Console.ResetColor();
            Console.WriteLine("- - - - - - - - - - - -");
            Console.WriteLine("Entrez le code de l'artiste");
            // validation des codes/nom a faire 

            string artisteCode = "";
            string artisteNom = "";
            string artistePrenom = "";
            bool codeValid = false;
            bool nomValid = false;
            bool prenomValid = false;

            do
            {
                artisteCode = Console.ReadLine().ToUpper();

                if (validCodeLongueur(artisteCode, 5))
                {
                    codeValid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Code invalid - doit avoir 5 characteres ");
                    Console.WriteLine("Entrez le code de l'artiste");
                    Console.ResetColor();
                }
            } while (codeValid == false);

            do
            {
                Console.WriteLine("Entrez le Prénom de l'artiste");
                artistePrenom = Console.ReadLine();
                if (validCodeLongueur(artistePrenom, 40, false))
                {
                    prenomValid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Prénom invalid - doit avoir 40 characteres ");
                    Console.ResetColor();
                }
            } while (prenomValid == false);

            do
            {
                Console.WriteLine("Entrez le Nom de l'artiste");
                artisteNom = Console.ReadLine();
                if (validCodeLongueur(artisteNom, 40, false))
                {
                    nomValid = true;
                    Console.WriteLine("Enregistrement Artiste - code: {0}, Prénom: {1}, Nom: {2} est sauvegarder", artisteCode, artistePrenom, artisteNom);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Appuyer sur une touche pour continuer...");
                    Console.ResetColor();
                    Console.ReadKey();

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nom invalid - doit avoir 40 characteres ");
                    Console.ResetColor();
                }
            } while (nomValid == false);

            // retour enregistrement sauvegarder
            // Code pour sauvegarder le conservateur va ici ou retour vers fonction AjouterArtiste
            return artisteCode + " " + artisteNom;
        }

        private static void AfficherLesArtistes()
        {
            Console.WriteLine("Artiste présent au systme");
            Console.ReadKey();
        }

        /// <summary>
        /// Ajouter un oeuvre dans la BD
        /// </summary>
        private static void NouvelleOeuvre()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Ajouter Oeuvre");
            Console.ResetColor();
            Console.WriteLine("- - - - - - - - - - - -");
            Console.WriteLine("Entrez le code de l'Oeuvre");

            bool codeValid = false;
            bool nomValid = false;
            bool artisteValid = false;
            bool anneeValid = false;
            bool etatValid = false;
            bool valeurValid = false;
            string oeuvreArtisteCode = "";
            string oeuvreCode = "";
            string oeuvreNom = "";
            string etatOeuvre = "";
            string nonExiste = "";
            string anneOeuvre = "";
            decimal valeurOeuvre = 0;

            do
            {
                oeuvreCode = Console.ReadLine().ToUpper();

                if (validCodeLongueur(oeuvreCode, 5))
                {
                    codeValid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Code invalid - doit avoir 5 characteres ");
                    Console.WriteLine("Entrez le code de l'oeuvre");
                    Console.ResetColor();
                }

            } while (codeValid == false);

            do
            {
                Console.WriteLine("Entrez le nom de l'Oeuvre");
                oeuvreNom = Console.ReadLine();
                if (validCodeLongueur(oeuvreNom, 40, false))
                {
                    nomValid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nom invalid - doit avoir 40 characteres ");
                    Console.ResetColor();
                }
            } while (nomValid == false);

            do
            {
                Console.WriteLine("Entrez le code de l'artiste qui a fait cette oeuvre");
                oeuvreArtisteCode = Console.ReadLine().ToUpper();

                //
                // Fonction pour recupéré le nom de l'artiste avec son ID 
                nonExiste = "Non de l'artiste trouvé";
                //

                if (nonExiste != "")
                {
                    artisteValid = true;
                }
                else
                {
                    Console.WriteLine("Aucun artiste n'est associer a ce code");
                }
            } while (artisteValid == false);

            do
            {
                Console.WriteLine("Entrez l'année de realisation de l'oeuvre (AAAA)");
                anneOeuvre = Console.ReadLine();

                if (anneOeuvre.Length == 4)
                {
                    try
                    {
                        int a = Int32.Parse(anneOeuvre);
                        anneeValid = true;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("La date doit etre du format (AAAA)");
                }

            } while (anneeValid == false);

            do
            {
                Console.WriteLine("Entrez la valeur extimée de l'oeuvre");
                string saisieOeuvre = Console.ReadLine();

                if (anneOeuvre.Length == 4)
                {
                    try
                    {
                        valeurOeuvre = decimal.Parse(saisieOeuvre);
                        valeurValid = true;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Le format doit etre monetaire (0000.00");
                }

            } while (valeurValid == false);

            do
            {
                Console.WriteLine("Entrez le statut / Etat de l'oeuvre (E/V/N)");
                Console.WriteLine("E - Exposer | V - Vendu | Entreposer");
                etatOeuvre = Console.ReadLine();

                if (etatOeuvre.Length == 1)
                {
                    if (etatOeuvre == "E" || etatOeuvre == "V" || etatOeuvre == "N")
                    {
                        etatValid = true;
                    }

                }
                else
                {
                    Console.WriteLine("Le status doit etre (E/V/N)");
                }

            } while (etatValid == false);


            Console.WriteLine("L'artiste {0} a été assigné comme l'auteur de cette oeuvre", nonExiste);
            Console.WriteLine("L'ouvre a été créer en {0} et a une valeur estimé de : {1}", anneOeuvre, valeurOeuvre);
            Console.WriteLine("Enregistrement de l'oeuvre - code: {0} - {1} à été effectuer", oeuvreCode, oeuvreNom);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Appuyer sur une touche pour continuer...");
            Console.ResetColor();
            Console.ReadKey();
            // retour enregistrement sauvegarder
            // Code pour sauvegarder le conservateur va ici


        }

        /// <summary>
        /// Fonction pour vendre une oeuvre
        /// </summary>
        public static void VendreUneOeuvre()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Vendre oeuvre");
            Console.ResetColor();
            Console.WriteLine("- - - - - - - - - - - -");
            Console.WriteLine("Entrez le code de l'ouevre a vendre");

            bool codeValid = false;
            decimal PrixOeuvre = 0;
            string oeuvreCode = "";

            do
            {
                oeuvreCode = Console.ReadLine().ToUpper();

                if (oeuvreCode.Length == 5)
                {
                    codeValid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Code invalid - doit avoir 5 characteres ");
                    Console.WriteLine("Entrez le code de l'oeuvre");
                    Console.ResetColor();
                }
            } while (codeValid == false);

            Console.WriteLine("Entrez le prix de vente :");
            string saisiePrixOeuvre = Console.ReadLine();

            try
            {
                PrixOeuvre = decimal.Parse(saisiePrixOeuvre);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

            Console.WriteLine("Cette oeuvre a été vendu pour le prix de " + saisiePrixOeuvre);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Appuyer sur une touche pour continuer...");
            Console.ResetColor();
            Console.ReadKey();
        }

        /// <summary>
        /// Fonction pour ajouté un conservateur dans la base de donnée
        /// </summary>
        private static string[] NouveauConservateur()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Ajouter Conservateur");
            Console.ResetColor();
            Console.WriteLine("- - - - - - - - - - - -");

            string conservateurCode = "";
            string prenonconservateur = "";
            string conservateurNom = "";
            bool codeValid = false;
            bool nomValid = false;
            bool prenomValid = false;

            do
            {
                Console.WriteLine("Entrez le code du consevateur");
                conservateurCode = Console.ReadLine().ToUpper();

                if (validCodeLongueur(conservateurCode, 5)) // appelle la fonction qui valide la longueur
                {
                        codeValid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Code invalid - doit avoir 5 characteres ");
                    Console.WriteLine("Entrez le code du consevateur");
                    Console.ResetColor();
                }
            } while (codeValid == false);

            do
            {
                Console.WriteLine("Entrez le prenom du consevateur");
                prenonconservateur = Console.ReadLine();
                if (validCodeLongueur(prenonconservateur, 30, false))
                {
                    prenomValid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Prenom invalid - doit avoir 30 characteres ");
                    Console.ResetColor();
                }
            } while (prenomValid == false);

            do
            {
                Console.WriteLine("Entrez le nom du consevateur");
                conservateurNom = Console.ReadLine();
                if (validCodeLongueur(conservateurNom, 30, false))
                {
                    nomValid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nom invalid - doit avoir 30 characteres ");
                    Console.ResetColor();
                }
            } while (nomValid == false);

            return new string[] { conservateurCode, prenonconservateur, conservateurNom };
        }

        /// </summary>
        /// <param name="code">sting a evaluer la longueur</param>
        /// <param name="longueur">Longueur cible</param>
        /// <param name="egal">True pour egal / False pour egale ou plus petit que</param>
        /// <returns></returns>
        private static bool validCodeLongueur(string code, int longueur, bool egal = true)
        {
            if (egal == true)
            {
                if (code.Length == longueur)
                {
                    return true;
                }
            }
            else if (egal == false)
            {
                if (code.Length <= longueur)
                {
                    return true;
                }
            }
            return false;
        }

    }
}

