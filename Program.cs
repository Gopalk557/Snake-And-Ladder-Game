using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            SnakeLadder player1 = new SnakeLadder();
            player1.Play();
            Console.ReadKey();
        }
    }
}
