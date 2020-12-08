using System;
/*
 * Area of a Circle
 * 12/8/2020
 * Prints out the area of a cirlcle, the length of the circumference. and
 * asks the user if they wish to find the area of more circles
 */
namespace area_of_circle
{
    class CircleAreaMainApp
    {
        static void Main(string[] args)
        {
            const double PI = 3.14; //set the PI as a constant (ie unchanging)

            //Prompt user for input
            Console.Write("Radius of the circle: ");
            string radiusInput = Console.ReadLine();

            //convert user input to numbers (double type) and do math to find area and circumference
            double radius = Convert.ToDouble(radiusInput); //converts user input to a number 
            double area = PI * radius * radius;
            double circumference = PI * 2 * radius;

            //outputs the results using placeholders and formatting values
            Console.WriteLine("The area is: {0:F3} square units " +
                "\nThe circumference is: {1:F3} units ", area, circumference);


            //reprompt user for input
            Console.WriteLine("Enter a new radius to continue or hit Enter to stop: ");
            radiusInput = Console.ReadLine();

            //repeat until user does not enter any values
            while (radiusInput != "")
            {
                radius = Convert.ToDouble(radiusInput);
                area = PI * radius * radius;
                circumference = PI * radius * 2;
                Console.WriteLine("The area is: {0:F3} square units " +
                "\nThe circumference is: {1:F3} units ",area, circumference);

                Console.WriteLine("Enter a new radius to continue or hit Enter to stop:");
                radiusInput = Console.ReadLine();
                
            }


        }
    }
}
