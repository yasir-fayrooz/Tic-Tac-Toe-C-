using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {
        public static int row { get; private set; } = 3;
        public static int column { get; private set; } = 3;
        public static int[,] arrayBoard { get; private set; } = new int[row, column];

        public Board()
        {
            arrayBoard = new int[row, column];
        }

    }
    enum State
    {
        Undecided,
        X,
        O
    }
}
