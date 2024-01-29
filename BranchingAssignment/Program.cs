using System;

namespace BranchingAssignment
{
    internal class Program
    {
        public static void Main()
        { //Your job is to create a console-based application for getting a shipping quote for a package.
//REQUIREMENTS:
//The first line of the program must be: “Welcome to Package Express.Please follow the instructions below.”

               Console.WriteLine("Welcome to Package Express. Please follow the instructions below:");
           // The user must then be prompted for the package weight.
           //If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express.Have a good day.” At this point the program would end.
            Console.WriteLine("Please enter the package weight:");
            int packageWeight = int.Parse(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("The package is too heavy to be shipped via Package Express at this time. Have a good day.");
            }
            //The user must then be prompted for the package width.
           // Then the package height.
            //Then the package length.
            else if (packageWeight < 50)
                Console.WriteLine("Please enter package width: ");

            int packageWidth = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter package height: ");
            int packageHeight = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int packageLength = int.Parse(Console.ReadLine());
            //Next, multiply the three dimensions(height, width, &length) together, and multiply the product by the weight.
            ////Finally, divide the outcome by 100.
            int shippingQuote = ((packageWidth * packageHeight * packageLength)*packageWeight / 100);
            //The result of that calculation is the quote.
            //Display the quote to the user as a dollar amount.
            Console.WriteLine("Your estimated total for shipping this package is: $" + shippingQuote  + ".00  \n Thank you!");

        }

    }
}

