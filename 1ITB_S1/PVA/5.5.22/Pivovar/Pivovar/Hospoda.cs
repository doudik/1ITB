using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Pivovar
{
    class Hospoda
    {
        static Random rnd = new Random();
        static int cenaPiva = 35;
        static int pokladna { get; set; }
        public static int pocetLidi = rnd.Next(2, 60);
        static int pocetVypitychPiv { get; set; }

        public static void Nalejvarna() {
               
                Thread.Sleep(1000);
                if (Sklad.pivo > 0)
                {
                pocetLidi = rnd.Next(2, 60);
                Console.WriteLine("Počet piv: {0} | Počet vypitých piv: {1} | Pokladna: {2} | Počet lidí: {3}",
                        Sklad.pivo, pocetVypitychPiv, pokladna, pocetLidi);
                for (int i = 0; i < pocetLidi; i++)
                    {
                    
                    if (Sklad.pivo > 0)
                        {
                            VypijPivo();
                        }
                        else
                        {
                           // Console.WriteLine("Došlo pivo! Čekám na výrobu");
                        }
                    }
                }
                else {
                    Console.WriteLine("Na skladě není žádné pivo!");
                }
            
        }
        static void VypijPivo() {
            pocetVypitychPiv++;
            Sklad.OdeberPivo();
            pokladna += cenaPiva;
        }
    }
}
