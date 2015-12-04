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
        public static string modeTest = "O";
        static Galerie gal = new Galerie();

        static void Main(string[] args)
        {
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
                    gal.AjouterConservateurs(infoConservateur[0], infoConservateur[1], infoConservateur[2], modeTest);
                }
                else if (valeurChoix == 2) // Option 2 - Ajouter artiste
                {
                    string[] infoArtiste = NouvelArtiste();
                    if (infoArtiste.Count() > 0)
                    {
                        gal.AjouterArtiste(infoArtiste[0], infoArtiste[1], infoArtiste[2], infoArtiste[3], modeTest);
                    }
                    else
                    {
                        Console.WriteLine("Artiste non sauvegarder");
                        Console.ReadKey();
                    }
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
                    gal.AfficherArtiste();
                }
                else if (valeurChoix == 6) // Options 6 - Afficher oeuvre
                {
                    gal.AfficherOeuvre();
                }
                else if (valeurChoix == 7) // Options 7 - Vendre œuvre
                {
                    VendreUneOeuvre();
                    //gal.VendreOeuvre();
                }
                else if (valeurChoix == 9) // Options 9 - Load test data
                {
                    LoadDataTest();
                    valeurChoix = 0;
                }
            }
        }


        private static void LoadDataTest()
        {
            for (int x = 0; x < DataTest.listConservateur.GetLength(0); x++)
            {
                string LeCode = DataTest.listConservateur[x, 0];
                string lePrenom = DataTest.listConservateur[x, 1];
                string leNom = DataTest.listConservateur[x, 2];
                gal.AjouterConservateurs(LeCode, lePrenom, leNom, modeTest);
            }
            for (int x = 0; x < DataTest.listArtiste.GetLength(0); x++)
            {
                string LeCode = DataTest.listArtiste[x, 0];
                string lePrenom = DataTest.listArtiste[x, 1];
                string leNom = DataTest.listArtiste[x, 2];
                string leConservateur = DataTest.listArtiste[x, 3];
                gal.AjouterArtiste(LeCode, lePrenom, leNom, leConservateur, modeTest);
            }

            for (int x = 0; x < DataTest.listOeuvre.GetLength(0); x++)
            {
                string LeCode = (string)DataTest.listOeuvre[x, 0];
                string leTitre = (string)DataTest.listOeuvre[x, 1];
                string leIdArtiste = (string)DataTest.listOeuvre[x, 2];
                int    leAnnee = (int)DataTest.listOeuvre[x, 3];
                int    leValeur = (int)DataTest.listOeuvre[x, 4];
                //double lePrix = double.Parse(DataTest.listOeuvre[x, 5]);
                //string leEtat = DataTest.listOeuvre[x, 6];
                gal.AjouterOeuvre(LeCode, leTitre, leAnnee, leValeur, leIdArtiste, modeTest);
            }
            Console.ReadKey();
            Console.WriteLine("Le data test a été chargé");

            modeTest = "N";
        }


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
            if (modeTest == "O")
            {
                Console.WriteLine("9 - Load Data Test");
            }
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
                return 0;
            }
        }


        /// <summary>
        /// Fonction pour ajouter Artiste dans la base de donnée
        /// </summary>
        private static string[] NouvelArtiste()
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
            string conservateurID = "";
            bool codeValid = false;
            bool nomValid = false;
            bool prenomValid = false;
            bool idValid = false;

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
                Console.WriteLine("Entrez le ID du conservateur");
                conservateurID = Console.ReadLine();
                if (validCodeLongueur(conservateurID, 5, false))
                {
                    // rajout ici recup nom conservateur et valid que le ID conservateur est valide
                    if (gal.TrouverConservateur(conservateurID, false))
                    {
                        idValid = true;
                    }


                    if (!idValid)
                    {
                        Console.WriteLine("Conservateur non trouvé voulez vous re-essayer? oui ou non = O/N");
                        string sortirconservateur = Console.ReadLine();
                        if (sortirconservateur != "O")
                        {
                            break;
                        }
                    }


                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ID invalid - doit avoir 5 characteres ");
                    Console.ResetColor();
                }
            } while (idValid == false);

            if (!idValid)
            {
                return new string[] { }; ;
            }

            return new string[] { artisteCode, artistePrenom, artisteNom, conservateurID };
            
            
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

