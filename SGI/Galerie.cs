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

        public void AjouterArtiste(string idartiste, string idconservateur, string prenomconservateur, string nomconservateur, string modetest)
        {

            Artiste nouvartiste = new Artiste(idartiste, prenomconservateur, nomconservateur, idconservateur);
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



    }
}
