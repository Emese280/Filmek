using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek
{
    class AkcioFilm:Film,IKorhataros
    {
        int korhatar;
        public AkcioFilm(string cim, int ar, int korhatar):base(cim, ar)
        {
            this.korhatar = korhatar;
        }

        public override void Ertekel(int ertek)
        {
            if (ertek!=5)
            {
                base.Ertekel(ertek);
            }
            
        }
        public int Korhatar => korhatar;

        public int Buntetes(int eletkor)
        {
            return (Korhatar - eletkor) * Ar;
        }

        public override string ToString()
        {
            return base.ToString()+ $" Korhatár: {Korhatar}";
        }
    }
}
