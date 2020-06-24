using System;
using System.Collections.Generic;
using System.Text;

namespace PatternPrograms
{
    class ReversePyramid
    {
        int n, i, j, k;
        public void Reverse()
        {
            Console.WriteLine("Enter Integer Number for Reverse Pyramid");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (k = 1; k <= i; k++)
                {
                    Console.Write(" ");
                }
                for (j = n; j >= i; j--)
                {
                    Console.Write("*");
                }

                for (int l = n-1; l >= i; l--)
                {
                    Console.Write("*");
                }
                for (int m = 1; m <= i; m++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
