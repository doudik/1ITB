using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinar_Reseni
{
    internal class Veterinar
    {
        static Random rnd = new Random();
        public static void ZkontrolujZviratko(Mazlicek m, Clovek c) {
            Console.Clear();
            if (rnd.Next(0, 2) == 0)
            {
                Console.WriteLine("Tvoje zvířátko bohužel umřelo!");
                c.mazlicci.Remove(m);
            }
            else {
                int castka = rnd.Next(500, 2500);
                
                if (c.zustatek < castka)
                {
                    Console.WriteLine("Zvířátko {0} ti bylo odebráno!", m.prezdivka);
                    Policista.OdeberZviratko(m, c);
                }
                else {
                    Console.WriteLine("Byl ti odebrán poplatek ve výši: {0}Kč", castka);
                    c.zustatek -= castka;
                }
                
            }

        }
    }
}
