using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic C# Exercises");
    //1. Write a C# Sharp program to print Hello and your name in a separate line:
             // Basic method
            Console.WriteLine("Hello");
            Console.WriteLine("John Deer");
             //with user input//
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.Write("Hello \n" + name); 
            Console.WriteLine(" ");
            
    //2. Write a C# Sharp program to print the sum of two numbers.
            //Basic Method
            int x = 4;
            int y = 3;
            Console.WriteLine(x + y);
            //with User input
            Console.WriteLine("please enter a number ");
           // int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number ");
           // int num2 = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("the sum of the two number are : " + (num1 + num2));
    //5. Write a C# Sharp program to swap two numbers.
          // int num1 = 75;
          // int num2 = 95;
            Console.WriteLine("please Input the first number ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Input the second number ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------");
            Console.WriteLine("-------------------");
            Console.WriteLine("-------------------");
           
            num1 = num1 +  num2; // number 1 will equal: num1 + num2 the value will be saved as num1
            //Console.WriteLine(num1); // i added these to display the proper eqaution: the output is 170
            num2 = num1 - num2; // number 2 will equal : num1 which the new value from our saved eqaution which is 170. Minus with our second number that the user inputted wich is 95
            //Console.WriteLine(num2); // i added these to display the proper eqaution: the output is 75
            num1 = num1 - num2;  //number 1 will now equal: num1 which is still the value 170 since we changed it to be so in the first round. Minus the num2 from the output of the second eqaution with is 75        
            //Console.WriteLine(num1); // i added these to display the proper eqaution: theoutput will be 95

            //that is how swaping variable work without useing a third variable or a temp variable. This will also work with user inputs as well.....

            Console.WriteLine("After Swapping : ");
            Console.WriteLine(num1);
            Console.WriteLine(num2);

            //will add a readme file shortly

            



           

        }
    }
}
