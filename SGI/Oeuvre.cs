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
        private int prix = 0;
        private int valeurEstimee = 0;
        private string idArtiste = "";
        private string etat = "E";


        public string ID
        {
            get { return id; }
            set { ID = id; }
        }

        public string Titre
        {
            get { return titre; }
            set { Titre = titre; }
        }


        public int Annee
        {
            get { return annee; }
            set { Annee = annee; }
        }


        public int ValeurEstimee
        {
            get { return valeurEstimee; }
            set { ValeurEstimee = valeurEstimee; }
        }


        public string IdArtiste
        {
            get { return idArtiste; }
            set { IdArtiste = idArtiste; }
        }

        public int Prix
        {
            get { return prix; }
            set { Prix = prix; }
        }

        public string Etat
        {
            get { return etat; }
            set { Etat = etat; }
        }


        public Oeuvre()
        {
        }


        public Oeuvre(string idoeuvre, string titreoeuvre, int anneeoeuvre, int valeurEstimeeoeuvre, string idArtisteoeuvre)
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
