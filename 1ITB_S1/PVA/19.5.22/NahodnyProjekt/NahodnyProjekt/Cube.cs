using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NahodnyProjekt
{
    internal class Cube
    {
        public List<Cube> cubeList = new List<Cube>();
        int sirka, vyska, poziceX, poziceY;

        public Cube(int sirka, int vyska, int poziceX, int poziceY) { 
            this.sirka = sirka;
            this.vyska = vyska;
            this.poziceX = poziceX;
            this.poziceY = poziceY;
            cubeList.Add(this);
        }
    }
}
