namespace Veterinar_Reseni {
    class Program {
        static string vstup = "";

        public static void Main(string[] args) {
            Mazlicek.ZrozeniZviratek();
            Clovek c1 = new Clovek("Franta", "Pospíšil");
            Clovek c2 = new Clovek("Malvína", "Konrátová");
            Dialog(c1, c2);
        }

        static void Dialog(Clovek c1, Clovek c2) {
            Console.WriteLine("Vyberte člověka:");
            Console.WriteLine("1. " + c1.jmeno + " | " + "2. " + c2.jmeno);
            vstup = Console.ReadLine();
            if (vstup == "1" || vstup == "2")
            {
                DialogMenu(c1, c2);
            }
            else {
                Console.WriteLine("Neumíš to zadat, poop");
                Dialog(c1, c2);
            }
        }

        static Clovek VratCloveka(string vstup, Clovek c1, Clovek c2) {
            if (vstup == "1")
            {
                return c1;
            }
            else {
                return c2;
            }
        }
        static void DialogMenu(Clovek c1, Clovek c2) {
            while (true) { 
            Console.WriteLine("Co chcete dělat?");
            Console.WriteLine(">1. Změnit jméno svého mazlíčka");
            Console.WriteLine(">2. Vypsat jméno svého mazlíčka");
            Console.WriteLine(">3. Jít na veterinu");
            string volba = Console.ReadLine();
                switch (volba) {
                    case "1":
                        if (VratCloveka(vstup, c1, c2).mazlicci.Count > 0)
                        {
                            VratCloveka(vstup, c1, c2).IdentifikujSvehoMazlicka();
                        }
                        else
                        {
                            Console.WriteLine("Již nemáš žádné zvířátka!");
                        }
                        break;
                    case "2":
                        if (VratCloveka(vstup, c1, c2).mazlicci.Count > 0)
                        {
                            VratCloveka(vstup, c1, c2).Vypis();
                        }
                        else {
                            Console.WriteLine("Již nemáš žádné zvířátka!");
                        }
                        break;
                    case "3":
                        if (VratCloveka(vstup, c1, c2).mazlicci.Count > 0)
                        {
                            Console.WriteLine("Jaké zvířátko si chcete vybrat?");
                            for (int i = 0; i < VratCloveka(vstup, c1, c2).mazlicci.Count; i++)
                            {
                                Console.WriteLine("{0}. {1}", i + 1, VratCloveka(vstup, c1, c2).mazlicci[i].prezdivka);
                            }
                            if (Console.ReadLine() == "1")
                            {
                                VratCloveka(vstup, c1, c2).JitNaVeterinu(VratCloveka(vstup, c1, c2).mazlicci[0], VratCloveka(vstup, c1, c2));
                            }
                            else
                            {
                                VratCloveka(vstup, c1, c2).JitNaVeterinu(VratCloveka(vstup, c1, c2).mazlicci[1], VratCloveka(vstup, c1, c2));
                            }
                        }
                        else {
                            Console.WriteLine("Již nemáš žádné mazlíčky!");
                        }
                        break;
                default:
                        Console.WriteLine("Miss click :)");
                    break;
            }
        }
        }
    }
}