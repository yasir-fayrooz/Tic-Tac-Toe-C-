using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Helper
    {
        public static Helper helper;


        public Helper()
        {
            Console.Clear();
            DisplayHelpScreen();
            DisplayGameScreen();
        }

        private void DisplayHelpScreen()
        {
            Console.WriteLine("INSTRUCTIONS:");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Welcome to TIC TAC TOE!");
            Console.WriteLine("This game uses a grid matrix system where you have to specify ");
            Console.WriteLine("an area by typing \"row,column\". I.E. for the first square  ");
            Console.WriteLine("area, you will type 0,0 to mark an X or O depending on the ");
            Console.WriteLine("player turn and the last will be 2,2 etc.");
            Console.WriteLine();
            Console.Write("Press the ENTER key on your keyboard to return to the game.");
            Console.ReadLine();
        }

        private void DisplayGameScreen()
        {
            Console.Clear();
            Program.renderGame = new Renderer();
            Program.Turn();
        }
    }
}
