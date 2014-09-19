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


            for (int row = 0; row < 25; row++)
            {
                Console.WriteLine();


                for (int col = 0; col < 39; col++)
                {
                    Console.Write("* ");

                    switch (colorSwitch = row % 3)
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

                    
                    if (row % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}