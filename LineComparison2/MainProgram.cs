using System;

namespace LineComparison2
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to Line comparison program");
            Console.WriteLine("enter the Line 1 co-ordinates ");
            Console.WriteLine("enter x1 and y1 of line 1");
            double L1_x1 = double.Parse(Console.ReadLine());
            double L1_y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter x2 and y2 of line 1");
            double L1_x2 = double.Parse(Console.ReadLine());
            double L1_y2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("enter x1 and y1 of line 2");
            double L2_x1 = double.Parse(Console.ReadLine());
            double L2_y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter x2 and y2 of line 2");
            double L2_x2 = double.Parse(Console.ReadLine());
            double L2_y2 = double.Parse(Console.ReadLine());

            compaire lineCompaire = new compaire();

            double lengthLine1=lineCompaire.opration(L1_x1,L1_y1,L1_x2,L1_y2);
            double lengthLine2 = lineCompaire.opration(L2_x1, L2_y1, L2_x2, L2_y2);

            lineCompaire.twoLinesCompaire(lengthLine1,lengthLine2);
        }
    }
}
