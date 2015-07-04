using System;

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
    class Program
    {
        static void Main(string[] args)
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
            Console.ReadLine();
        }
    }
}
