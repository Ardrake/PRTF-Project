using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGI;

namespace GalerieArtSGI
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Galerie gal = new Galerie();

            gal.AfficherConservateur();
            gal.AjouterConservateurs();

        }
    }
}
