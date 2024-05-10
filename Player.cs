using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Panschgo
{
    internal class Player
    {
        public string Name { get; set; }
        public Brush Color { get; set;}
        public string Symbol { get; set; }

        public Player(string name, Brush color)
        {
            Name = name;
            Color = color;
        }

        
        public void MakeMove(Board board, int x, int y, int quadrant, bool rotateClockwise)
        {
            // logic
        }
        public bool HasWon(Board Board)
        {
            // logic
            return true;
        }
    }
}
