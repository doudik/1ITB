using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovar
{
    internal class Sklad
    {
        static int chmel = 50000;
        public static int Chmel { get { return chmel; } private set { chmel = value; } }
        static int voda = 50000;
        public static int Voda { get { return voda; } private set { voda = value; } }
        static int slad = 50000;
        public static int Slad {get { return slad;} private set { slad = value; } }
        static int kvasnice = 50000;
        public static int Kvasnice { get { return kvasnice; } private set { kvasnice = value; } }
        public static int pivo { get; private set; }

        public static void PridejPivo(int c, int v, int s, int k)
        {
            pivo++;
            OdeberSuroviny(c, v, s ,k);
        }
        public static void OdeberPivo() {
            pivo--;
        }

        private static void OdeberSuroviny(int c, int v, int s, int k)
        {
            chmel -= c;
            voda -= v;
            slad -= s;
            kvasnice -= k;
        }
    }
}
