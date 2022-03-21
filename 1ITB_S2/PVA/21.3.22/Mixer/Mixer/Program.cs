namespace Mixer;

using System.Collections;

class Program {
    static void Main(string[] args) {
        Mixer tefal3000 = new Mixer(100, 2000, "plast", 150, "tefal");
        Mixer parkovac5000 = new Mixer(2000, 4000, "kov", 400, "Salt Bae");
        
        //tefal3000.ZapniMixer();
        Console.WriteLine(tefal3000.otacky);
        //parkovac5000.ZapniMixer();

        //Console.WriteLine(parkovac5000.isOn);
    }
}