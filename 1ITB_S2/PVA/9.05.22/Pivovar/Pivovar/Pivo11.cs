using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovar
{
    internal class Pivo11 : Pivo
    {
        public override void Recept() {
            Voda = 400;
            Chmel = 300;
            Slad = 200;
            Kvasnice = 150;
        }


        static void receptPivo11(int chmel, int voda , int pivo11, )
        {
            //TODO předělat
            int voda 1;
            int chmel 10;
            if (sklad.chmel > chmel && sklad.voda > voda)
            {
                sklad.voda  -  1;
                sklad.chmel - 10;
                pocetPiv.pivo11 += 1;
                hospoda.kasa - (cenaChmel * chmel);
                hospoda.kasa - (cenaVoda*voda) 
            }
        }
    }
}
