using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinar_Reseni
{
    internal class Clovek
    {
        public string jmeno, prijmeni;
        public int zustatek;
        Random rnd = new Random();

        public List<Mazlicek> mazlicci = new List<Mazlicek>();

        public Clovek(string jmeno, string prijmeni) { 
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            zustatek = rnd.Next(1000, 5001);
            VyberMiMazlicky();
        }
        private void VyberMiMazlicky() {
            for (int i = 0; i < 2; i++)
            {
                mazlicci.Add(Mazlicek.listDostupnychMazlicku[rnd.Next(0, Mazlicek.listDostupnychMazlicku.Count)]);
            }
        }
        public void Vypis() {
            for (int i = 0; i < mazlicci.Count; i++) {
                Console.WriteLine("Jméno: {0}, mazlíček: {1}", jmeno, mazlicci[i].prezdivka);
            }
        }
        public void IdentifikujSvehoMazlicka()
        {
            Console.WriteLine("Jakého mazlíčka chceš vybrat?");
            for (int i = 0; i < mazlicci.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i+1, mazlicci[i].typ);
            }
            
            string vstup = Console.ReadLine();
            switch (vstup) {
                
                case "1":
                    Console.WriteLine(mazlicci[0].prezdivka);
                    Console.WriteLine("Zadejte přezdívku:");
                    vstup = Console.ReadLine();
                    mazlicci[0].prezdivka = vstup;
                    break;
                case "2":
                    Console.WriteLine("Zadejte přezdívku:");
                    vstup = Console.ReadLine();
                    mazlicci[1].prezdivka = vstup;
                    break;
                default:
                    Console.WriteLine("Tuhle volbu neznám!");
                    break;
            }
        }

        internal void JitNaVeterinu(Mazlicek m, Clovek c)
        {
            Console.WriteLine("Šel jsi na veterinu");
            Veterinar.ZkontrolujZviratko(m, c);
        }
    }
}
