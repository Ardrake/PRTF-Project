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

        public void AjouterConservateurs(string idconservateur, string prenomconservateur, string nomconservateur)
        {
            Conservateur nouvconsevateur = new Conservateur(idconservateur, prenomconservateur, nomconservateur);
            TableauConservateurs.Add(nouvconsevateur);
            Console.WriteLine("Le Conservateur ID: {0}, Prenom: {1}, Nom: {2} a été ajouté au système", nouvconsevateur.ID, nouvconsevateur.Prenom, nouvconsevateur.Nom);
            Console.ReadKey();
        }

        public void AfficherConservateur()
        {
            Console.WriteLine("Liste des Conservateur");
            foreach (Conservateur c in this.TableauConservateurs)
            {
                Console.WriteLine(c.ToString());
            }
            Console.ReadKey();
        }

        public void AjouterArtiste()
        {
            Console.WriteLine("Methode AjouterArtiste");
            Console.ReadKey();
        }

        public void AfficherArtiste()
        {
            Console.WriteLine("Methode AfficherArtiste");
            Console.ReadKey();
        }



    }
}
