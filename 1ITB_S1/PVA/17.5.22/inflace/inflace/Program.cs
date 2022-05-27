class Program {
    
    static void Main(string[] args) {
        float inflace = 0.04f;
        double zhodnoceni = 0;
        double zustatek = 0f;
        int vyplata = 19065;
        Random rnd = new Random();
        for (int i = 1; i < 787; i++)
        {
            zustatek += vyplata;
            if (i % 12 == 0) {
                zhodnoceni = ((int)rnd.NextDouble() * (11 - 5) + 5);
               
                zustatek = zustatek * ((zhodnoceni - inflace)/100 + 1);
            }
            Console.WriteLine(zustatek);
        }
        Console.WriteLine("Konečný zůstatek: " + zustatek);
        
    }
}