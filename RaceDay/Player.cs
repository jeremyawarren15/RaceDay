using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDay
{
    class Player : Person
    {
        // Backing Fields
        private int _momentum;

        // Constructors
        public Player()
        {
            this.XPos = 1;
        }

        public Player(int startPos)
        {
            this.XPos = startPos;
        }

        

        public int Momentum
        {
            get { return _momentum; }
            set
            {
                if (value <= 4 && value >= 0) {
                    _momentum = value;
                }
                else if (value < 0)
                {
                    _momentum = 0;
                }
                else
                {
                    _momentum = 4;
                }
                
            }
        }

    }
}
