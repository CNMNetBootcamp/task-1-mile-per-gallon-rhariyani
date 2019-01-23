using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:  For local variables they need to be lowercase
            double Miles = 0;
//input
            Console.WriteLine("Please enter starting Miles:");
            // TODO: Remove the var keyword and use the correct data type. Local variables should be lowercase
            var SM = Single.Parse(Console.ReadLine());
            // TODO: Remove the var keyword and use the correct data type. Local variables should be lowercase
            Console.WriteLine("Please enter Ending Miles:");
            var EM = Single.Parse(Console.ReadLine());
            // TODO: Remove the var keyword and use the correct data type. Local variables should be lowercase
            Console.WriteLine("Please enter Gasoline Used:");
            var Gas = Single.Parse(Console.ReadLine());

            //Process
            //TODO: Calculation is incorrect
            Miles = EM - SM / Gas;

            //output    
            Console.WriteLine("Total miles per gallon is " + Miles);
            Console.ReadLine();
        }
    }
}
