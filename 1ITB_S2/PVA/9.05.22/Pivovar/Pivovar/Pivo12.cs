using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovar
{
    internal class Pivo12 : Sklad
    {
        static void receptPivo12(int chmel, int voda, int pivo12)
        {

            int voda 2;
            int chmel 20;
            if (sklad.chmel > chmel && sklad.voda > voda)
            {
                sklad.voda - voda;
                sklad.chmel - chmel;
                pocetPiv.pivo12 += 1;
                hospoda.kasa - (cenaChmel * chmel);
                hospoda.kasa - (cenaVoda * voda)
            }
        }
    }
}
