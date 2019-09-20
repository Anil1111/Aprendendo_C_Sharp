using System;
using System.Globalization;

namespace Aula30_Funcoes {
    class Program {
        static void Main(string[] args) {
            /*Console.WriteLine("digite 3 números");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int result = Maior(n1, n2, n3);

            Console.WriteLine("O Maior é : "+result);*/

            //==================== while ============================
            Console.Write("Digite um número: ");
            int x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x > 0.0) {
                double raiz = Math.Sqrt(x);
                Console.WriteLine("Raiz: "+raiz.ToString("F2",CultureInfo.InvariantCulture));
                Console.Write("Digite outro numero: ");
                x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }

        static int Maior(int a, int b, int c) {
            int m;
            if(a > b && a> c) {
                m = a;
            }else if(b > c && b > a) {
                m = b;
            }
            else {
                m = c;
            }
            return m;
        }
    }
}
