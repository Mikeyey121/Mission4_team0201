using Mission4_team0201;
using System;


class Driver
{
    static char currentPlayer = 'X';
    static string[] gameboard = new string[9];
    static int position = 0;
    static Supporting sp = new Supporting();

    public static void Main()
    {
        Console.WriteLine("Welcome to Tic Tac Toe!");
        bool play = true;
        createBoard();

        do
        {
            sp.printBoard(gameboard);
            playerMove();

            if (sp.findWinner(gameboard, currentPlayer.ToString()) != "No Winner yet.")
            {
                sp.printBoard(gameboard);
                Console.WriteLine(sp.findWinner(gameboard, currentPlayer.ToString()));
                play = false;
            }
            //switch player for next turn
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';

        } while (play && !IsBoardFull());
        //Message for a draw if the board is full
        if (IsBoardFull() && sp.findWinner(gameboard, currentPlayer.ToString()) == "No Winner yet.")
        {
            sp.printBoard(gameboard);
            Console.WriteLine("It's a draw!");
        }

    }
    
    public static void createBoard()
    {
        for (int position = 0; position < 9; position++)
        {
            gameboard[position] = ' '.ToString();
        }
    }

    public static void playerMove()
    {

        Console.Write("Player " + currentPlayer + " select position (1-9): ");
        position = int.Parse(Console.ReadLine()) - 1;

        if (position >= 0 && position < 9 && !IsBoardFull() && gameboard[position] == " ")
        {
            gameboard[position] = currentPlayer.ToString();
        }
        else
        {
            Console.WriteLine("Please select a valid position");
            playerMove();
        }
        //Print board after each input and repeat through the playerMove method after alternating currentPlayer to "O";   
        sp.printBoard(gameboard);
    }

    public static bool IsBoardFull()
    {
        for (int i = 0; i < 9; i++)
        {
            if (gameboard[i] == " ")
            {
                return false;
            }
        }
        return true;
    }
}