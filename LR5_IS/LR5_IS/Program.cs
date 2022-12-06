using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_IS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = 100;
            int Y = 0;


            for(int i = 0; i<100; i++)
            {
                X = 100 - i;
                Y = 0 + i;
                Console.WriteLine($"X : {X}");
                Console.WriteLine($"Y : {Y}");
                double S = 400 * X - 0.02 * Math.Pow(X, 3);
                Console.WriteLine($"S : {S}");

                double P = 280 * Y - 0.4 * Math.Pow(Y, 2);
                Console.WriteLine($"P : {P}");

                double N = Math.Abs(P - S);
                Console.WriteLine($"N : {N}");

                double SX = S / X;
                Console.WriteLine($"SX : {SX}");

                double PY = P / Y;
                Console.WriteLine($"PY : {PY}");

                double Z = Math.Abs(SX - PY);
                Console.WriteLine($"Z : {Z}");

                double SP = S + P;
                Console.WriteLine($"SP : {SP}");

                double SPXY = SP / (X + Y);
                Console.WriteLine($"SPXY : {SPXY}");
                Console.WriteLine($"--------------");
            }
            Console.ReadLine();

        }
    }
}
