using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Pivovar
{
    internal class Hospoda
    {
        int kasa = 100000;
        public int Kasa { get { return kasa; } private set { kasa = value; } }
        public int pocetLidi { get; private set; }
        int najem;
        IDictionary<string, int> cenaPivsona = new Dictionary<string, int> {
            {"11°", 25},
            {"12°", 30},
            {"14°", 40 }
        };
        IDictionary<string, int> kolikMamPivka = new Dictionary<string, int> {
            {"11°", 0},
            {"12°", 0},
            {"14°", 0}
        };

        void nakupPiva()
        {
            if (kolikMamPivka["11°"] < 5 && kasa >= 100 * Pivovar.cenaPiva["11°"])
            {
                kolikMamPivka["11°"] += 100;
                kasa -= 100 * Pivovar.cenaPiva["11°"];
                pivo11["11°"] -= 100;
            }
            if (pocet12 < 5 && kasa >= 100 * Pivovar.cenaPiva["12°"])
            {
                kolikMamPivka["12°"] += 100;
                kasa -= 100 * Pivovar.cenaPiva["12°"];
                pivo12 -= 100;
            }
            if (pocet14 < 5 && kasa >= 100 * Pivovar.cenaPiva["14°"])
            {
                kolikMamPivka["14°"] += 100;
                kasa -= 100 * Pivovar.cenaPiva["14°"];
                pivo14 -= 100;
            }
        }

        void den()
        {
            Random rnd = new Random();
            pocetLidi = rnd.Next(0, 151);
            for (int i = 0; i < pocetLidi; i++)
            {
                nakupPivaNaCloveka();

                if (pocetLidi == 151)
                {
                    rvacka();
                }

            }
        }

        void rvacka()
        {
            string[] rasa = { "žid", "černoch", "běloch", "asiat", "nacista", "LGBT", "neběloch" };

            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                int sance = rnd(0, rasa.length);

            }


        }

        void nakupPivaNaCloveka()
        {
            int druh;
            Random rnd = new Random();
            int druhPiva = rnd.Next(0, 2 + 1);
            int pocet = rnd.Next(1, 50 + 1);
            
            switch  (druhPiva)
            {
                case 0:
                        druh = cenaPiva11;
                    pocetPiva11 -= 1;
                    break;
                    case 1:
                        druh = cenaPiva12;
                    pocetPiva12 -= 1;
                    break;
                    default:
                        druh = cenaPiva14;
                    pocetPiva14 -= 1;
                    break;
            }
            kasa += druh * pocet;
        }

        void najem() // pracuje se (Martin)
        {
            new random = new random;

        }
    }
}