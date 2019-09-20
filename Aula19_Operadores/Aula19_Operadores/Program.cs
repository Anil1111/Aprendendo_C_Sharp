using System;

namespace Aula19_Operadores {
    class Program {
        static void Main(string[] args) {

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = 10.0 / 8; // ou double n4 = (double) 10 / 8;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4 * a * c;
            Console.WriteLine(delta);

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine($"Delta: {delta}, X1: {x1} e X2: {x2}");

            // Operadores de Atribuição
            int a2 = 10;
            Console.WriteLine(a2);
            a2++;
            Console.WriteLine(a2);
            a2 *= 3;
            Console.WriteLine(a2);

            string part01 = "ABC";
            Console.WriteLine(part01);
            part01 += "DEF";
            Console.WriteLine(part01);

            // Conversão Ímplicita e casting
            float aa = 4.5f;
            Console.WriteLine(aa);
            double x = aa;
            Console.WriteLine(aa);

            double bb = 4.9;
            float b1 = (float)b;
            Console.WriteLine(b1);

            int z1 = 5, z2 = 6;
            double r = (double) z1 / z2;
            Console.WriteLine(r);

        }
    }
}
