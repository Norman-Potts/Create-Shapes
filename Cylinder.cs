using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    /// <summary>
    /// Class for a Cylinder.
    /// </summary>
    class Cylinder : _3D
    {

        public double radius;
        public double height;

        /// <summary>
        /// Constructor for a cylinder shape.
        /// </summary>
        public Cylinder()
        {
           
        }

        /// <summary>
        ///  Manages the user interface for setting data of this shape.
        /// </summary>
        public override void SetData()
        {
            type = "Cylinder";
            bool correctInput = true;
            double filteredInput = 0;
            string rawInput;
            do {
                correctInput = true;
                filteredInput = 0;
                Console.WriteLine("Enter the height of the cylinder: ");
                rawInput = Console.ReadLine();
                try {
                    filteredInput = Double.Parse(rawInput);
                    if (filteredInput < 0)
                    {
                        Console.WriteLine("input must be an double greater than zero.");
                        correctInput = false;
                    }
                }
                catch (Exception exception)
                {
                    correctInput = false;
                    Console.WriteLine("input must be an double");
                }
            } while (correctInput == false);
            height = filteredInput;
            correctInput = true;
            filteredInput = 0;
            rawInput = "-3";       
            do {
                correctInput = true;
                filteredInput = 0;
                Console.WriteLine("Enter the radius of the cylinder: ");
                rawInput = Console.ReadLine();
                try {                
                    filteredInput = Double.Parse(rawInput);
                    if (filteredInput < 0) {
                        Console.WriteLine("input must be a number greater than zero.");
                        correctInput = false;
                    }
                } catch (Exception exception) {
                    correctInput = false;
                    Console.WriteLine("input must be an number");
                }

            } while (correctInput == false);
            radius = filteredInput;
        }



        /// <summary>
        /// Calcualtes the area for Cylinder.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {  
            double x = (2 * PI * radius * height) + (2 * PI * (radius * radius));
            return Math.Round(x, 2);
        }



        /// <summary>
        /// Calculates the volume of this cylinder.
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume()
        {  
            double x = PI * (radius * radius) * height;
            return Math.Round(x, 2);
        }



        /// <summary>
        /// Prints the information about this Cylinder. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {  
            return String.Format("  {0,-8} {1,10} {2, 11}      Radius {3,-1} x Height {4,-1} ", type, surfaceArea, Volume, radius, height);
        }
    }
}
