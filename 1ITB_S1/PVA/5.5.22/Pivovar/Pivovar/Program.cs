namespace Pivovar {
    class Program {
        static void Main(string[] args) {
            Random random = new Random();
            while (true) {
                for (int i = 0; i < random.Next(2,Hospoda.pocetLidi); i++)
                {
                    Pivovar.UvarPivo();
                }
                Hospoda.Nalejvarna();
            }
        }
    }


}