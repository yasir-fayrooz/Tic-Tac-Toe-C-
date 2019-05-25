using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Position
    {
        private int row { get; set; }
        private int column { get; set; }

        public Position(int row, int column)
        {
            this.column = column;
            this.row = row;
            PositionSetter();
        }

        private void PositionSetter()
        {
            if (Board.arrayBoard[row, column] == (int)State.Undecided)
                {
                    if (Player.player1Turn == true)
                    {
                        Board.arrayBoard[row, column] = (int)State.X;
                        Player.player1Turn = false;
                    Console.Clear();
                    }
                    else if (Player.player1Turn == false)
                    {
                        Board.arrayBoard[row, column] = (int)State.O;
                        Player.player1Turn = true;
                    Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("The " + row + "," + column + " " + "space has been taken!");
                    Program.Turn();
                }
        }
    }
}
