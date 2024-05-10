using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace Panschgo
{
    internal class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Board Board { get; set; }

        public Game()
        {
            Player1 = new Player();
            Player2 = new Player();
            //Board = new Board();
        }

        
        public void Start()
        {
            // logic
        }
        public void SwitchTurns()
        {
            // logic
        }
        public bool IsGameOver()
        {
            // logic
            return true;
        }
    }
}
