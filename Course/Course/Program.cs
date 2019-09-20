using System;
// para ignorar formatação especifica de pais
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            // SByte x = 100;                 // aceita numeros positivos e negativos  - faixa -128 à 127
            // byte x = 126;                  // so números posistivos - faixa até 256
            // int x = 2147483647;            // so números posistivos - faixa até 2.147.483.647
            // long x = 9223372036854775807;  //  Só números positivos - faixa até 9.223.372.036.854.775.808
            
            bool completo = false;
            char genero = 'F';
            // código da tabela unicode - https://unicode-table.com/pt/#basic-latin
            char letra = '\u0041';
            float n = 4.5f;
            double f = 4.5;
            string nome = "Maria";
            object obj = "André Gois";


            //Console.WriteLine(x);
            //Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n);
            Console.WriteLine(f);
            Console.WriteLine(nome);
            Console.WriteLine(obj);

            int n1 = int.MinValue;
            int n2 = int.MaxValue;
            Console.WriteLine(n1);
            Console.WriteLine(n2);

            // ================================================================
            int idade = 30;
            double _saldo = 8.8934332;

            Console.WriteLine(idade);
            Console.WriteLine(_saldo);
            Console.WriteLine(_saldo.ToString("F2"));
            Console.WriteLine(_saldo.ToString("F4"));           // ignorar formatação padrão
            Console.WriteLine(_saldo.ToString("F3", CultureInfo.InvariantCulture));

            // Placeholders, Concatenação e interpolação
            string nom1 = "André Gois";
            int idade2 = 30;
            double _salario = 1.999;
            // Técnica de Placeholder
            Console.WriteLine("O {0} tem {1} de idade com R$ {2:F2} na conta", nom1,idade2, _salario);

            // Técnica da Interpolação
            Console.WriteLine($"O {nom1} tem {idade2} de idade com R$ {_salario:F2} na conta");

            // Técnica da Concatenação
            Console.WriteLine(nom1+" tem "+idade2+" de idade com R$ "+_salario.ToString("F2", CultureInfo.InvariantCulture)+" na conta");
        }
    }
}
