using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    ///     The class for a rectangle.
    /// </summary>
    public class Rectangle: _2D
    {
        public double length;                       //holds the value for the length
        public double width;                        //hold the value for the width


        /// <summary>
        ///  Constructor for rectangle.
        /// </summary>
        public Rectangle()
        {
            
        }


        /// <summary>
        ///  Manages the user interface for setting data of this shape.
        /// </summary>
        public override void SetData()
        {
            type = "Rectangle";

            bool correctInput = true;
            double filteredInput = 0;            
            string rawInput;
            do
            {
                correctInput = true;
                filteredInput = 0;            
                Console.WriteLine("Enter the Length: ");
                rawInput = Console.ReadLine();
                try
                {
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

            length = filteredInput;                       //Sets the private length to length. 
        
        
            do
            {
                correctInput = true;
                filteredInput = 0;            
                Console.WriteLine("Enter the width: ");
                rawInput = Console.ReadLine();
                try
                {
                    filteredInput = Double.Parse(rawInput);
                    if (filteredInput < 0)
                    {
                        Console.WriteLine("input must be an integer greater than zero.");
                        correctInput = false;
                    }
                }
                catch (Exception exception)
                {
                    correctInput = false;
                    Console.WriteLine("input must be an integer");
                }

            } while (correctInput == false);

            width = filteredInput;         //Sets the private with to user's input.
        
        }


        /// <summary>
        ///  Calculates Area.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {

            return length * width;
        }

        
        /// <summary>
        ///  Prints out the information about the rectangle.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string message = String.Format("  {0,-8}{1,10}                Length {2,-1} x Width {3,-1} ", type, area, length, width);
            
            return message;

        }

        /// <summary>
        /// Calculates the volume for a rectangle.
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume()
        {   // volume set to zero because a 2D shape would have 0 volume.
            double volume = 0;
            return volume;
            
        }

    }
    }
