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

        public Artiste()
        {
        }

        public Artiste(string iDArtiste, string PrenomArtiste, string NomArtiste) : base(iDArtiste, PrenomArtiste, NomArtiste)
        {
            
        }

        public override string ToString()
        {
            string infoConservateur = "\nID: " + base.ID + " \nNom :" + base.Prenom + " " + base.Nom;

            return infoConservateur;
        }


    }
}





