using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Class for a box, a three dimentsonal shape.
    /// </summary>
    public class Box : _3D 
    {
        public double length;
        public double width;
        public double height;



        /// <summary>
        ///  Constructor for box.
        /// </summary>
        public Box()
        {
        }


        /// <summary>
        ///  Manages the user interface for setting data of this shape.
        /// </summary>
        public override void SetData()
        {
            type = "Box";
            bool correctInput = true;
            double filteredInput = 0;
            string rawInput;

            do {
                correctInput = true;
                filteredInput = 0;
                Console.WriteLine("Enter the length: ");
                rawInput = Console.ReadLine();
                try {
                    filteredInput = Double.Parse(rawInput);
                    if (filteredInput < 0) {
                        Console.WriteLine("Input must be an number greater than zero.");
                        correctInput = false;
                    }
                } catch (Exception exception) {
                    correctInput = false;
                    Console.WriteLine("Input must be an number");
                }

            } while (correctInput == false);
            length = filteredInput;         

            do {
                correctInput = true;
                filteredInput = 0;
                Console.WriteLine("Enter the width: ");
                rawInput = Console.ReadLine();
                try {
                    filteredInput = Double.Parse(rawInput);
                    if (filteredInput < 0) {
                        Console.WriteLine("Input must be an integer greater than zero.");
                        correctInput = false;
                    }
                } catch (Exception exception) {
                    correctInput = false;
                    Console.WriteLine("Input must be an integer.");
                }
            } while (correctInput == false);
            width = filteredInput;
            
            do {
                correctInput = true;
                filteredInput = 0;
                Console.WriteLine("Enter the height: ");
                rawInput = Console.ReadLine();
                try {
                    filteredInput = Double.Parse(rawInput);
                    if (filteredInput < 0) {
                        Console.WriteLine("Input must be an integer greater than zero.");
                        correctInput = false;
                    }
                } catch (Exception exception) {
                    correctInput = false;
                    Console.WriteLine("Input must be an integer.");
                }

            } while (correctInput == false);
            height = filteredInput;     

        }



        /// <summary>
        ///  Calculates the area.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {   
            
            surfaceArea = (2 * length * height) + (2 * width * height) + (2 * width * length);
            return surfaceArea;
        }



        /// <summary>
        ///  Calculates the volume.
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume()
        {
            double V =  length * width * height;
            return V;
        }



        /// <summary>
        /// Produces a string printing out the information about the shape.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("  {0,-8}{1,11}{2, 11}       Length {3,-1} x Width {4,-1} x Height {5,-1}", type, surfaceArea, Volume, length, width, height);
            
        }
    }
}
