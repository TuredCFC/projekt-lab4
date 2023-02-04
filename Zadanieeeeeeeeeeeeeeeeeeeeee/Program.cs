using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program oblicza pierwiastki równania kwadratowego ax^2 + bx + c = 0");
            Console.Write("Podaj a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Równanie ma dwa różne pierwiastki: x1 = {0}, x2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Równanie ma jeden pierwiastek x = {0}", x);
            }
            else
            {
                Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych");
            }

            Console.ReadKey();
        }
    }
}
