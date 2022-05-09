using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovar
{


    internal class Pivo : Sklad
    {
        public int pivo11 { get; set; }
        public int pivo12 { get; set; }
        public int pivo14 { get; set; }
        
        public virtual void Recept() {
            Chmel = 200;
            Voda = 500;
            Kvasnice = 150;
            Slad = 190;
            //TODO recept pro výrobu piva  ☺
            //TODO odebrat suroviny ze skladu ☻
            //TODO přidat pivo ♀ 
            ////////// je to v jednotlivých pivech
        }
        

    }

}