using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDay
{
    public abstract class Person
    {
        // Properties
        public int XPos { get; set; }

        // Methods
        public void Run()
        {
            XPos++;
        }
        public void Run(int runAmount)
        {
            XPos += runAmount;
        }
    }
}
