class Driver()
{
    public void Main()
    {
        Console.WriteLine("Welcome to Tic Tac Toe!");

        char currentPlayer = "X";

        Console.Write("Select row");
        int row = int.Parse(Console.ReadLine());

        if (int.Parse(row, row <= 3 && row >= 1)
        {
            Console.Write("Select column");
            int col = int.Parse(Console.ReadLine());

            if (int.Parse(col, col <= 3 && col >= 1)
            {
                
            }
            else
            {
                Console.WriteLine("Please select a valid column");
            }
        }
        else
        {
            Console.WriteLine("Please select a valid row");
        }


        char[,] gameboard = new char[row, col];
    }
}