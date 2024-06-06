// See https://aka.ms/new-console-template for more information
// using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserInput userInput = new ConsoleUserInput();
            IGameOutput gameOutput = new ConsoleGameOutput();
            Game game = new(userInput, gameOutput);

            string name = "";
            while(name == "")
            {
                gameOutput.WriteLine("Please enter your name");
                name = userInput.ReadStringInput();
            }
            Player player1 = new HumanPlayer(name, Mark.X, userInput, gameOutput);

            Player player2 = new AIPlayer("Ann", Mark.O);
            game.Run(player1, player2);
        }
    }

}