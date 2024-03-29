﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DAVIS AND MICHAEL'S DOMAIN!!
// Davis Rasband and Michael Hutchings created this class
// Harrison Stone and Jonah Allen created the program.cs 
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

            string resultBoard = $"{boardArray[0]} | {boardArray[1]} | {boardArray[2]}\n----------\n{boardArray[3]} | {boardArray[4]} | {boardArray[5]}\n----------\n{boardArray[6]} | {boardArray[7]} | {boardArray[8]}\n";

            return resultBoard;
        }

        // Function to make checking the winner really easy. Just writing everything once. 
        // It takes the board array as an input and which player it is, X or O.
        public bool CheckWinner(string[] boardArray, string player)
        {
            // Declare the result variable
            bool result = false ;

            //Check board for wins

            if (//rows
                (boardArray[0] == player && boardArray[1] == player && boardArray[2] == player) ||
                (boardArray[3] == player && boardArray[4] == player && boardArray[5] == player) ||
                (boardArray[6] == player && boardArray[7] == player && boardArray[8] == player) ||
                //columns
                (boardArray[0] == player && boardArray[3] == player && boardArray[6] == player) ||
                (boardArray[1] == player && boardArray[4] == player && boardArray[7] == player) ||
                (boardArray[2] == player && boardArray[5] == player && boardArray[8] == player) ||
                // diagonals
                (boardArray[0] == player && boardArray[4] == player && boardArray[8] == player) ||
                (boardArray[2] == player && boardArray[4] == player && boardArray[6] == player))
            {
                result = true;
            }

            // If none of the above conditions are met, return false
            else
            {
                result = false;
            }
            // Returning a boolean true or false. 
            return result ;
        }

        // Method to find the winner of a game. It takes the board array as an input
        public string findWinner(string[] board,string player)
        {
            // Declaring local variables for the board and our result. 
            string[] boardArray = board;
            string result = "";
            string playerName = player;

            // Calling our function twice for each player
            bool isWinner = CheckWinner(boardArray, playerName);
            // If statement which will set the result variable who the winner is, or no winner
            if (isWinner)
            {
                result = ($"{playerName} Wins!");
            }

            else
            {
                result = ("No Winner yet.");
            }

            // Returns string result
            return result;
        }
    }
}
