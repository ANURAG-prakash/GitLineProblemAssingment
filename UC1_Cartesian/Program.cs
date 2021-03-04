using System;

namespace UC1_Cartesian
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            double Lenth_Of_Line;
            Console.WriteLine("Enter the value of x1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Value Of x2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Value Of y1");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Value Of y2");
            y2 = Convert.ToInt32(Console.ReadLine());
            Lenth_Of_Line = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length Of The Line Will Be : " + Lenth_Of_Line);


        }
    }
}
