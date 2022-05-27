class Program {
    static int velikost = int.Parse(Console.ReadLine());
    static int x = velikost - 1;


    static void Main(string[] args) {
        Console.WriteLine("Zadejte velikost:");
        int[,] pole = new int[velikost, velikost];
        //false = vertikalne, true = horizontalne
        Napln0(pole);
        Napln1(pole);
        VypisPole(pole);

        //false - vertikalně
    }
    static void Napln1(int[,] pole) {
            bool smer = false;
            if (smer == false)
            {
                for (int i = velikost - 1; i > 0; i--)
                {
                    for (int j = 0; j < velikost-1; j++)
                    {
                        if (i == velikost - 1)
                        {
                            pole[velikost - 1, j] = 1;
                        }
                        if (j == velikost - 1) {
                            pole[i, j] = 1;
                        }
                    }
                }
            }
            //horizontalne
            else
            {
            
            }

        }   
    static void Napln0(int[,] pole) {
        //naplnime 0
        for (int i = 0; i < velikost; i++)
        {
            for (int j = 0; j < velikost; j++)
            {
                pole[i, j] = 0;
             }
        }
    }
    static void VypisPole(int[,] pole) {
        for (int i = 0; i < velikost; i++)
        {
            for (int j = 0; j < velikost; j++)
            {
                Console.Write(pole[i,j]);
            }
            Console.WriteLine("");
        }
    }
}