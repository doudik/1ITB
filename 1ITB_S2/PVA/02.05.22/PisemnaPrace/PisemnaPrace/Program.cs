namespace PisemnaPrace {
    class Program
    {
        static Matrika zenska = new Matrika("Irena", "Kosova", "123123/0000", "12.03.2012");
        static Matrika muz = new Matrika("Ilaloi", "Prasnic", "123123/1111", "12.03.2012");
        static void Main(string[] args)
        {
            while (true) {
                Dialog();    
            }
        }
        public static void Dialog()
        {
            Console.WriteLine("1. Změn příjmení");
            Console.WriteLine("2. Vypiš uživatele");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Jaké má být příjmení?");
                    string novePrijmeni = Console.ReadLine();
                    Matrika.Svatba(zenska, muz, novePrijmeni);
                    break;
                case 2:
                    Matrika.VypisJmena();
                    break;
                default: 
                    Console.WriteLine("chyba");
                    break;
            }
        }
    }
}
