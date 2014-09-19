using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_rita_med_asterisker
{
    class Program
    {
        static void Main(string[] args)
        {
            int colorSwitch = 0;


            for (int col = 0; col < 39; col++)
            {
                Console.WriteLine();

                for (int row = 0; row < 25; row++)
                {
                    switch (colorSwitch = col % 3)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;

                    }

                    Console.Write("* ");
                    if (row == 0)
                    {
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}