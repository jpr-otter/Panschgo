using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panschgo
{
    internal class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Value { get; set; }

        public bool IsEmpty()
        {
            //logic
            return true;
        }
    }
}
