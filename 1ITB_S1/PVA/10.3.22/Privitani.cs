using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ITB_S1
{
    class Privitani
    {
        //string jmeno, prijmeni
        public string jmeno, prijmeni;
        //int vek
        public int vek;

        //1. konstruktor
        public Privitani(string jmeno, string prijmeni, int vek) {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.vek = vek;
        }
        //2. Metoda na zmenu jmena
        public void ZmenaJmena(string j, string p) {
            jmeno = j;
            prijmeni = p;
        }
        //3. Metoda, která vrátí věk objektu
        public int ZiskejVek() {
            return vek;
        }

        //použití objektu v metodě
        public Privitani ZiskejObjekt(Privitani p) {
            return p;
        }
    }

    
}
