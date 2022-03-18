namespace test_projekt_1ITB_mixer;

class Program {

    static void Main(string[] args)
    {
        Mixer tesla3000 = new Mixer(20.0f, 240f, 1500f, 2400);
        Mixer ingrid = new Mixer(20.0f, 240f, 1500f, 2400);
        tesla3000.ZapniMixer();
        Console.WriteLine("Zapl sem mixér? " + tesla3000.isOn);
        Console.WriteLine("Zapl sem mixér? " + ingrid.isOn);
        Console.WriteLine("Nový mixér tesla3000 je právě za cenu {0}", tesla3000.cena);
        tesla3000.getOtacky();
    }
}