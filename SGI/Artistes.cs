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


        public Artiste TrouveParID(string id)
        {
            Artiste retour = null;
            foreach (Artiste c in this)
            {
                if (c.ID == id)
                {
                    retour = c;
                    break;
                }
            }
            return retour;
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


