namespace Interface {
    class Program {
        static void Main(string[] args) {
            Ucet PepaNovak = new Ucet("Pepa Novak");
            Ucet u = new Ucet("u");
            Ucet u2 = new Ucet("v");


            //PepaNovak.zustatek = 2200;
            Console.WriteLine("1. " + PepaNovak.Mena);
            PepaNovak.Mena = "EUR";
            Console.WriteLine("2. " + PepaNovak.Mena);
            Console.WriteLine(PepaNovak.zustatek);

            Console.WriteLine("Počet uživatelů: " + Ucet.pocetUzivatelu);
            //Console.WriteLine("Kupon: " + PepaNovak.kupon);
            Ucet.GenerujKupon();
            Ucet.GenerujKupon();
            Ucet.UkazKupony();
        }
    }
}