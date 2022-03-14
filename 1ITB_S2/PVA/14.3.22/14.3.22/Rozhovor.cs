using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._3._22
{
    internal class Rozhovor
    {
        public void UvodniDialog(Hrac h)
        {
            Console.WriteLine(" ----- Vítej, {0} -----\n", h.jmeno);
            VypisStaty(h);
        }
        void VypisStaty(Hrac h)
        {
            Console.WriteLine("\n Tvoje staty: \n\n" +
                "HP: {0} \n" +
                "DMG: {1} \n" +
                "LvL: {2} \n" +
                "XP: {3} \n" +
                "XP2NextLvl: {4} \n" +
                "Mana: {5} \n" +
                "Defence: {6} \n", h.hp, h.dmg, h.lvl, h.xp, h.xpToNextLvl, h.mana,
                h.defence);
            VytvorPriserku(h);
        }
        void VytvorPriserku(Hrac h)
        {
            Nepritel n = new Nepritel(h);
            CombatSystem(h, n);
        }
        void CombatSystem(Hrac h, Nepritel n)
        {
            while (h.hp > 0)
            {
                if (n.hp <= 0)
                {
                    VytvorPriserku(h);
                }
                else {
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("-------------NOVÁ PŘÍŠERA-----------");
                    Console.WriteLine("Střetl jsi se s příšerkou {0}!\n", n.jmeno);
                
                while (n.hp > 0 && h.hp > 0)
                {
                        Console.WriteLine("---------------COMBAT------------\n");
                        Console.WriteLine("HRAC HP: {0} MANA: {1}, DMG: {2}, XP2Nxt: {3}, LVL: {4}, DEFENCE: {5}", h.hp, h.mana, h.dmg, 
                            Math.Abs(h.xp - h.xpToNextLvl), h.lvl, h.defence);
                        Console.WriteLine("PŘÍŠERA HP: {0} DMG: {1} DEFENCE: {2} LVL: {3}\n\n"
                            , n.hp, n.dmg, n.defence, n.lvl);
                        Console.WriteLine("> Jakou operaci si přeješ provést? \n");
                        Console.WriteLine("1. Útok");
                        Console.WriteLine("2. Obrana");
                        Console.WriteLine("3. Útěk");
                            switch (int.Parse(Console.ReadLine()))
                            {
                                case 1:
                                    n.hp -= h.dmg;
                                    Console.WriteLine("Udeřil jsi nepřítele za {0}", h.dmg);
                                    if (n.hp <= 0)
                                    {
                                        h.XpUp(h, n);
                                        break;
                                    }
                                    else
                                    {
                                        h.hp -= n.dmg;
                                        Console.WriteLine("Nepřítel tě udeřil za {0}\n", n.dmg);
                                        break;
                                    }
                                case 2:
                                    //OBRANA
                                    break;
                                case 3:
                                    //ÚTĚK
                                    break;
                                default:
                                    Console.WriteLine("Zadal jsi špatnou hodnotu");
                                    break;

                        
                    }
                        
                    }
                    if (h.hp <= 0) {
                        Console.WriteLine("GAME OVER");
                    }
                }
            }
        }
    }
}
