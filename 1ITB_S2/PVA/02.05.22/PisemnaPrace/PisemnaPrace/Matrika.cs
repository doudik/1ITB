using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PisemnaPrace
{
    internal class Matrika
    {
        public string jmeno { get; private set; }
        public string prijmeni { get; private set; }
        string rodneCislo, datumNarozeni;

        public static List<Matrika> matrikaList = new List<Matrika>();

        public Matrika(string jmeno, string prijmeni, string rodneCislo, string datumNarozeni) {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.rodneCislo = rodneCislo;
            this.datumNarozeni = datumNarozeni;
            matrikaList.Add(this);
        }

        public static void Svatba(Matrika a, Matrika b, string prijmeni) {
            a.prijmeni = prijmeni;
            b.prijmeni = prijmeni;
        }
        public static void VypisJmena() {
            foreach (var item in matrikaList) {
                Console.WriteLine("{0} {1}", item.jmeno, item.prijmeni);
            }
        }

        
    }
}
