using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava1
{
    public class BusinessLogicWindow
    {
        /// <summary>
        /// CalculatePerimeter calculates the perimeter of a window
        /// </summary>
        public static double CalculatePerimeter(double width, double height)
        {
           return width * 2 + height * 2;
           throw new System.NotImplementedException();
        }

        public static double CalculateArea(double width, double height)
        {
            return width * height;
            throw new System.NotImplementedException();
        }

        public static double CalculateFrame(double width, double height, double stroke)
        {
            return ((width * height) - ((stroke - width) * (stroke - height)));
            throw new System.NotImplementedException();
        }
    }
}
