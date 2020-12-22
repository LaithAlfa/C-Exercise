using System;

namespace ArithmeticSL
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb1, numb2, numb3;
            Console.WriteLine("Please enter 3 numbers below");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Please enter a number");
            numb1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Please enter a number");
            numb2 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Please enter a number");
            numb3 = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("The sum of the Three numbers are: " + sumInt(numb1, numb2, numb3));
            Console.WriteLine("The product of the Three numbers are: " + productInt(numb1, numb2, numb3));
            Console.WriteLine("The average of the Three numbers are: " + averageInt(numb1, numb2, numb3));

            static int sumInt(int num1, int num2, int num3)
            {
                int sum = num1 + num2 + num3;
                return sum;
            }
            static int productInt(int num1, int num2, int num3)
            {
                int product = num1 * num2 * num3;
                return product;
            }
            static int averageInt(int num1, int num2, int num3)
            {
                int average = (num1 + num2 + num3) / 3;
                return average;
            }

            
           
        }
    }
}
