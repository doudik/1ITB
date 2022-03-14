using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_1ITBs2
{
    internal class Bordel
    {
        public int BordelKod() {

            int vysledek = 0;
            int[] pole = { 2, 1, 7, 9 };
            pole[3] = 99;

            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write("{0}, ", pole[i]);
            }
            Console.WriteLine("\n--------------------");
            foreach (int item in pole)
            {
                Console.Write("{0}, ", item);
            }
            Console.WriteLine("\n--------------------");
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add(5);
            arr[0] = 20;
            
            foreach (int item in arr) {
                vysledek += item;
            }
            return vysledek;
        }
    }
}
