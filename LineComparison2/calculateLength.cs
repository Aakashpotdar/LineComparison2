using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison2
{
    public class calculateLength
    {
        public double opration(double x1,double x2,double y1,double y2)
        {
            double lengthLine = 0;
            try
            {
                lengthLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            }
            catch (Exception ex)
            {
                Console.WriteLine("the mathmatic error in the program");
            }
            return lengthLine;

        }
    }
}
