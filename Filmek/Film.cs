using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek
{
    class Film
    {
        public string Cim { get; private set; }
        public int Ar{ get; private set; }

        private List<int> ertekelesek;
        public Film(string cim, int ar)
        {
            Cim = cim;
            Ar = ar;
            ertekelesek = new List<int>();
        }
        public virtual void Ertekel(int ertek)
        {
            if (ertekelesek.Count>10)
            {
                throw new Exception($"{this},nem lehet több értékelésta adni.");
            }
            ertekelesek.Add(ertek);
        }

        public double Atlag
        {
            get 
            {
                if (ertekelesek.Count==0)
                {
                    throw new Exception($"{this}, nincs még értékelés");
                }
                return ertekelesek.Average();
            }
        }

        public override string ToString()
        {
            return $"Cim: {Cim}, Ar: {Ar}";
        }

    }
}
