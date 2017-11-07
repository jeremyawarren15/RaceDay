using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RaceDay
{
    class Program
    {
        static void Main(string[] args)
        {
            // Player
            Player player = new Player(0);
            
            // Opponents
            List<Opponent> opponents = new List<Opponent>();
            opponents.Add(new Opponent(0));
            opponents.Add(new Opponent(0));
            opponents.Add(new Opponent(0));
            
            // Make a course
            Course c = new Course(player, opponents, 100);

            // Initiate movement for player
            PlayPlayer();
            // Initiate movement for each opponent
            foreach (var o in opponents)
            {
                PlayOpponent(o);
            }

            while (c.RaceInProgress())
            {
                Console.Clear();
                Console.WriteLine("Alternate Z and M to run");
                c.PrintCourse();
                Thread.Sleep(200);
            }

            // Moving racers
            async void PlayPlayer()
            {
                await Task.Run(() => MovePlayer());
            }

            async void PlayOpponent(Opponent opponent)
            {
                await Task.Run(() => MoveOpponent(opponent));
            }

            void MovePlayer()
            {
                while (true)
                {
                    // Logic for imitating stumble
                    var key = Console.ReadKey();
                    var key2 = Console.ReadKey();
                    if (key.Key == ConsoleKey.Z)
                    {
                        if (key2.Key == ConsoleKey.M)
                        {
                            c.MovePerson(player, 1);
                        }
                    }
                    else if (key.Key == ConsoleKey.M)
                    {
                        if (key2.Key == ConsoleKey.Z)
                        {
                            c.MovePerson(player, 1);
                        }
                    }
                }
            }

            void MoveOpponent(Opponent opponent)
            {
                while (true)
                {
                    c.MovePerson(opponent, 1);
                    Thread.Sleep(500);
                }
            }

        }
    }
}
