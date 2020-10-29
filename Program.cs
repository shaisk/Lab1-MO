using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    public class Program
    {
        private static double epsilon = 0.02, a1 = -4, b1 = -5;

        public static void Main(string[] args)
        {
            Console.WriteLine("Dihotomia");
            dihotomyMethod();
        }

        private static double f(double x)
        {
            return x* Math.Sin(x) + 2 * Math.Cos(x);
        }

        private static void dihotomyMethod()
        {
            double m = 0, n = 0, alpha = epsilon / 2;
            int N = 0;
            while ((b1 - a1) > epsilon)
            {
                Console.WriteLine($"bk - ak = {(b1 - a1)}");
                m = (a1 + b1) / 2 - alpha;
                n = (a1 + b1) / 2 + alpha;
                Console.WriteLine($"m = {m}; n = {n}");
                Console.WriteLine($"f(m) = {f(m)}; f(n) = {f(n)}");
                if (f(m) > f(n)) a1 = m;
                else b1 = n;
                N += 2;
                Console.WriteLine($"ak+1 = {a1}; bk+1 = {b1}");
                Console.WriteLine("--------------------");
                //Console.ReadLine();
            }

            Console.WriteLine($"bk - ak = {(b1 - a1)}");
            Console.WriteLine($"x* = {a1 + b1/2}");
            Console.WriteLine($"N = {N}");
            Console.WriteLine($"R(N) = {1/Math.Pow(2, N/2)}");

            }
    }
}