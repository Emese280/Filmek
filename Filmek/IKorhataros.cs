using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek
{
    interface IKorhataros
    {
        int Korhatar { get; } //jellemző
        int Buntetes(int eletkor);  //metódus

    }
}
