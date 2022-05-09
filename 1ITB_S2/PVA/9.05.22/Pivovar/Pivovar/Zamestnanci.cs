using System;
using System.Collections;

namespace proj
{
    class Zamestnanci
    {
        private List<Zamestnanci> zamest = new List<Zamestnanci>();
        private string jmeno;
        private string pozice;
        private static Random rnd = new Random(); //nevim jak funguje static :)
        private static ArrayList prvnijmen = new ArrayList {"Hanz","Tomas","Alfonz","Josef","Pepik","Ales","Jakub","Miroslav","Melichar"};
        private static ArrayList druhjmen = new ArrayList {"Kos","Malíř","Rys","Zahradník","Novak","Hnědý","Novotny","Dudák"};
        public Zamestnanci(string jmeno, string pozice){
            this.jmeno = jmeno;
            this.pozice = pozice;
            this.zamest.Add(this);
        }
        public void GenerujZamestnance(int manag, int podmanag, int delnik){
            for(int i = 0; i < manag; i++){
                this.zamest.Add(new Zamestnanci($"{prvnijmen[rnd.Next(0,prvnijmen.Count)]} {druhjmen[rnd.Next(0, druhjmen.Count)]}", "Manager"));
            }
            for(int i = 0; i < podmanag; i++){
                this.zamest.Add(new Zamestnanci($"{prvnijmen[rnd.Next(0,prvnijmen.Count)]} {druhjmen[rnd.Next(0, druhjmen.Count)]}", "PodManager"));
            }
            for(int i = 0; i < delnik; i++){
                this.zamest.Add(new Zamestnanci($"{prvnijmen[rnd.Next(0,prvnijmen.Count)]} {druhjmen[rnd.Next(0, druhjmen.Count)]}", "Delnik"));
            }
        }
        public void VypisZamest(){
            foreach(Zamestnanci idk in zamest){
                Console.WriteLine(idk.jmeno + " pozice: " + idk.pozice);
            }
        }
    }
}