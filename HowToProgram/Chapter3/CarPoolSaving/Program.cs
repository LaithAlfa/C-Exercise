using System;

namespace CarPoolSaving
{
    class Program
    {
        static void Main(string[] args)
        {
            //How to program Visual C# 3.32 Car-Pool Saving Calculator.

            double totalMiles;
            double gasolineCost; 
            double milesPerGallon; 
            double parkingFees; 
            double tolls;
            
           
            Console.WriteLine("This app is designed to calculate annual savings for car-pooling");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Enter total miles driven per day: ");
            totalMiles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter cost per gallon for gasoline: ");
            gasolineCost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter average miles per gallon: ");
            milesPerGallon = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter parking fees per day: ");
            parkingFees = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter tolls per day: ");
            tolls = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The total is: " + carPoolCalculator(totalMiles, milesPerGallon, gasolineCost, parkingFees, tolls)); 


        static double carPoolCalculator( double num1, double num2, double num3, double num4, double num5)
            {
                // calculate daily driving cost
                  double dailyDrivingCost = (num1 / num2) *  num3 +  num4 + num5;
                  return dailyDrivingCost;
            }
              
        
        }
    }
}
