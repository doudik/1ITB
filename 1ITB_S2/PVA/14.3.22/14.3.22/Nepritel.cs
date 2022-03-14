using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._3._22
{
    internal class Nepritel
    {
        Random rnd = new Random();
        public string jmeno;
        public float hp;
        public float dmg;
        public int lvl;
        public float defence;
        public float xp;

        string[] prisery = { "Bimbas", "Puňťa", "BlackHead", "Medvídek Pú" };
        public Nepritel(Hrac h) {
            jmeno = prisery[rnd.Next(0, prisery.Length)];
            hp = 20 + (h.lvl * rnd.Next(1,50));
            dmg = 20 + (h.lvl * rnd.Next(2, 10));
            lvl = h.lvl + rnd.Next(0, 4);
            defence = 2 + (h.lvl * rnd.Next(0, 3));
            xp = hp + dmg + lvl;
        }
    }
}
