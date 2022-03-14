using System.Collections;

namespace projekt_1ITBs2;

class Program {
    static void Main(string[] args) {

        Zvire zebra = new Zvire("Žofka", 4);
        Zvire pes = new Zvire("Žorik", 4);

        zebra.jmeno = "Julča";

        Console.WriteLine(zebra.jmeno);

        List<Zvire> souborZvirat = new List<Zvire>();
        souborZvirat.Add(zebra);
        souborZvirat.Add(pes);
        foreach (Zvire i in souborZvirat) {
            Console.Write(i + ", ");
        }
        souborZvirat[0].jmeno = "Petr";
        Console.WriteLine(souborZvirat[0].jmeno);


        Bordel b = new Bordel();
        Console.WriteLine(b.BordelKod());
    }
}
