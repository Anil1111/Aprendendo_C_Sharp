using System;
using System.Globalization;

/*
 * Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
 * mensagem explicativa, conforme exemplos
 */
namespace Exercicios01 {
    class Program {
        static void Main(string[] args) {
            // Exercício 01
            /*Console.WriteLine("Digite dois números inteiros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int r = n1 + n2;
            Console.WriteLine("Soma = " + r);*/


            // Exercicio 02
            /*
            * Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste 
            * círculo com quatro casas decimais conforme exemplos.
            * Fórmula da área: area = π . raio2
            * Considere o valor de π = 3.14159
            */
            /*double PI = 3.14159;
            Console.WriteLine("Digite o valor do raio");
            double raio = double.Parse(Console.ReadLine());
            double area = PI * Math.Pow(raio,2);
            Console.WriteLine("Area = "+area.ToString("F4",CultureInfo.InvariantCulture));*/

            //Exercicio 03
            /*
             * Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a 
             * diferença do produto de A e B pelo produto de C e D segundo a fórmula: 
             * DIFERENCA = (A * B - C * D).
             */
            /*Console.WriteLine("Digite os valores de: A B C e D:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a *b - c * d);
            Console.WriteLine("Direfença = "+diferenca);*/

            // Exercicio 04
            /*
             * Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o 
             * valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número 
             * e o salário do funcionário, com duas casas decimais.
             */
            /*Console.WriteLine("Digite o número de funcionarios");
            int numFunc = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de horas trabalhadas");
            double horaTrab = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da hora");
            double valorHora = double.Parse(Console.ReadLine());

            double _salario = (horaTrab * valorHora);
            Console.WriteLine($"Número de funcionários: {numFunc}\nSalário de: R$ {_salario.ToString("F2", CultureInfo.InvariantCulture)}");*/

            // Exercício 05
            /*
             * Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, 
             * o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
             */

            /*Console.WriteLine("Digite o código da peça, número de peça e o valor da peça, são duas entradas");
            string[] p1 = Console.ReadLine().Split(' ');
            string[] p2 = Console.ReadLine().Split(' ');

            int np1 = int.Parse(p1[1]);
            int np2 = int.Parse(p2[1]);
            double vp1 = double.Parse(p1[2]);
            double vp2 = double.Parse(p2[2]);
            Console.WriteLine("VALOR A PAGAR: R$ "+((np1*vp1)+(np2*vp2)).ToString("F2", CultureInfo.InvariantCulture));*/

            // Exercicio 06
            /*
             * Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
             * mostre:
             * a) a área do triângulo retângulo que tem A por base e C por altura.
             * b) a área do círculo de raio C. (pi = 3.14159)
             * c) a área do trapézio que tem A e B por bases e C por altura.
             * d) a área do quadrado que tem lado B.
             * e) a área do retângulo que tem lados A e B
             */
            double pi = 3.14159;
            Console.WriteLine("Digite 3 valores");
            string[] valores = Console.ReadLine().Split(' ');
            double A = double.Parse(valores[0]);
            double B = double.Parse(valores[1]);
            double C = double.Parse(valores[2]);

            double areaTriRect = (A *C) / 2.0;
            double areaCirc = pi * Math.Pow(C, 2);
            double areaTrap = ((A + B) / 2.0) * C;
            double areaQuad = Math.Pow(B,2);
            double areaRet = (A*B);

            Console.WriteLine($"TRIÂNGULO: {areaTriRect.ToString("F3", CultureInfo.InvariantCulture)}\nCIRCULO: {areaCirc.ToString("F3", CultureInfo.InvariantCulture)}\nTRAPEZIO: {areaTrap.ToString("F3", CultureInfo.InvariantCulture)}\nQUADRADO: {areaQuad.ToString("F3", CultureInfo.InvariantCulture)} \nRETANGULO: {areaRet.ToString("F3",CultureInfo.InvariantCulture)}");

        }
    }
}
