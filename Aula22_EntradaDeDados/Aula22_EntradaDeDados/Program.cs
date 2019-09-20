using System;
using System.Globalization;

namespace Aula22_EntradaDeDados {
    class Program {
        static void Main(string[] args) {
            /* string frase = Console.ReadLine();
             string x = Console.ReadLine();
             string y = Console.ReadLine();
             string z = Console.ReadLine();

             Console.WriteLine("Você Digitou: ");
             Console.WriteLine(frase);
             Console.WriteLine(x);
             Console.WriteLine(y);
             Console.WriteLine(z);

             Console.WriteLine("------------------ Digite nova palavra -----------------------");
             // string s = Console.ReadLine();
             // string[] vet = s.Split(' ');
             // ou
             string[] vet = Console.ReadLine().Split(' ');
             string p1 = vet[0];
             string p2 = vet[1];
             string p3 = vet[2];

             Console.WriteLine("A palavra é: ");
             Console.WriteLine(p1);
             Console.WriteLine(p2);
             Console.WriteLine(p3);*/

            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double nb1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine($"Inteiro: {n1} \nString: {ch} \nDouble: {nb1.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("---------------Digite em uma linha-----------------");
            string[] vetor = Console.ReadLine().Split(' ');

            string nome = vetor[0];
            int num = int.Parse(vetor[1]);
            char letra = char.Parse(vetor[2]);
            double dec = double.Parse(vetor[3], CultureInfo.InvariantCulture);
            Console.WriteLine($"Nome: {nome} \nNum: {num}, \nchar: {letra} \nDouble: {dec.ToString("F2",CultureInfo.InvariantCulture)}");


        }
    }
}
