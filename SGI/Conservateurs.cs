using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SGI
{
    /// <summary>
    /// Indexeurs pour la collections des Conservateurs
    /// </summary>
    public class Conservateurs : CollectionBase
    {
        public void Add(Conservateur NewConservateur)
        {
            List.Add(NewConservateur);
        }

        // Constructeur par défaut
        public Conservateurs()
        {
        }

        public Conservateur this[int ConservateurIndex]
        {
            get { return (Conservateur)List[ConservateurIndex]; }
            set { List[ConservateurIndex] = value; }
        }

    }
}
