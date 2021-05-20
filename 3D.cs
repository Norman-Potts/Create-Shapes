using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    /// <summary>
    /// Class for Three dimensional shapes. 
    /// </summary>
    public abstract class _3D : Shape
    {
        public double surfaceArea;                          
        public string type;
        public double Volume;
        


        /// <summary>
        /// Constructor for three dimensional shapes. Sets the data from the user first, then calculates area and volume. 
        /// </summary>
        public _3D()
        {
            SetData();                                      
            surfaceArea = CalculateArea();                  
            Volume = CalculateVolume();           
        }

        /// <summary>
        ///  Three dimensional can have a volume.
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume()
        {   
            throw new NotImplementedException();
        }

        /// <summary>
        /// Three dimensional can have area.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {   
            throw new NotImplementedException();
        }

        /// <summary>
        ///  Allows appropriate info to be displayed about a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {   
            throw new NotImplementedException();
        }

    }
}
