using FilpTheCoin;

namespace FlipTheCoin
{
    class Program
    {
        public static void Main(string[] args)
        {

            //  Console.WriteLine("Please enter the number of Flips");
            //  int filps = Convert.ToInt32(Console.ReadLine());

            //  Flip.CalculatePercentage(filps);
            ////  Flip.CalculatePercentage(filps,"flip the copin");

            //  Flip.Display();

            //  Flip.headCount = 5;

            int num1 = Convert.ToInt32(Console.ReadLine());

            int num2 = Convert.ToInt32(Console.ReadLine());

            double add=Flip.Addition(num1, num2);

            double num3 = add + 5;

            Console.WriteLine(num3);





        }
    }
}
