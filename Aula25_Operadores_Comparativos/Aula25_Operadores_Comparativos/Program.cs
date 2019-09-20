using System;

namespace Aula25_Operadores_Comparativos {
    class Program {
        static void Main(string[] args) {

            // operadores Comparativos
            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            // Operadores lógicos
            bool c3 = 2 > 3 && 4 != 5;
            Console.WriteLine(c3);
            bool c4 = 2 > 3 || 4 != 5;
            Console.WriteLine(c4);

            // Estrutura condicional
            int x = 10;
            if(x > 12) {
                Console.WriteLine("Boa tarde");
            }else if(x > 17) {
                Console.WriteLine("Boa noite");
            }else {
                Console.WriteLine("Bom dia");
            }

            // Escopo e Inicialização
            int z = 60; // Obrigatória ainicialização da variavel
            Console.WriteLine(z);

            double desc = 0.0;

            if (z > 50.0) {
                desc = z * 0.1; // se a variavel for declarada aqui, so será vista aqui
            }

            Console.WriteLine(desc);


        }
    }
}
