using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        public static bool player1Turn { get; set; } = true;
        private string input = "";

        private int row { get; set; }
        private int column { get; set; }
        public int playerPoints { get; private set; }
        private Position position;

        public Player()
        {

        }

        public void SetPosition()
        {
            string playerTurn = "";
            row = -1; column = -1;
            if(player1Turn == true)
            {
                playerTurn = "Player 1";
            } else if(player1Turn == false)
            {
                playerTurn = "Player 2";
            }
            Console.Write(playerTurn + "'s turn: ");
            input = Console.ReadLine();
            InputFormat();
        }

        private void InputFormat()
        {
            while (NumbersAndComma(input) == false && input != "help")
            {
                Console.Write("Please enter a valid position: ");
                input = Console.ReadLine();
                NumbersAndComma(input);
            }
            if (input == "help")
            {
                Helper.helper = new Helper();
                return;
            }

            position = new Position(row, column);
        }

        private bool NumbersAndComma(string input)
        {
            try
            {
                row = Convert.ToInt32(input.Substring(0, 1));
                column = Convert.ToInt32(input.Substring(2, 1));
            }
            catch { }
            if(row >= 0 && 
                row <= 2 && 
                column >= 0 && 
                column <= 2 &&
                input.Length == 3 &&
                input.Substring(1, 1) == ",")
            {
                return true;
            }
            return false;
        }

        public void Win()
        {
            playerPoints += 1;
        }
    }
}
