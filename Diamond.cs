using System;
using System.Collections.Generic;
using System.Text;

namespace PatternPrograms
{
    class Diamond
    {
        int i, j, k;
        public void RightReverseDouble()
        {
            Console.WriteLine("Enater Any Integer Number for RightReverseDouble Triangle");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (k = n; k >= i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void Pyramid()
        {
            Console.WriteLine("Enter Any Number for MiddleTriangle");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
        public void Pyramid2()
        {
            Console.WriteLine("Enter Any Integer Number For Pyramid Pattern");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = n; j >= 1; j--)
                {
                    if (j > i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(" *");
                    }
                }
                Console.WriteLine();
            }

        }
        public void Pyramid3()
        {
            Console.WriteLine("Enter Any Integer Number For Pyramid Pattern");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (int l = 2; l <= i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void Pyramid4()
        {
            Console.WriteLine("Enter Any Integer Number For Pyramid Pattern");
            int n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                for(j=n;j>=i;j--)
                {
                    Console.Write(" ");
                }
                for(k=1;k<(i*2);k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
