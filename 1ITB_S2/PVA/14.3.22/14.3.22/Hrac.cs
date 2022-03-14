using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._3._22
{
    internal class Hrac
    {

        public string jmeno;
        public int lvl;
        public float hp;
        public float dmg;
        public float xp;
        public float xpToNextLvl;
        public float mana;
        public float defence;
        Random rnd = new Random();
        public Hrac(string jmeno) {
            this.jmeno = jmeno;
            lvl = 1;
            hp = 100f;
            dmg = 20f + rnd.Next(0, 25); ;
            xp = 0;
            xpToNextLvl = lvl * 50;
            mana = 50;
            defence = 1;
        }
        public void XpUp(Hrac h, Nepritel n) {
            h.xp += n.xp;
            while (h.xp >= h.xpToNextLvl) {
                float tmp = h.xp - h.xpToNextLvl;
                lvl++;
                h.xp = Math.Abs(tmp);
                tmp = 0;
                Console.WriteLine("LVL UP!");
                ZvysStaty(h);
            }
        }
        void ZvysStaty(Hrac h) {
            h.hp += h.lvl * rnd.Next(0, 20);
            h.dmg += h.lvl * rnd.Next(2, 10);
            h.defence += h.lvl;
            h.mana += h.lvl * 5;
        }

    }
}
