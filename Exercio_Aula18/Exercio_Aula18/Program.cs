using System;
using System.Globalization;

namespace Exercio_Aula18 {
    class Program {
        static void Main(string[] args) {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade3 = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            // Interpolãção
            Console.WriteLine($"{produto1}, cujo preço é R$ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é R$ {preco2:F2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade3} anos de idade, código {codigo} e genero {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casa decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (Três casa decimais): {medida:F3}");
            Console.WriteLine($"Separador Decimal invariant culture: {medida.ToString("F3",CultureInfo.InvariantCulture)}");
        }
    }
}
