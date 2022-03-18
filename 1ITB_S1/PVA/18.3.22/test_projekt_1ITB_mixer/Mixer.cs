using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test_projekt_1ITB_mixer
{
    internal class Mixer
    {
        public float otacky { get; private set; }
        public float pitch
        {
            get { return otacky; }
            set {
                Console.WriteLine("Změnil jsem otáčky!");
                otacky = value; }
        }
        public float vykon;
        public float objem;
        public int zarucniDoba;
        public int cena;
        public bool isOn;
        List<string> mixerList = new List<string>();


        public float getOtacky() {
            return otacky;
        }
        public void setOtacky(float val) {
            otacky = val;
        }
        public Mixer(float otacky, float vykon, float objem, int cena) {
            this.cena = cena;
            this.otacky = otacky;
            this.vykon = vykon;
            this.objem = objem;
            zarucniDoba = 24;
            isOn = false;
        }
        void NaplnMixer(string item) {
            mixerList.Add(item);
        }
        public bool ZapniMixer() { 
            return this.isOn = true;
        }
    }
}
