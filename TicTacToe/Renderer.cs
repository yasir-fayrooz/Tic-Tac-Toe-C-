using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Renderer
    {
        public string[,] value { get; private set; } = new string[3, 3];
        private int player1Points;
        private int player2Points;

        public Renderer()
        {
            RenderBoard();
        }

        private void RenderBoard()
        {
            Updater();
            Console.WriteLine("Welcome to TIC TAC TOE by Yasir Fayrooz. Type \"help\" for instructions.");

            string grid = "     0     1     2   ";
            string line0 = "  +-----+-----+-----+";
            string line1 = $"0 |  {value[0,0]}  |  {value[0,1]}  |  {value[0,2]}  |";
            string line2 = "  +-----+-----+-----+";
            string line3 = $"1 |  {value[1,0]}  |  {value[1,1]}  |  {value[1,2]}  |";
            string line4 = "  +-----+-----+-----+";
            string line5 = $"2 |  {value[2,0]}  |  {value[2,1]}  |  {value[2,2]}  |";
            string line6 = "  +-----+-----+-----+";
            string whitespace = "                     ";
            string player1PointCount = $"Player1 (X) Points: {player1Points}";
            string player2PointCount = $"Player2 (O) Points: {player2Points}";

            Console.WriteLine(whitespace + grid);
            Console.WriteLine(whitespace + line0);
            Console.WriteLine(whitespace + line1 + "       " + player1PointCount);
            Console.WriteLine(whitespace + line2);
            Console.WriteLine(whitespace + line3);
            Console.WriteLine(whitespace + line4);
            Console.WriteLine(whitespace + line5 + "       " + player2PointCount);
            Console.WriteLine(whitespace + line6);
        }

        public void Updater()
        {
            player1Points = Program.player1.playerPoints;
            player2Points = Program.player2.playerPoints;
            for (int i = 0; i < Board.row; i++)
            {
                for (int j = 0; j < Board.column; j++)
                {
                    switch (Board.arrayBoard[i, j])
                    {
                        case 0:
                            value[i, j] = " ";
                            break;
                        case 1:
                            value[i, j] = "X";
                            break;
                        case 2:
                            value[i, j] = "O";
                            break;
                    }
                }
            }
        }

        public static void Reset()
        {
            Program.playingBoard = new Board();
            Console.ReadLine();
            Console.Clear();
            Program.renderGame = new Renderer();
        }
        public static void Player1Wins()
        {
            Console.WriteLine("Player 1 wins! Press enter to restart.");
            Program.player1.Win();
            Reset();
        }
        public static void Player2Wins()
        {
            Console.WriteLine("Player 2 wins! Press enter to restart.");
            Program.player2.Win();
            Reset();
        }
    }
}
