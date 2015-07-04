using System;
using System.Runtime.CompilerServices;

/*
For this assignment, you will create the pattern of a chess board that is 8 x 8.
Use X and O to represent the squares.

Create the appropriate nested looping structure to output the characters in an 8 x 8 grid
on the screen using Console.Write() or Console.WriteLine() as appropriate.
Include a decision structure to ensure that alternate rows start with opposite characters
as a real chess board alternates the colors among rows.
This is what your output should look like.

XOXOXOXO
OXOXOXOX
XOXOXOXO
OXOXOXOX
XOXOXOXO
OXOXOXOX
XOXOXOXO
OXOXOXOX

Grading Criteria:

1. Used a nested loop
2. Used a decision structure to flip row output
3. Output is correct per above image
*/
namespace Module_2
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Me:");
            myAnswer();
            Console.WriteLine("Peer 1:");
            peer1Answer();
            Console.WriteLine("Peer 2:");
            peer2Answer();
            Console.WriteLine("Peer 3:");
            peer3Answer();
            Console.ReadLine();
        }
        private static void myAnswer()
        {
            for (int indexRow = 1; indexRow <= 8; indexRow++)
            {
                for (int indexColumn = 1; indexColumn <= 8; indexColumn++)
                {
                    if (indexRow % 2 == 0)
                    {
                        if (indexColumn % 2 == 0)
                        {
                            Console.Write('X');
                        }
                        else
                        {
                            Console.Write('O');
                        }
                    }
                    else
                    {
                        if (indexColumn % 2 == 0)
                        {
                            Console.Write('O');
                        }
                        else
                        {
                            Console.Write('X');
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        private static void peer1Answer()
        {
            //for easy changing symbols
            char mX = 'X';
            char mO = 'O';

            //for easy changing board size
            int maxI = 8;
            int maxJ = 8;

            for (int i = 0; i < maxI; i++)
            {
                for (int j = 0; j < maxJ; j++)
                    if ((i + j) % 2 == 0) Console.Write(mX);
                    else Console.Write(mO);
                //new line
                Console.Write('\n');
            }
        }

        private static void peer2Answer()
        {
            int i, n, move;
            //loop to make the columns
            for (i = 0; i < 9; i++)
            {
                if (i % 1 == 0)
                {
                    move = 1;
                }
                else
                {
                    move = 0;
                }
                for (n = 1; n < 9; n++)
                {
                    if (n % 2 == move)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write("X");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void peer3Answer()
        {
            int x = 0;
            string line1 = "XOXOXOXO";
            string line2 = "OXOXOXOX";

            while (x < 8)
            {
                if ((x % 2) == 0)
                    Console.WriteLine(line1);
                else
                    Console.WriteLine(line2);
                x++;
            }
        }
    }
}