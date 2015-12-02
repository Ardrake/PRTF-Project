using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SGI
{
    public class Artiste : Personne
    {

        private string idConservateur;

        public string IDConservateur
        {
            get { return idConservateur; }
            set { idConservateur = value; }
        }

                public Artiste()
        {
        }

        public Artiste(string iDArtiste, string PrenomArtiste, string NomArtiste, string idDuConservateur) : base(iDArtiste, PrenomArtiste, NomArtiste)
        {
            idConservateur = idDuConservateur;
        }

        public override string ToString()
        {
            string infoConservateur = "\nID: " + base.ID + " \nNom :" + base.Prenom + " " + base.Nom;

            return infoConservateur;
        }


    }
}





