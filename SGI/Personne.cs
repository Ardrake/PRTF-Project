using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI
{
    /// <summary>
    /// Classe abstraite pour Personne
    /// </summary>
    public abstract class Personne
    {
        private string id = "";
        private string prenom = "";
        private string nom = "";

        public string ID
        {
            get { return id; }
            set { ID = id; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public Personne()
        {
        }

        public Personne(string IdPersonne, string PrenomPersonne, string NomPersonne)
        {
            id = IdPersonne;
            prenom = PrenomPersonne;
            nom = NomPersonne;
        }

        public override string ToString()
        {
            return id + " : " + prenom + " " + nom;
        }
    }
}
