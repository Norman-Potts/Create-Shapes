using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    /// <summary>
    ///  Handles the Triangle shape. Inherits from two dimentional shape.
    /// </summary>
    class Triangle : _2D
    {
        public double width;
        public double length;

        /// <summary>
        /// Constructs triangle shapes.
        /// </summary>
        public Triangle()
        {
        }

        /// <summary>
        ///  Manages the user interface for setting data of this shape.
        /// </summary>
        public override void SetData()
        {
            type = "Triangle";
            bool correctInput = true;
            double filteredInput = 0;
            string rawInput;
            do {
                correctInput = true;
                filteredInput = 0;
                Console.WriteLine("Enter the base: ");
                rawInput = Console.ReadLine();
                try {
                    filteredInput = Double.Parse(rawInput);
                    if (filteredInput < 0) {
                        Console.WriteLine("input must be an double greater than zero.");
                        correctInput = false;
                    }
                } catch (Exception exception) {
                    correctInput = false;
                    Console.WriteLine("input must be an double");
                }

            } while (correctInput == false);
            length = filteredInput;                   
            do {
                correctInput = true;
                filteredInput = 0;
                Console.WriteLine("Enter the height: ");
                rawInput = Console.ReadLine();
                try {
                    filteredInput = Double.Parse(rawInput);
                    if (filteredInput < 0) {
                        Console.WriteLine("input must be an integer greater than zero.");
                        correctInput = false;
                    }
                } catch (Exception exception) {
                    correctInput = false;
                    Console.WriteLine("input must be an integer");
                }

            } while (correctInput == false);
            width = filteredInput;   
        }

        /// <summary>
        /// Calculates area of shape.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {            
            double a = (length * width) / 2;
            return Math.Round(a, 2); 
        }

        /// <summary>
        ///  Prints the information about the shape.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {   
            string message = String.Format("  {0,-8}{1,11}                 Height {2,-1} X Base {3,-1}", type, area, length, width);
            return message;
        }

    }
}
