using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovar
{
    internal class Clovek
    {
        string jmeno;
        public int penezenka { get; private set; }
        int pocetPiv;
        Random rnd = new Random();
        public IDictionary<string, int> druhVypitePiva = new Dictionary<string, int> {
            {"11°", 0},
            {"12°", 0 },
            {"14°", 0 }            
        };
        public Clovek(string jmeno) { 
            this.jmeno = jmeno;
            penezenka = rnd.Next(400, 5000);
            pocetPiv = 0;
        }
        //TODO metoda na utratu
        //TODO metoda na vypitiPiva
    }
}
