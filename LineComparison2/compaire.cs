﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison2
{
    public class compaire : comparisonOfTwoLines
    {
        public void twoLinesCompaire()
        {
            //co-ordinates of line 1
            double l1_x1 = 3, l1_y1 = 19;
            double l1_x2 = 5, l1_y2 = 10;
            //co-ordinates of line 2
            double l2_x1 = -2, l2_y1 = 12.5;
            double l2_x2 = 7, l2_y2 = 10;
            double lengthLine1=0;
            double lengthLine2=0;
            try
            {
                lengthLine1 = Math.Sqrt(Math.Pow((l1_x2 - l1_x1), 2) + Math.Pow((l1_y2 - l1_y1), 2));
                lengthLine2 = Math.Sqrt(Math.Pow((l2_x2 - l2_x1), 2) + Math.Pow((l2_y2 - l2_y1), 2));
            }catch(Exception ex)
            {
                Console.WriteLine("the mathmatic error in the program");
            }
            Console.WriteLine(lengthLine1);
            Console.WriteLine(lengthLine2);

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
