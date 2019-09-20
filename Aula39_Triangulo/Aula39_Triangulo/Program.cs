using System;
using System.Globalization;

namespace Aula39_Triangulo {
    class Program {
        static void Main(string[] args) {

            /*double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Digite os dados de X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os dados de Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            */
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite os dados de X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os dados de Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Continuara a mesma para os dois modelos
            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p*(p - x.A)* (p - x.B)* (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Area X é de: "+areaX.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Area Y é de: "+ areaY.ToString("F2", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("X é maior");
            }else {
                Console.WriteLine("Y é maior");
            }

        }
    }
}

