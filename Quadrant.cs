using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panschgo
{
    internal class Quadrant
    {
        public Cell[,] Cells { get; set; }

        public Quadrant()
        {
            Cells = new Cell[3, 3];
        }

        
        public void Rotate(bool clockwise)
        {
            // logic
        }
        public Cell GetCell (int x, int y)
        {
            //logic
        }
    }
}
