using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{


    /// <summary>
    /// Gives attributes to 2D class shapes such as circle, ellipse, square, rectangle, cylinder, and triangle.
    /// </summary>
    public abstract class _2D : Shape
    {
        public double area;                         // Holds the value for the area, common amoung 2D shapes.
        public string type;                         // Holds the name of the shape type


        /// <summary>
        /// Constructor for two dimensonal shapes.
        /// Runs the SetData for the shape, then calculates the area.
        /// </summary>
        public _2D()
        {
            SetData();                              // User Interface for the shape.
            area = CalculateArea();                 // Only calculates area for 2D shapes, no volume necessary.
        }


        /// <summary>
        /// Volume will return 0 because 2D shapes cannot have a volume greater than that.
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume()
        {
            double volume = 0;                      
            return volume;
            throw new NotImplementedException();  
        }

        /// <summary>
        /// Allows inheitence for method calculatearea in 2D shapes
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {   
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows inheitenece for method tostring in 2d shapes
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {   
            throw new NotImplementedException();
        }
        

    }
}
