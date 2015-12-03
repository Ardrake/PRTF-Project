using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Classe des oeuvres
/// </summary>
namespace SGI
{
    public class Oeuvre
    {
        private string idOeuvre = "";
        private string titre;
        private int annee;
        private double prix = 0;
        private double valeurEstimee;
        private string idArtiste;
        private string etat = "";


        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }


        public int Annee
        {
            get { return annee; }
            set { annee = value; }
        }


        public double ValeurEstimee
        {
            get { return valeurEstimee; }
            set { valeurEstimee = value; }
        }


        public string IdArtiste
        {
            get { return idArtiste; }
            set { idArtiste = value; }
        }


        public Oeuvre()
        {
        }


        public Oeuvre(string idOeuvre, string titre, int annee, double valeurEstimee, string idArtiste)
        {
            etat = "E";
            prix = 0;
        }


        public double CalculerComm(double PrixVente, Conservateur vendeur)
        {
            double tauxDeCommission = vendeur.Commission;
            double commissionPayer = 0;

            if (PrixVente > 0)
            {
                commissionPayer = PrixVente * tauxDeCommission;
            }
            
            return commissionPayer;
        }

                
        public override string ToString()
        {
            string infoOeuvre = "\nID: " + idOeuvre + " \nTitre :" + titre + "Année: " + annee + "\nValeur Estimée: " + valeurEstimee;

            return infoOeuvre;
        }
    }
}
