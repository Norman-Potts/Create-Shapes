using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab2
{  
    /// <summary>
    /// Class for a circle. 
    /// </summary>
    public class Circle : Ellipse
    {
        public double radius;                       //holds the value for the radius    

        /// <summary>
        ///  Constructor for a circle.
        /// </summary>
        public Circle()
        {
           
        }

        /// <summary>
        ///  Manages the user interface for setting data of this shape.
        /// </summary>
        public override void SetData()
        {
            type = "Circle";
            bool correctInput = true;
            double r = 0;
            string rawInput;
            do {
                correctInput = true;
                Console.WriteLine("Enter the radius: ");
                rawInput = Console.ReadLine();
                try {
                    r = Double.Parse(rawInput);
                    if (r < 0) {
                        Console.WriteLine("input must be an number greater than zero.");
                        correctInput = false;
                    }
                } catch (Exception exception) {
                    correctInput = false;
                    Console.WriteLine("input must be an number");
                }
            } while (correctInput == false);
            radius = r;                     
        }

        /// <summary>
        /// Calcualates area of shape.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {            
            double a =  PI * (radius * radius);
            return Math.Round(a, 2);
        }


        /// <summary>
        ///  Prints out the informationa bout the shape.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("  {0,-8} {1,10}                Radius {2,-1} ", type, area, radius);
        }
    }
}
