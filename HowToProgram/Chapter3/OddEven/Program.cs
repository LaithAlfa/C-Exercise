using System;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {   
            //How to program Visual C# 3.24, 3.25 odd or even, and multiples.
            int number1, number2;
            Console.WriteLine("PLease Enter a number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PLease Enter a number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            OddOrEven(number1);
            multiplesInt(number1, number2);

            static int OddOrEven(int num)
            {
                if(num % 2 == 0)
                {
                    Console.WriteLine($"The number you entered {num} is Even");
                }else
                {
                    Console.WriteLine($"The number you entered {num} is Odd");
                }
                return num;
            }

            static int multiplesInt(int num1, int num2)
            {
                int result = num1 % num2;
                //to check if the first number is a multiple of the second number, divide the first number to the second if there is a remainder. if there is a remainder, then it is not a multiple of the second number
                if(num1 % num2 == 0)
                {
                    Console.WriteLine($"{result}: The first number {num1} is a multiple of the second number {num2}");
                }
                else
                {
                    Console.WriteLine($"{result}: The first number {num1} is not a multiple of the second number {num2}");
                }

                return result;
            }
        }
    }
}
