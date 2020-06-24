using System;

namespace PatternPrograms
{

    class Program
    {
        public void Triangle()
        {
            Console.WriteLine("Enter a integer Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        //create methods 
        void DiamondOne()
        {
            int i, j, count = 1, number;
            Console.Write("Enter number of rows:");
            number = int.Parse(Console.ReadLine());
            count = number - 1;
            for (j = 1; j <= number; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * j - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (j = 1; j <= number - 1; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - j) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        //create method
        void Diamond1()
        {
            int i, j, k, number;
            Console.WriteLine("Enter any number");
            number = int.Parse(Console.ReadLine());
            for (i = 0; i <= number; i++)
            {
                for (j = 0; j < number - i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(" ");
            }
        }
        public void LeftTriangle()
        {
            Console.WriteLine("Enter Any Integer Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void LeftReverse()
        {
            Console.WriteLine("Enter Any Integer Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void RightTriangle()
        {
            Console.WriteLine("Enater Any Integer Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void RightReverseTriangle()
        {
            Console.WriteLine("Enter Integer Number For Right Reverse Triangle");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(" ");
                }
               for(int k=n;k>=i;k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //create obj of class
            Program program = new Program();
            //method call
            Diamond diamond = new Diamond();
            // program.DiamondOne();
            //program.Diamond1();
            // program.Triangle();
            // Console.WriteLine();
            // program.LeftTriangle();
            // program.RightTriangle();
            //program.LeftReverse();
            // program.RightReverseTriangle();
            diamond.Pyramid2();
        }
    }
}
