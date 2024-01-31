using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DAVIS AND MICHAEL'S DOMAIN!!
namespace Mission4_team0201
{
    /*  - Receive the “board” array from the driver class
        - Contain a method that prints the board based on the information passed to it
        - Contain a method that receives the game board array as input and returns if there is a
            winner and who it was */
    internal class Supporting
    {
        // Create a method that receives the board array from the driver class and prints the board based on the guesses received
        public string printBoard(string[] board)
        {
            string[] boardArray = board;

            string resultPrint = $"{boardArray[0]}|{boardArray[1]}|{boardArray[2]}\n----------------\n{boardArray[3]}|{boardArray[4]}|{boardArray[5]}\n--------------------\n{boardArray[6]}|{boardArray[7]}|{boardArray[8]}\n";

            return resultPrint;
        }
    }
}
