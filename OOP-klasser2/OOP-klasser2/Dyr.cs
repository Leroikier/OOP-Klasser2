using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_klasser2
{
    class Dyr
    {
        //Default constructor /(Snippet)
        public Dyr(string artsnavn, int aar)
        {
            Art = artsnavn;
            Alder = aar;
        }

        public Dyr()
            {
            }


        //Oprettelse af Property/egenskab altid stort forbokstav
        public string Art { get; set; }

        //propfull
        //Private field/felt og tilhørende public property
        private int alder;

        public int Alder
        {
            //Get set metode til og tjekke op på data der indtastet
            get { return alder; }
            set
            {
                //Hvis "alder" value er størrende end 0 og samtidig mindre end 15 eller = 15
                if (value > 0 && value <= 15)
                {
                    alder = value;
                }
                //Ellers throw en exception
                else
                {
                    throw new Exception("Fejl : Dyret er for gammel \nFejl : Kun dyr tilladt under 15 år");
                }
            }
        }
    }
}
