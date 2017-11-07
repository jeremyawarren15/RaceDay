using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDay
{
    class Player : Person
    {
        // Constructors
        public Player()
        {
            this.XPos = 1;
        }

        public Player(int startPos)
        {
            this.XPos = startPos;
        }
    }
}
