using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Class for this Tetrahedron shape.
    /// </summary>
    class Tetrahedron :_3D
    {
        public double length;

        /// <summary>
        ///  Constructor for this Tetrahedron.
        /// </summary>
        public Tetrahedron() 
        {

        }


        /// <summary>
        ///  Manages the user interface for setting data of this shape.
        /// </summary>
        public override void SetData()
        {
            type = "Tetrahedron";
            bool correctInput = true;
            double Length = 0;
            string rawInput;
            do {
                correctInput = true;
                Console.WriteLine("Enter the Length: ");
                rawInput = Console.ReadLine();
                try {
                    Length = Double.Parse(rawInput);
                    if (Length < 0) {
                        Console.WriteLine("input must be an number greater than zero.");
                        correctInput = false;
                    }
                } catch (Exception exception) {
                    correctInput = false;
                    Console.WriteLine("input must be an number");
                }
            } while (correctInput == false);
            length = Length;                
        }



        /// <summary>
        ///  Calcualtes area of this shape.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {   
            double rootof3 = Math.Sqrt(3.00);
            double x = rootof3*(length*length);
            return Math.Round(x, 2); 
        }



        /// <summary>
        ///  Calculates volume of this shape.
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume()
        {   
           double x = (length * length * length) / (6.00 * (Math.Sqrt(2.00)));      
           return Math.Round(x, 2);  
        }



        /// <summary>
        /// Prints the information about this shape.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {  
            return String.Format("  {0,-11}{1,8}{2, 10}         Length{3,-1}  ", type, surfaceArea, Volume, length);   
        }
    }
}
