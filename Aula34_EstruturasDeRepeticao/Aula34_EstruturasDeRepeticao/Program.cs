using System;

namespace Aula34_EstruturasDeRepeticao {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite quantidade de vezes para o programa rodar:   ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for(int i = 0; i < n; i++) {
                // placeholder
                Console.Write("Digite um Valor: #{0} ",i);
                int v = int.Parse(Console.ReadLine());
                soma += v;
            }

            Console.WriteLine("A soma total é: "+soma);
        }
    }
}
