﻿using System;

namespace CG_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create method that combines the names and outputs them
            Combo();


            

            Console.ReadLine();
        }

        private static void Combo()
        {
            //Have the user input their first name

            Console.WriteLine("Hello.  Please enter your first name.");
            string FirstName = Console.ReadLine();

            //Have the user input their last name

            Console.WriteLine("Thank you.  Now please enter your last name.");
            string LastName = Console.ReadLine();

            Console.WriteLine($"Nice to meet you {FirstName} {LastName}");
        }


    }

}
