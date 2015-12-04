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
        private string id = "";
        private string titre = "";
        private int annee = 1700;
        private double prix = 0;
        private double valeurEstimee = 0;
        private string idArtiste = "";
        private string etat = "E";


        public string ID
        {
            get { return id; }
        }

        public string Titre
        {
            get { return titre; }
        }


        public int Annee
        {
            get { return annee; }
        }


        public double ValeurEstimee
        {
            get { return valeurEstimee; }
        }


        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public string Etat
        {
            get { return etat; }
            set { etat = value; }
        }


        public Oeuvre()
        {
        }


        public Oeuvre(string idoeuvre, string titreoeuvre, int anneeoeuvre, double valeurEstimeeoeuvre, string idArtisteoeuvre)
        {
            id = idoeuvre;
            titre = titreoeuvre;
            annee = anneeoeuvre;
            valeurEstimee = valeurEstimeeoeuvre;
            idArtiste = idArtisteoeuvre;
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
            string infoOeuvre = "";
            string status = "Exposée";
            if (etat == "V")
            {
                status = "Vendu";
            }
            else if (etat == "N")
            {
                status = "Entreposée";
            }

            if (etat == "V")
            {
                infoOeuvre = "\nID: " + id + "\n Titre :" + titre + "\n Année: " + annee + " - Statut: " + status + "\n Prix de vente: " + prix;
            }
            else
            {
                infoOeuvre = "\nID: " + id + "\n Titre :" + titre + "\n Année: " + annee + " - Statut: " + status + "\n Valeur Estimée: " + valeurEstimee;
            }
            

            return infoOeuvre;
        }
    }
}
