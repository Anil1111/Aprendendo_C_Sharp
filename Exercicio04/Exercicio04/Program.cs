using System;
using System.Globalization;

namespace Exercicio04 {
    class Program {
        static void Main(string[] args) {
            // Exercicio 01
            /* Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor 
             * por linha, inclusive o X, se for o caso
             */
            /*Console.Write("Digite um valor: ");
            int X = int.Parse(Console.ReadLine());
            for (int i = 0; i < X; i++) {
                if(i % 2 == 1) {
                    Console.WriteLine(i);
                }
            }*/

            // Exercicio 02
            /* Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
             * Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
             * essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
             */
            /* Console.Write("Digite um valor: ");
             int N = int.Parse(Console.ReadLine());
             int a = 0, b = 0;

             Console.WriteLine("Digite valores Aleatórios");
             for (int i = 0; i < N; i++) {
                 int X = int.Parse(Console.ReadLine());
                 if(X >= 10 && X <= 20) {
                     a++;
                 }
                 else if(X>0){
                     b++;
                 }
             }
             Console.WriteLine("{0} in",a);
             Console.WriteLine("{0} out",b);*/

            // Exercicio 03
            /* Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
             * de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
             * conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor 
             * tem peso 5
             */
            /*Console.Write("Digite um valor: ");
            int A = int.Parse(Console.ReadLine());

            for (int i =0;i<A;i++) {
                Console.WriteLine("Digite 3 valotes reais");
                string[] vet = Console.ReadLine().Split(' ');
                double z1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double z2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double z3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double media = ((2.0*z1)+(3.0*z2)+(5.0*z3))/10.0;
                Console.WriteLine("Media Ponderada: "+media.ToString("F1",CultureInfo.InvariantCulture));                
            }*/

            // Exercicio 04
            /* Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            /* segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
            */
            /*Console.Write("Digite um valor: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                Console.WriteLine("Digite 2 valores");
                string[] vet = Console.ReadLine().Split(' ');
                double z1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double z2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double r = (z1 / z2);
                if(z2 == 0) {
                    Console.WriteLine("divisao impossivel");
                }else {
                    Console.WriteLine(r.ToString("F2",CultureInfo.InvariantCulture));
                }                
            }*/

            // Exercicio 05
            /* Ler um valor N. Calcular e escrever seu respectivo fatorial. 
             * Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
             * Lembrando que, por definição, fatorial de 0 é 1.
             */
            /*Console.Write("Digite um valor: ");
            int N = int.Parse(Console.ReadLine());
            int fat = 1;
            int v = N;
            for (int i = 0; i < N; i++) {
                fat *= (N - i);
            }
            Console.WriteLine($"Fatorial de {N} é :"+fat);*/


            // Exercicio 06
            /* Ler um número inteiro N e calcular todos os seus divisores. */
            /*Console.Write("Digite um valor: ");
            int N = int.Parse(Console.ReadLine());
            for (int i=1; i<=N;i++) {
                if(N % i == 0) {
                    Console.WriteLine(i);
                }
            }*/

            // Exercicio 07
            /* Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
             * começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, 
             * conforme exemplo
             */
            Console.Write("Digite um valor: ");
            int N = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= N; i++) {
                Console.WriteLine($"{i} {(i*i)} {i*i*i}");
            }
        }
    }
}
