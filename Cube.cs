using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    ///  Cube a three dimensional shape inherits box.
    /// </summary>
    class Cube : Box
    {

        /// <summary>
        ///  Constructor for Cube.
        /// </summary>
        public Cube()
        {

           
        }



        /// <summary>
        ///  Manages the user interface for setting data of this shape.
        /// </summary>
        public override void SetData()
        { 
            type = "Cube"; 
            bool correctInput = true;
            double filteredInput = 0;
            string rawInput;
            do {
                correctInput = true;
                filteredInput = 0;
                Console.WriteLine("Enter the Length: ");
                rawInput = Console.ReadLine();
                try {
                    filteredInput = Double.Parse(rawInput);
                    if (filteredInput < 0)
                    {
                        Console.WriteLine("input must be an double greater than zero.");
                        correctInput = false;
                    }
                } catch (Exception exception) {
                    correctInput = false;
                    Console.WriteLine("input must be an double");
                }
            } while (correctInput == false);
            length = filteredInput;                     
            width = filteredInput;
            height = filteredInput;
        }



        /// <summary>
        /// Calculates Area of the shape.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {   
            return 6*(length * length);            
        }



        /// <summary>
        ///  Prints the information about the shape.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {   
            return String.Format("  {0,-8}{1,11}{2, 11}        Length {3,-1}   ", type, surfaceArea, Volume, length);            
        }
    }
}
