using Mission4_team0201;

internal class Driver
{


    public static void Main()
    {
        char currentPlayer = 'X';
        string[,] gameboard = new string[3, 3];

        Supporting sp = new Supporting();

        Console.WriteLine("Welcome to Tic Tac Toe!");

        Driver.createBoard();
        //checkWinner();
        bool play = true;

        do
        {
            sp.printBoard(gameboard);
            playerMove();

            if (sp.findWinner(gameboard, currentPlayer))
            {
                sp.printBoard(gameboard);
                Console.Write("Player " + currentPlayer + " wins!");
                play = false;
            }

            //switch player for next turn

        } while (play == true);

        //Message for a draw if the board is full

    }
    
    public static void createBoard()
    {
        for (int row = 0; row < 3; row++)
        {
            for(int col = 0; col < 3; col++)
            {
                gameboard[row, col] = ' ';
            }
        }
    }

    public static void playerMove()
    {

        Console.Write("Player " + currentPlayer + " select row: ");
        int row = int.Parse(Console.ReadLine()) - 1;

        if (row >= 0 && row <= 2)
        {
            Console.Write("Player " + currentPlayer + " select column: ");
            int col = int.Parse(Console.ReadLine()) - 1;

            if ((col >= 0 && col <= 2) && gameboard[row,col] == ' ')
            {
                gameboard[row, col] = currentPlayer;
            }
            else
            {
                Console.WriteLine("Please select a valid column");
                playerMove();
            }
        }
        else
        {
            Console.WriteLine("Please select a valid row");
            playerMove();
        }
     //Print board after each input and repeat through the playerMove method after alternating currentPlayer to "O";   
    }
}