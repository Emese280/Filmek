using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Film> filmek = new List<Film>()
           {
            new Film("Gladiátor",5000),
            new Film("Vasember",3500),
            new AkcioFilm("Terminátor",4500,16),
            new AkcioFilm("Rambo",3000,18),
          };

            Film legolcsobb = filmek.OrderBy(x => x.Ar).First();

            if (legolcsobb is AkcioFilm a)
            {
                Console.WriteLine(a.ToString());
            }
            else
            {
                Console.WriteLine("Nem akciófilm típusú");
                Console.WriteLine(legolcsobb.ToString());
            }




        }
    }
}
