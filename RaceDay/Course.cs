using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDay
{
    class Course
    {
        // Constants
        const char PLAYER_CHAR = 'o';
        const char ENEMY_CHAR = '*';

        // Constructors
        public Course(Player player, int courseLength)
        {
            this.Player = player;
            this.Opponents = new List<Opponent>();
            this.CourseLength = courseLength;
        }

        public Course(Player player, List<Opponent> opponents)
        {
            this.Player = player;
            this.Opponents = opponents;
            this.CourseLength = 100;
        }

        public Course(Player player, List<Opponent> opponents, int courseLength)
        {
            this.Player = player;
            this.Opponents = opponents;
            this.CourseLength = courseLength;
        }

        // Properties
        public Player Player { get; set; }
        public List<Opponent> Opponents { get; set; }
        public string PlayerCourse { get; set; }
        public int CourseLength { get; set; }

        // Methods
        public void PrintCourse()
        {
            // Print course for player
            StringBuilder sbp = new StringBuilder(new string(' ', this.CourseLength));
            sbp[this.Player.XPos] = PLAYER_CHAR;
            sbp.Insert(0, " |");
            sbp.Append('|');
            Console.WriteLine(sbp.ToString());
            // Print course for each opponent
            foreach (var o in this.Opponents)
            {
                StringBuilder sb = new StringBuilder(new string(' ', this.CourseLength));
                sb[o.XPos] = ENEMY_CHAR;
                sb.Insert(0, " |");
                sb.Append('|');
                Console.WriteLine(sb.ToString());
            }
        }

        public void MovePerson(Person p)
        {
            p.Run();
        }

        public void MovePerson(Person p, int moveAmount)
        {
            p.Run(moveAmount);
        }

        public bool RaceInProgress()
        {
            if (this.Player.XPos >= this.CourseLength)
            {
                return false;
            }
            foreach (var o in this.Opponents)
            {
                if (o.XPos >= this.CourseLength)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
