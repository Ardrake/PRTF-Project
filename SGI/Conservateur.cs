using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI
{
    /// <summary>
    ///  Classe Conservateur - hérite de Personne
    /// </summary>
    public class Conservateur : Personne
    {

        private double commission;
        const double TauxDeCommission = 0.10;

        public double Commission
        { 
            get { return commission; }
            set { commission = value; }
        }

        public Conservateur()
        {
        }

        public Conservateur(string iDConservateur, string PrenomConservateur, string NomConservateur) : base(iDConservateur, PrenomConservateur, NomConservateur)
        {
            commission = 0;
        }

        public override string ToString()
        {
            string infoConservateur = "\nID: " + base.ID + " \nNom :" + base.Prenom + " " + base.Nom + "\nCommission payé: " + commission;

            return infoConservateur;
        }

        public void SetComm(double PrixVente)
        {
            double commissionPayer;

            if (PrixVente > 0)
            {
                commissionPayer = PrixVente * TauxDeCommission;
                commission += commissionPayer;
            }
        }
    }
}
