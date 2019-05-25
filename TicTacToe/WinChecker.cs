using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class WinChecker
    {
        public static bool Win { get; private set; } = false;

        public WinChecker()
        {
            Check();
            if (IsDraw() == true)
            {
                Console.WriteLine("You have drew! Press enter to restart.");
                Renderer.Reset();
            }
        }

        private void Check()
        {
            if(Board.arrayBoard[0,0] == (int)State.O && 
                Board.arrayBoard[0, 1] == (int)State.O && 
                Board.arrayBoard[0, 2] == (int)State.O ||
                Board.arrayBoard[1, 0] == (int)State.O &&
                Board.arrayBoard[1, 1] == (int)State.O &&
                Board.arrayBoard[1, 2] == (int)State.O ||
                Board.arrayBoard[2, 0] == (int)State.O &&
                Board.arrayBoard[2, 1] == (int)State.O &&
                Board.arrayBoard[2, 2] == (int)State.O ||
                Board.arrayBoard[0, 0] == (int)State.O &&
                Board.arrayBoard[1, 0] == (int)State.O &&
                Board.arrayBoard[2, 0] == (int)State.O ||
                Board.arrayBoard[0, 1] == (int)State.O &&
                Board.arrayBoard[1, 1] == (int)State.O &&
                Board.arrayBoard[2, 1] == (int)State.O ||
                Board.arrayBoard[0, 2] == (int)State.O &&
                Board.arrayBoard[1, 2] == (int)State.O &&
                Board.arrayBoard[2, 2] == (int)State.O ||
                Board.arrayBoard[0, 0] == (int)State.O &&
                Board.arrayBoard[1, 1] == (int)State.O &&
                Board.arrayBoard[2, 2] == (int)State.O ||
                Board.arrayBoard[0, 2] == (int)State.O &&
                Board.arrayBoard[1, 1] == (int)State.O &&
                Board.arrayBoard[2, 0] == (int)State.O)
            {
                Renderer.Player2Wins();
            } else if(Board.arrayBoard[0, 0] == (int)State.X &&
                Board.arrayBoard[0, 1] == (int)State.X &&
                Board.arrayBoard[0, 2] == (int)State.X ||
                Board.arrayBoard[1, 0] == (int)State.X &&
                Board.arrayBoard[1, 1] == (int)State.X &&
                Board.arrayBoard[1, 2] == (int)State.X ||
                Board.arrayBoard[2, 0] == (int)State.X &&
                Board.arrayBoard[2, 1] == (int)State.X &&
                Board.arrayBoard[2, 2] == (int)State.X ||
                Board.arrayBoard[0, 0] == (int)State.X &&
                Board.arrayBoard[1, 0] == (int)State.X &&
                Board.arrayBoard[2, 0] == (int)State.X ||
                Board.arrayBoard[0, 1] == (int)State.X &&
                Board.arrayBoard[1, 1] == (int)State.X &&
                Board.arrayBoard[2, 1] == (int)State.X ||
                Board.arrayBoard[0, 2] == (int)State.X &&
                Board.arrayBoard[1, 2] == (int)State.X &&
                Board.arrayBoard[2, 2] == (int)State.X ||
                Board.arrayBoard[0, 0] == (int)State.X &&
                Board.arrayBoard[1, 1] == (int)State.X &&
                Board.arrayBoard[2, 2] == (int)State.X ||
                Board.arrayBoard[0, 2] == (int)State.X &&
                Board.arrayBoard[1, 1] == (int)State.X &&
                Board.arrayBoard[2, 0] == (int)State.X)
            {
                Renderer.Player1Wins();
            }
        }

        public static bool IsDraw()
        {
            int counter = 0;
            for (int i = 0; i < Board.row; i++)
            {
                for (int j = 0; j < Board.column; j++)
                {
                    if(Board.arrayBoard[i, j] == (int)State.Undecided)
                    {
                        counter += 1;
                    }
                }
            }
            if(counter == 0 && Win == false)
            {
                return true;
            }
            return false;
        }
    }
}
