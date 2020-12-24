using System;

namespace DigitsInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //How to program Visual C# 3.28(Digits of an Intger)
            int input = 0;
            // 42339
            // 4        2       3     3     9
            //10,000   1,000   100    10    1

            Console.WriteLine("Please enter a Five Digits number");
            input = Convert.ToInt32(Console.ReadLine());
            if( input >= 100000)
            {
                Console.WriteLine("You have entered more then five Digits");

            }else if(input <= 10000)
            {
                Console.WriteLine("You have entered less then five Digits");

            }else{
                int number1 = input % 10;
                int number2 = (input % 100) /10 ;
                int number3 = (input % 1000) /100 ;
                int number4 = (input % 10000) /1000 ;
                int number5 = (input /10000);

               
                Console.WriteLine("-------------------------");
                Console.WriteLine($"{input} after three spaces: {number5}   {number4}   {number3}   {number2}   {number1}   ");
              
                }
           

        }
    }
}
