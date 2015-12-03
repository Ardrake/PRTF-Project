using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI
{
    public class Artistes : CollectionBase
    {
        public void Add(Artiste NewArtiste)
        {
            List.Add(NewArtiste);
        }


        // Constructeur par défaut
        public Artistes()
        {
        }


        public Artiste this[int ArtisteIndex]
        {
            get { return (Artiste)List[ArtisteIndex]; }
            set { List[ArtisteIndex] = value; }
        }

    }
}


