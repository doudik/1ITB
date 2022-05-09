using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovar
{
    internal class Pivovar : Pivo
    {  
        //Zkontroluji, pokuď mám suroviny na výrobu piva
        private static bool SurovinyCheck(int chmel, int voda, int slad, int kvasinky)
        {
            if (Sklad.chmel >= chmel && Sklad.voda >= voda && Sklad.slad >= slad && Sklad.kvasinky >= kvasinky)
            {
                return true;
            }
            else {
                if (Sklad.chmel < chmel) { Console.WriteLine("Nemám dostatek chmelu!"); }
                if (Sklad.voda < voda) { Console.WriteLine("Nemám dostatek vody!"); }
                if (Sklad.slad < slad) { Console.WriteLine("Nemám dostatek sladu!"); }
                if (Sklad.kvasinky < kvasinky) { Console.WriteLine("Nemám dostatek kvasinek!"); }
            }
        }
        private static void UvarPivo(int[] arr)
        {
            SurovinyCheck(arr[0], arr[1], arr[2], arr[3]);
        }
        public void ZacatekPracovniDoby() {
            //Jaké pivo budeme vařit?
            Random rnd = new Random();
            //Uděláme list pro pivka, následně jedno náhodně vybereme
            List<string> pivson = new List<string> { "11°", "12°", "14°" };
            switch (pivson[rnd.Next(0, pivson.Count)]){
                case "11°":
                    UvarPivo(Pivo11.Recept());
                    break;
                case "12°":
                    UvarPivo(Pivo12.Recept());
                    break;
                case "14°":
                    UvarPivo(Pivo14.Recept());
                    break;
                default:
                    break;
            }

        }
        private Object VyberPivko() { 
            
        }
    }
}