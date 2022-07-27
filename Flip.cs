using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilpTheCoin
{
    internal static class Flip
    {
     public static int headCount = 0;


        public static double Addition(int a ,int b)
        {
            double c = a + b;

            return c;
        }

        public static void CalculatePercentage(int value)
        {

             //int headCount = 0;
             int tailcount = 0;

             double headpercentage = 0;
             double tailpercentage = 0;

           

            for (int i = 0; i < value; i++)
            {
                Random obj = new Random();

                int num = obj.Next(2);

                Console.WriteLine("The random number from system   --- " + num);

                //if(num==0)
                //{
                //    Console.WriteLine("Tail");
                //    tailcount=tailcount + 1;
                //}else if(num==1)
                //{
                //    Console.WriteLine("Head");
                //    headCount++;
                //}

                switch (num)
                {
                    case 0:
                        Console.WriteLine("Tail");
                        tailcount = tailcount + 1;
                        break;
                    case 1:
                        Console.WriteLine("Head");
                        headCount++;
                        break;

                }

            }

            headpercentage = (headCount * 100) / value;

            tailpercentage = (tailcount * 100) / value;

            Console.WriteLine("HeadPercentage ---- " + headpercentage);

            Console.WriteLine("TailPercentage ---- " + tailpercentage);

        }


        public static void Display()
        {

            headCount = 3;
            Console.WriteLine("Display the method");
            
        }
    }
}
