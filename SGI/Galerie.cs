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

        public void AjouterConservateurs()
        {
            Console.WriteLine("Methode AjouterConservateur");
            Console.ReadKey();
        }

        public void AfficherConservateur()
        {
            Console.WriteLine("Methode AfficherConservateur");
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
