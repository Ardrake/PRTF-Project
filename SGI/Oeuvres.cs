using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI
{
    public class Oeuvres : CollectionBase
    {

        public void Add(Oeuvre NewOeuvre)
        {
            List.Add(NewOeuvre);
        }

        // Constructeur par défaut
        public Oeuvres()
        {
        }


        public Oeuvre TrouveParID(string id)
        {
            Oeuvre retour = null;
            foreach (Oeuvre c in this)
            {
                if (c.ID == id)
                {
                    retour = c;
                    break;
                }
            }
            return retour;
        }

        public Oeuvre this[int OeuvreIndex]
        {
            get { return (Oeuvre)List[OeuvreIndex]; }
            set { List[OeuvreIndex] = value; }
        }

    }
}
