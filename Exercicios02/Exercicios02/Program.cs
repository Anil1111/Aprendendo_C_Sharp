using System;
using System.Globalization;

namespace Exercicios02 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("");
            //Exercicio 01
            /*Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não*/
            /*Console.WriteLine("Digite um numero");
            int n = int.Parse(Console.ReadLine());
            if(n < 0) {
                Console.WriteLine("Negativo");
            }
            else {
                Console.WriteLine("Positivo");
            }*/

            // Exercicio 02
            /*Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.*/
            /*Console.WriteLine("Digite um numero");
            int n1 = int.Parse(Console.ReadLine());
            if (n1 % 2 == 0) {
                Console.WriteLine("Par");
            }
            else {
                Console.WriteLine("Ímpar");
            }*/

            // Exercicio 03
            /*
            * Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
            * Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
            * ordem crescente ou decrescente.
            */
            /*Console.WriteLine("Digite dois números");
            string[] mult = Console.ReadLine().Split(' ');
            int A = int.Parse(mult[0]);
            int B = int.Parse(mult[1]);

            if((A % B == 0) || (B % A == 0)) {
                Console.WriteLine("São Múltiplos");
            }
            else {
                Console.WriteLine("Não são Múltiplos");
            }*/

            // Exercicio 04
            /*
            * Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
            * começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas
            */
            /*Console.WriteLine("Digite hora inicial e final de um jogo");
            string[] iniFim = Console.ReadLine().Split(' ');

            int inicio = int.Parse(iniFim[0]);
            int fim = int.Parse(iniFim[1]);
            int r = 0;
            if(inicio >= fim) {
                r = (24 - inicio) + fim;
            }
            else {
                r = fim - inicio;
            }


            Console.WriteLine($"O JOGO DUROU {r} HORA(S)");*/

            // Exercicio 05
            /*
            * Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
            * seguir, calcule e mostre o valor da conta a pagar. 
            */
            /*Console.WriteLine("CÓDIGO  ESPECIFACAÇÃO      PREÇO");
            Console.WriteLine("  1     Cachorro quente    R$ 4.00");
            Console.WriteLine("  2     X-Salada           R$ 4.50");
            Console.WriteLine("  3     X-Bacon            R$ 5.00");
            Console.WriteLine("  4     Torada simples     R$ 2.00");
            Console.WriteLine("  5     Refrigerantes      R$ 1.50");
            Console.WriteLine("\nDigite o Código do pedido:");
            string[] pedido = Console.ReadLine().Split(' ');
            int cod = int.Parse(pedido[0]);
            int qtd = int.Parse(pedido[1]);
            double total = 0;
            if(cod == 1) {
                total = 4.00 * qtd;
            }else if (cod == 2) {
                total = 4.50 * qtd;
            }else if (cod == 3) {
                total = 5.00 * qtd;
            }else if (cod == 4) {
                total = 2.00 * qtd;
            }else if (cod == 5) {
                total = 1.50 * qtd;
            }
            Console.WriteLine($"Total: R$ {total.ToString("F2",CultureInfo.InvariantCulture)}");
            */

            // Exercicio 06
            /*
            * Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
            * seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o 
            * valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”
            */
            /*Console.WriteLine("Digite um valor");
            double valor = double.Parse(Console.ReadLine());
            if(valor > 0.0 && valor < 25.00) {
                Console.WriteLine("Intervalor [0,25]");
            }else if (valor > 25.0 && valor < 50.00) {
                Console.WriteLine("Intervalor [25,50]");
            }
            else if (valor > 75.0 && valor <= 100.00) {
                Console.WriteLine("Intervalor [25,50]");
            }else {
                Console.WriteLine("Fora do intervalor");
            }*/

            // Exercicio 07
            /*
             * Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
             * de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
             * ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
             * Se o ponto estiver na origem, escreva a mensagem “Origem”.
             * Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
             * situação.
             */
            /*Console.WriteLine("Digite os valores");
            string[] v = Console.ReadLine().Split(' ');

            double x = double.Parse(v[0]);
            double y = double.Parse(v[1]);

            if (x == 0 && y == 0) {
                Console.WriteLine("Origem");
            }else if (x == 0) {
                Console.WriteLine("Eixo X");
            }else if (y == 0) {
                Console.WriteLine("Eixo Y");
            }else if (x > 4) {
                Console.WriteLine("Q4");
            }else if (x > 3) {
                Console.WriteLine("Q3");
            }else if (x > 2) {
                Console.WriteLine("Q2");
            }else if (x > 0) {
                Console.WriteLine("Q1");
            }*/

            // Exercício 08
            /*
             * Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
             * que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
             * qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
             * Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
             * mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
             * 
             * Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
             * salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
             * de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
             * duas casas decimais.
            */
            Console.WriteLine("Digite o Salário");
            double _salario = double.Parse(Console.ReadLine());
            if(_salario <= 2000.00) {
                Console.WriteLine("ISENTO");
            }else if (_salario > 2000 && _salario < 3000.00) {
                Console.WriteLine( _salario * 0.8 );
            }else if (_salario >= 3000 && _salario <= 4500.00) {
                Console.WriteLine(_salario * 0.18);
            }
            else if (_salario > 4500) {
                Console.WriteLine(_salario * 0.28);
            }

        }
    }
}
