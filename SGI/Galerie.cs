using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI
{
    /// <summary>
    /// Classe chef de projet et point d'entré dans le DLL
    /// </summary>
    public class Galerie
    {
        public Conservateurs TableauConservateurs = new Conservateurs();
        public Artistes TableauArtistes = new Artistes();
        public Oeuvres TableauOeuvres = new Oeuvres();


        public void AjouterConservateurs(string idconservateur, string prenomconservateur, string nomconservateur, string modetest)
        {
            Conservateur nouvconsevateur = new Conservateur(idconservateur, prenomconservateur, nomconservateur);
            TableauConservateurs.Add(nouvconsevateur);
            Console.WriteLine("Le Conservateur ID: {0}, Prenom: {1}, Nom: {2} a été ajouté au système", nouvconsevateur.ID, nouvconsevateur.Prenom, nouvconsevateur.Nom);
            if (modetest == "N")
            {
                Console.ReadKey();
            }
        }


        public void AfficherConservateur()
        {
            Console.WriteLine("Liste des Conservateur");
            if (TableauConservateurs.Count > 0)
            {
                foreach (Conservateur c in TableauConservateurs)
                {
                    Console.WriteLine(c.ToString());
                }
            }
            else Console.WriteLine("Aucun Conservateur dans la collection");
            Console.ReadKey();
        }


        public bool TrouverConservateur(string idConservateur, bool verbose)
        {
            bool trouveRecord = false;
            string retourConservateur = "";
            foreach (Conservateur c in TableauConservateurs)
            {
                if (c.ID == idConservateur)
                {
                    trouveRecord = true;
                    retourConservateur = c.Prenom + " " + c.Nom;
                }
            }

            if (trouveRecord && verbose)
            {
                Console.WriteLine(retourConservateur);
            }
            if (!trouveRecord && verbose)
            {
                Console.WriteLine("Conservateur ID: {0}, pas trouvé", idConservateur);
            }

            return trouveRecord;
        }


        public void AjouterArtiste(string idartiste, string prenomartiste, string nomartiste, string idconservateur, string modetest)
        {
            Artiste nouvartiste = new Artiste(idartiste, prenomartiste, nomartiste, idconservateur);
            TableauArtistes.Add(nouvartiste);
            Console.WriteLine("L'Artiste ID: {0}, Prenom: {1}, Nom: {2} a été ajouté au système", nouvartiste.ID, nouvartiste.Prenom, nouvartiste.Nom);
            if (modetest == "N")
            {
                Console.ReadKey();
            }
        }
        

        public void AfficherArtiste()
        {
            Console.WriteLine("Liste des Artistes");
            if (TableauArtistes.Count > 0)
            {
                foreach (Artiste c in TableauArtistes)
                {
                    Console.WriteLine(c.ToString());
                }
            }
            else Console.WriteLine("Aucun Artiste dans la collection");
            Console.ReadKey();
        }


        public void AjouterOeuvre(string idoeuvre, string titreoeuvre,  int anneeoeuvre, int valeuroeuvre, string idartiste, string modetest)
        {
            //string idOeuvre, string titre, int annee, double valeurEstimee, string idArtiste
            Oeuvre nouvelleOeuvre = new Oeuvre(idoeuvre, titreoeuvre, anneeoeuvre, valeuroeuvre, idartiste);
            TableauOeuvres.Add(nouvelleOeuvre);
            Console.WriteLine("L'artiste {0} a été assigné comme l'auteur de cette oeuvre", idartiste);
            Console.WriteLine("L'ouvre a été créer en {0} et a une valeur estimé de : {1}", anneeoeuvre, valeuroeuvre);
            Console.WriteLine("Enregistrement de l'oeuvre - code: {0} - {1} à été effectuer", idoeuvre, titreoeuvre);
            if (modetest == "N")
            {
                Console.ReadKey();
            }
        }


        public void AfficherOeuvre()
        {
            Console.WriteLine("Liste des Oeuvres");
            if (TableauOeuvres.Count > 0)
            {
                foreach (Oeuvre o in TableauOeuvres)
                {
                    Console.WriteLine(o.ToString());
                }
            }
            else Console.WriteLine("Aucune Ouevre dans la collection");
            Console.ReadKey();
        }

    }
}
