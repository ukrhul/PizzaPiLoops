/* Name of Program: PrimeNumber
 * Group Members: Rahul,Harry,Yashu
 * Date: 1 Mar 2017
 * Description: This program will prompt user to enter the diameter of a pizza 
 *              and then program calculates its area 
 *              and display the number of slices cut under the area. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPiLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            //DECLARATIONS:

            //VARIABLES:
            string userInput;                                               
            double diameter;
            int maximumSlices;
            double pizzaArea;
            double sliceArea;
            double radius;
            bool isValid = true;

            //CONSTANTS:
            const double minimumDiameter = 12.0;
            const int smallSliceMaximum = 8;
            const double smallDiameter = 20;
            const int mediumSliceMaximum = 12;
            const double mediumDiameter = 24;
            const int largeSliceMaximum = 16;
            const double largeDiameter = 30;
            const int extraLargeSliceMaximum = 24;
            const double maximumDiameter = 36;

            //INPUT

            Console.Write("Please enter diameter of your pizza: ");
            userInput = Console.ReadLine();

            do
            {
                Console.Clear();
                isValid = true;

                if (!(Double.TryParse(userInput, out diameter)))
                {

                    Console.WriteLine("\nPlease enter a numeric diameter");
                    isValid = false;
                }
                else if ((diameter < minimumDiameter) || (diameter > maximumDiameter))
                {
                    Console.WriteLine("\nPlease enter a diameter between " + minimumDiameter + " and " + maximumDiameter);
                    isValid = false;
                }

                if (isValid)
                {
                    //OUTPUT HEADER
                    Console.Write("\nPizza Diameter: " + diameter + "\"");
                    Console.Write("\n===========================================================");

                    radius = diameter / 2;
                    pizzaArea = Math.PI * Math.Pow((radius), 2);

                    do
                    {


                        if (diameter <= maximumDiameter)
                        {
                            maximumSlices = extraLargeSliceMaximum;
                            sliceArea = pizzaArea / maximumSlices;
                            Console.Write("\nCut in " + maximumSlices + " in a slice area of " + Math.Round(sliceArea, 2) + "\" per slice");


                            if (diameter <= largeDiameter)
                            {
                                maximumSlices = largeSliceMaximum;
                                sliceArea = pizzaArea / maximumSlices;
                                Console.Write("\nCut in " + maximumSlices + " in a slice area of " + Math.Round(sliceArea, 2) + "\" per slice");


                                if (diameter <= mediumDiameter)
                                {
                                    maximumSlices = mediumSliceMaximum;
                                    sliceArea = pizzaArea / maximumSlices;
                                    Console.Write("\nCut in " + maximumSlices + " in a slice area of " + Math.Round(sliceArea, 2) + "\" per slice");


                                    if (diameter <= smallDiameter)
                                    {
                                        maximumSlices = smallSliceMaximum;
                                        sliceArea = pizzaArea / maximumSlices;
                                        Console.Write("\nCut in " + maximumSlices + " in a slice area of " + Math.Round(sliceArea, 2) + "\" per slice");

                                    }
                                }
                            }
                        }

                    } while (diameter < minimumDiameter || diameter > maximumDiameter);


                    Console.Write("\n\nPlease enter the diameter of your pizza (0 to end program): ");
                    userInput = Console.ReadLine();

                }
            } while (userInput != "0");
        }
    }
}
        
    
