﻿using System;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opening line
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //Inquire the package weight
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            else
            { 
                Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());
            int total = weight + width + height + length;

            if (total > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }

            else
            {
                int product = width * height * length * weight;
                int quote = product / 100;
           
             Console.WriteLine("Your estimated total for shipping this package is:" + quote +
            "Thank you!");
                    
            }
            }  
        }
    }
}
