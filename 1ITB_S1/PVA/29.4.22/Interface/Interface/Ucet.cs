using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Ucet
    {
        string mena;
        public string Mena {
            get { return mena; }
            set { ZmenMenu(value);}
        }
        public int zustatek { get; private set; }
        string vlastnik;
        public static int pocetUzivatelu;
        //public string kupon { get { return GenerujKupon(); } }
        static List<string> kuponList = new List<string>();

        public Ucet(string vlastnik) {
            this.vlastnik = vlastnik;
            mena = "CZK";
            zustatek = 200;
            pocetUzivatelu++;
        }
        void ZmenMenu(string value)
        {
            if (value == "EUR")
            {
                if (mena != "EUR")
                {
                    zustatek /= 25;
                    mena = value;
                }
            }
            else if (value == "CZK")
            {
                if (mena != "CZK")
                {
                    zustatek *= 25;
                    mena = value;
                }
            }
            else
            {
                Console.WriteLine("Tento typ měny nepodporujeme!");
            }
        }
        public static void GenerujKupon() {
            Random rnd = new Random();
            string znaky = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string tmp = "";
            for (int i = 1; i < 30; i++)
            {
                if (i % 5 == 0)
                {
                    tmp += "-";
                }
                else{
                    tmp += znaky[rnd.Next(0, znaky.Length)];
                }
            }
            kuponList.Add(tmp);
        }
        public static void UkazKupony() {
            foreach (var item in kuponList)
            {
                Console.WriteLine(item);
            }
        }
        static bool OverKupon() {
            Console.WriteLine("Zadejte mi Váš kupon: ");
            string kupon = Console.ReadLine();
            foreach (var item in kuponList)
            {
                if (kupon == item) {
                    return true;
                }
            }
            return false;
        }

    }
}
