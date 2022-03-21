using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixer
{
    internal class Mixer
    {
        public int otacky { 
            get {
                return otacky;
            } 
            private set { 
            }
        }
        
        int vaha;
        string material;
        public int vykon;
        public string znacka;
        public bool isOn;

        //string[] polepotravin = { "okurka", "jablko", "banán", "chleba", "párek" };
        List<string> potraviny;

        public Mixer(int otacky, int vaha, string material, int vykon, string znacka) { 
            this.otacky = otacky;
            this.vaha = vaha;
            this.material = material;
            this.vykon = vykon;
            this.znacka = znacka;
            isOn = false;
        }
        void PridejPotravinu(string arg) {
            potraviny.Add(arg);
            Console.WriteLine("Přidal jsem potravinu " + arg);
        }
        void OdeberPotravinu(string arg) {
            potraviny.Remove(arg);
            Console.WriteLine("Odebral jsem potravinu " + arg );
        }
        public void ZapniMixer() {
            isOn = true;
            Console.WriteLine("Zapl jsem mixér");
        }
        void VypniMixer() {
            isOn = false;
            Console.WriteLine("Vypl jsem mixér");
        }
       

    }
}
