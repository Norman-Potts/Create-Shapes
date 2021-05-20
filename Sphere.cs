using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Class for a sphere three dimensional shape.
    /// </summary>
    public class Sphere : _3D
    {
        public double radius;

        /// <summary>
        /// Constructor for a sphere.
        /// </summary>
        public Sphere()
        {

        }


        /// <summary>
        ///  Manages the user interface for setting data of this shape.
        /// </summary>
        public override void SetData()
        {
            type = "Sphere";
            bool correctInput = true;
            double filteredInput = 0;
            string rawInput;
            do {
                correctInput = true;
                filteredInput = 0;
                Console.WriteLine("Enter the radius of the sphere: ");
                rawInput = Console.ReadLine();
                try {
                    filteredInput = Double.Parse(rawInput);
                    if (filteredInput < 0) {
                        Console.WriteLine("Input must be an double greater than zero.");
                        correctInput = false;
                    }
                } catch (Exception exception) {
                    correctInput = false;
                    Console.WriteLine("Input must be an double.");
                }

            } while (correctInput == false);
            radius = filteredInput;         
        }


        /// <summary>
        /// Calculates the area of this sphere.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {   
            double x = 4 * PI * (radius * radius);
            return Math.Round(x, 2);
        }


        /// <summary>
        /// Calculates the volume of this sphere.
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume()
        {   
            double x = (4.00 / 3.00)* PI * (radius * radius * radius);
            return Math.Round(x, 2);
        }


        /// <summary>
        /// Prints the information about this sphere.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {   
            return String.Format("  {0,-8}{1,10}{2, 15}    Radius {3,-1} r ", type, surfaceArea, Volume, radius);
        }

    }
}
