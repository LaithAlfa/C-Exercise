using System;

namespace ComparingInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //How to program Visual C# 3.16 Comparing Intgers, with methods.
            Console.WriteLine("Please input a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            ComparingIntegers(num1, num2);

            static int ComparingIntegers(int num1, int num2)
            {
                int largeValue = 0;
                if( num1 < num2)
                {
                    largeValue = num2;
                    Console.WriteLine(largeValue + ": is Larger");

                }else if(num1 >num2)
                {

                    largeValue = num1;
                    Console.WriteLine(largeValue + ": is Larger");

                }else
                {
                        Console.WriteLine("There both equal");
                }
                return largeValue;
            }

        }
    }
}
