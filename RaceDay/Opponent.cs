using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDay
{
    class Opponent : Person
    {
        // Constructors
        public Opponent()
        {
            this.XPos = 1;
        }

        public Opponent(int startPos)
        {
            this.XPos = startPos;
        }
    }
}
