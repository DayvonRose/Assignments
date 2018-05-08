
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5

{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////
            //  Display chest board  //
            /////////////////////////
            System.Console.WriteLine("          -Chest Quest-       ");
            string[][] board = new string[8][];       
            for (int i = 0; i < 8; i++)
            {
                System.Console.WriteLine("+---+---+---+---+---+---+---+---+");
                board[i] = new string[8];
                for (int j = 0; j < 8; j++)
                {

                    board[i][j] = "  ";
                    if (i <= 1 || i >= 6)
                    {
                        board[i][j] = "X ";
                    }
                    System.Console.Write("| " + board[i][j]);
                }
                System.Console.WriteLine("|");
            }
            System.Console.WriteLine("+---+---+---+---+---+---+---+---+");


            System.Console.WriteLine(" ");

            ///////////////////////////////////////////////////
            //  Variables for coordination and destination  //
            /////////////////////////////////////////////////

            int cordx = 0;
            int cordy = 0;
            int destx = 0;
            int desty = 0;

            //////////////////////////////
            //  Asks for user's input  //
            ////////////////////////////
            while (cordx <= 7 && cordx >= 0 && cordy <= 7 && cordy >= 0 && destx <= 7 && destx >= 0 && desty <= 7 && desty >= 0)
            {
                System.Console.WriteLine("       -Enter your coordinates-");
                System.Console.WriteLine("       *Please only use numbers 0-7");
                System.Console.WriteLine();
                System.Console.Write("X-Coordinate  :   ");
                cordx = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine();
                System.Console.Write("Y-Coordinate  :   ");
                cordy = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine();
                System.Console.Write("X-Destination:   ");
                destx = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine();
                System.Console.Write("Y-Destination:   ");
                desty = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine();
                System.Console.Clear();

                System.Console.WriteLine("          -Chest Quest-       ");
                if (cordx <= 7 && cordx >= 0 && cordy <= 7 && cordy >= 0 && destx <= 7 && destx >= 0 && desty <= 7 && desty >= 0)
                {
                    for (int i = 0; i < 8; i++)

                    {

                        System.Console.WriteLine("+---+---+---+---+---+---+---+---+");
                        board[i] = new string[8];

                        for (int j = 0; j < 8; j++)
                        {
                            board[i][j] = "  ";
                            if (i <= 1 || i >= 6)
                            {
                                board[i][j] = "X ";
                            }
                            board[cordx][cordy] = "  ";
                            board[destx][desty] = "X ";
                            System.Console.Write("| " + board[i][j]);
                        }
                        System.Console.WriteLine("|");
                    }
                    System.Console.WriteLine("+---+---+---+---+---+---+---+---+");
                }
            }
            System.Console.WriteLine("Error...");
            System.Console.WriteLine("Press any key to end the program...");
            System.Console.ReadKey();
        }
    }
}