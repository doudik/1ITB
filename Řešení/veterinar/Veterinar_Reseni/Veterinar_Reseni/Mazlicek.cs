using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinar_Reseni
{
    internal class Mazlicek
    {

        public static List<Mazlicek> listDostupnychMazlicku = new List<Mazlicek>();

        public string prezdivka { get; set; } = "";
        public string typ { get; private set; }
        int vek, pocetNohou;

        public Mazlicek(string typ, int pocetNohou) {
            this.typ = typ;
            vek = 0;
            this.pocetNohou = pocetNohou;
            listDostupnychMazlicku.Add(this);
        }
        public static void ZrozeniZviratek() {
            Mazlicek pes = new Mazlicek("pes", 4);
            Mazlicek kocka = new Mazlicek("kocka", 4);
            Mazlicek zirafa = new Mazlicek("zirafa", 4);
        }
        

    }
}
