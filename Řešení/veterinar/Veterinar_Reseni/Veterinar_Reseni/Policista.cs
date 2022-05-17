using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinar_Reseni
{
    internal class Policista
    {
        internal static void OdeberZviratko(Mazlicek m, Clovek c)
        {
            Console.WriteLine("Pan policista ti odebral zvířátko {0}", m.prezdivka);
            c.mazlicci.Remove(m);
        }
    }
}
