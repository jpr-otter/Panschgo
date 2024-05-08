using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panschgo
{
    internal class Board
    {
        public Quadrant[] Quadrants { get; set; }

        public Board()
        {
            Quadrants = new Quadrant[4];
            for (int i = 0; i < 4; i++)
            {
                Quadrants[i] = new Quadrant();
            }
        }
        public string CheckStatus()
        {
            // game check logic
            return "";
        }
        public static Quadrant GetQuadrant(int index)
        {
            //logic
        }
    }
}
