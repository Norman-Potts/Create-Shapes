using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Handles the creation of Ellipse shapes.
    /// </summary>
    public class Ellipse : _2D
    {

        public double majorlength;                 
        public double minorlength;                 

        /// <summary>
        ///     Constructor for Ellipse.
        /// </summary>
        public Ellipse()
        {
          
        }

        /// <summary>
        ///  Manages the user interface for setting data of this shape.
        /// </summary>
        public override void SetData()
        {
            type = "Ellipse";
            bool correctInput = true;
            double filteredInput = 0;
            string rawInput;
            do {
                correctInput = true;
                filteredInput = 0;
                Console.WriteLine("Enter the semi major axis length: ");
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
            majorlength = filteredInput;                      
            do {
                correctInput = true;
                filteredInput = 0;
                Console.WriteLine("Enter the semi minor axis length: ");
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
            minorlength = filteredInput;
        }         

        /// <summary>
        /// Calculates the area of this Ellipse.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            double a = PI * minorlength * majorlength;
            return Math.Round(a, 2);
        }

        /// <summary>
        /// Prints the information about  this shape.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {  
            string message = String.Format("  {0,-8} {1,10}                 Minor Length {2,-1} x Major Length {3,-1} ", type, area, minorlength, majorlength);
            return message;
        }      
    }
}
