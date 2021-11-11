using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison2
{
    public class compaire : calculateLength,IcomparisonOfTwoLines
    {
        public void twoLinesCompaire(double lengthLine1, double lengthLine2)
        {
            
            if (lengthLine1.Equals(lengthLine2))
            {
                Console.WriteLine("both lines are equal");
            }
            else if (lengthLine1 > lengthLine2)
            {
                Console.WriteLine("line 1 is longer than line 2");
            }
            else
            {
                Console.WriteLine("line 2 is longer than line 1");
            }
        }
    }
}
