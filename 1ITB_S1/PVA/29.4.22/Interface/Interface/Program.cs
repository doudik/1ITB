namespace Interface {
    class Program {
        static void Main(string[] args) {
            Ucet ucet_01 = new Ucet("Pepa Novak", 200, "Kč");
            Ucet ucet_02 = new Ucet("Honza Novak", 400, "Kč");
            Ucet ucet_03 = new Ucet("Vratislav Novak", 600, "Kč");
            
            
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