using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panschgo
{
    internal class Player
    {
        public string Name { get; set; }
        public string Symbol { get; set; } 

        
        public void MakeMove(Board board, int x, int y, int quadrant, bool rotateClockwise)
        {
            // logic
        }
        public bool HasWon(Board Board)
        {
            // logic
        }
    }
}
