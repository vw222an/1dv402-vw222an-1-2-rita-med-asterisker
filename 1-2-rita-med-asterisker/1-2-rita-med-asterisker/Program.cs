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
            for (int col = 0; col < 39; col++)
            {
                Console.WriteLine();

                for (int row = 0; row < 25; row++)
                {
                    Console.Write("* ");
                    if(row == 0)
                    {
                    Console.Write(" ");
                    }
                }
           }
            Console.WriteLine();
        }
    }
}
