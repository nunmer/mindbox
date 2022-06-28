using System;

namespace findarea
{
    public class Area
    {
        public static void FindCircleArea(int radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine(area);
        }

        public static void FindTriangleArea(int x, int y, int z)
        {
            
            double s = (x + y + z) / 2;
            double area = Math.Sqrt(s * (s - x) * (s - y) * (s - z));

            Console.WriteLine(area);
        }
    }
}
