using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovar
{
    internal class Pivo14 : Sklad
    {
        static void receptPivo14(int chmel, int voda, int pivo14, )
        {

            int voda 3;
            int chmel 60;
            if (sklad.chmel > chmel && sklad.voda > voda)
            {
                sklad.voda - voda;
                sklad.chmel - chmel;
                pocetPiv.pivo14 += 1;
                hospoda.kasa - (cenaChmel * chmel);
                hospoda.kasa - (cenaVoda * voda)
            }
        }
    }
}
