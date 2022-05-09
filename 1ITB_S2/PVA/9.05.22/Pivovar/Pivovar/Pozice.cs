using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovar
{
    internal class Pozice
    {
        static void pracovniPozice()
        {
            //TODO pracovní pozice
            //TODO platy!
            //1.List<string> ...
            List<string> pozice = new List<string> {"Číšník", "Kuchař", "Uklízečka", "Skladník" };
            List<int> platy = new List<int> { 25000, 30000, 18000, 23000 };
            //2. IDictionary 
            IDictionary<string, int> pracovniPozice = new Dictionary<string, int> {
                {"Číšník", 25000 },
                {"Kuchař", 30000 },
                {"Uklízečka", 18000 },
                {"Skladník", 23000 }
            };
        }
    }
}