namespace _14._3._22;
class Program {
    static void Main(string[] args)
    {
        Console.WriteLine("Napiš mi své ctěné jméno: ");
        Hrac h1 = new Hrac(Console.ReadLine());
        //Nepritel priserka = new Nepritel(h1);
        Rozhovor r = new Rozhovor();
        r.UvodniDialog(h1);
    }

}