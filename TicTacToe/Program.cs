using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        public static Player player1 = new Player();
        public static Player player2 = new Player();
        public static Renderer renderGame = new Renderer();
        public static Board playingBoard;
        private static WinChecker winCheck;

        static void Main(string[] args)
        {
            Console.WindowWidth = 75;
            Console.WindowHeight = 35;
            playingBoard = new Board();
            while (WinChecker.Win == false)
            {
                Turn();
                renderGame = new Renderer();
                winCheck = new WinChecker();
            }
        }

        public static void Turn()
        {
            if (Player.player1Turn == true)
            {
                player1.SetPosition();
            }
            else if(Player.player1Turn == false)
            {
                player2.SetPosition();
            }
        }
    }
}
