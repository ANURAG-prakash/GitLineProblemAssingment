using System;

namespace UC2_CheckTheEqualityOfTwoLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int x11, x12, y11, y12;
            int x21, x22, y21, y22;
            double Lenth_Of_Line1 , Lenth_Of_Line2;
            Console.WriteLine("Enter the value of x11");
            x11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Value Of x12");
            x12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Value Of y11");
            y11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Value Of y12");
            y12 = Convert.ToInt32(Console.ReadLine());
            Lenth_Of_Line1 = Math.Sqrt(Math.Pow(x12 - x11, 2) + Math.Pow(y12 - y11, 2));
            Console.WriteLine("Enter the value of x21");
            x21 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Value Of x22");
            x22 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Value Of y21");
            y21 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Value Of y22");
            y22 = Convert.ToInt32(Console.ReadLine());
            Lenth_Of_Line2 = Math.Sqrt(Math.Pow(x22 - x21, 2) + Math.Pow(y22 - y21, 2));
            if (Lenth_Of_Line1 == Lenth_Of_Line2)
                Console.WriteLine(" Line Is Equal");
            else
                Console.WriteLine(" Line is not Equal ");
        }
    }
}
