using System;
using System.Globalization;

namespace Exercicio_Aula23 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite seu Nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite quantos quantos quartos tem sua casa");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite preço de um produto");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu ultimo nome, idade e altura");
            string[] v = Console.ReadLine().Split(' ');
            string lastName = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2], CultureInfo.InvariantCulture);

            Console.WriteLine("------------ Primeira parte ------------");
            Console.WriteLine($"Nome: {nome}\nSua casa tem {n} quantos\n" +
                $"O preço é: {b.ToString("F2",CultureInfo.InvariantCulture)}");

            Console.WriteLine("------------ Segunda parte ------------");
            Console.WriteLine($"Sobreome: {lastName}\nIdade: {idade} \nAltura: {altura.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
