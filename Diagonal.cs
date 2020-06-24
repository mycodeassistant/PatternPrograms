using System;
using System.Collections.Generic;
using System.Text;

namespace PatternPrograms
{
    class Diagonal
    {
        int n, i, j, k;
        public void First()
        {
            Console.WriteLine("Enter Any Integer Number for Diagonal");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (k = 1; k <= i; k++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void First2()
        {
            Console.WriteLine("Enter Any Integer Number for Diagonal");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i >= 2 && j <= i - 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
        public void HollowPyramid()
        {
            Console.WriteLine("Enter Any Integer Number for HollowPyramid");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k < (2 * i); k++)
                {
                    if (k > 1 && k < (i * 2) - 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }

                Console.WriteLine();
            }
        }
        public void CrossDiagonal()
        {
            Console.WriteLine("Enter Any Integer Number for CrossDiagonal");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i == j || i + j == n - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        //This HollowSquare Program works only 4/n=4 number
        public void HollowSquare()
        {
            Console.WriteLine("Enter Any Integer Number for HollowSquare");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=1;i<=n;i++)
            {
                for(j=1;j<=n;j++)
                {
                    if (i >= 2 && j>=2 && i<=3 && j<=3)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
