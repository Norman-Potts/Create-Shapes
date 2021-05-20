using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Class for a square, inherits from a rectangle.
    /// </summary>
    public class Square : Rectangle
    {

        /// <summary>
        /// Constructor for a square.
        /// </summary>
        public Square()
        {
            type = "Square";

            area = CalculateArea();
            
        }

        /// <summary>
        ///  Manages the user interface for setting data of this shape.
        /// </summary>
        public override void SetData()
        {
            bool correctInput = true;
            double Length = 0;
            string rawInput;
            do
            {
                correctInput = true;
                Console.WriteLine("Enter the Length: ");
                rawInput = Console.ReadLine();
                try
                {
                    Length = Double.Parse(rawInput);
                    if (Length < 0)
                    {
                        Console.WriteLine("input must be an number greater than zero.");
                        correctInput = false;
                    }
                }
                catch (Exception exception)
                {
                    correctInput = false;
                    Console.WriteLine("input must be an number");
                }

            } while (correctInput == false);

            length = Length;                       //Sets the private length to length. 
        }

        public override double  CalculateArea()
        {
            // Area of square = Length X Length.
           return  length * length;

        }

        public override string ToString()
        {   //Create a string for the output tables
            string message = String.Format("  {0,-8} {1,10}                  Length {2,-1} ", type, area, length);

            return message;
        }

    }
}
