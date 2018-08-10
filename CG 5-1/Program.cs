using System;

namespace CG_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Have the user input their first name

            Console.WriteLine("Hello.  Please enter your first name.");
            string First = Console.ReadLine();

            //Have the user input their last name

            Console.WriteLine("Thank you.  Now please enter your last name.");
            string Last = Console.ReadLine();


            //Create method that combines the names and outputs them
            Combo(First);
            Combo(Last);


         }
        private static string Combo(string First, string Last)
    { Console.WriteLine($"Nice to meet you {First} {Last}");
    }


}
