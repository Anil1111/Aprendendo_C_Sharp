using System;

namespace Exercicios03 {
    class Program {
        static void Main(string[] args) {

            // Exercicio 01
            /*
             * Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada 
             * leitura de senha incorreta informada, escrever a mensagem "Senha Invalida". Quando a 
             * senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o 
             * algoritmo encerrado. Considere que a senha correta é o valor 2002.
             */
            /*int senha = 2002;
            Console.WriteLine("Digite sua senha");
            int sh = int.Parse(Console.ReadLine());
            while(sh != senha) {
                Console.WriteLine("Senha inválida");
                Console.WriteLine("Digite sua senha novamente");
                sh = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Senha Permitida");*/

            // Exercicio 02
            /*
             * Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada 
             * de pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele 
             * pertence. O algoritmo será encerrado quando pelo menos uma de duas coordenadas for 
             * NULA (nesta situação sem escrever mensagem alguma)
             */
            /*Console.WriteLine("Digite as coordenadas");            
            string[] coor = Console.ReadLine().Split(' ');
            double x = double.Parse(coor[0]);
            double y = double.Parse(coor[1]);

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("terceiro");
                }
                else {
                    Console.WriteLine("quarto");
                }
                coor = Console.ReadLine().Split(' ');
                x = int.Parse(coor[0]);
                y = int.Parse(coor[1]);
            }*/


            // Exercicio 03
            /*
             * Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus 
             * clientes. Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da 
             * seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido 
             * (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). O programa 
             * será encerrado quando o código informado for o número 4. Deve ser escrito a mensagem: 
             * "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, 
             * conforme exemplo
             */
            Console.WriteLine("1.Álcool \n2.Gasolina \n3.Diesel \n4.Fim\n");
            int cod1 = 0, cod2 = 0,cod3=0;
            Console.WriteLine("Digite o código do tipo de combustível");
            int cod = int.Parse(Console.ReadLine());

            while(cod != 4) {
                if (cod == 1) { Console.WriteLine("Álcool"); cod1++; }
                else if (cod == 2) { Console.WriteLine("Gasolina"); cod2++; }
                else if (cod == 3) { Console.WriteLine("Diessel"); cod3++; }
                else if (cod == 4) { Console.WriteLine("Fim"); }
                else { Console.WriteLine("fora da faixa de 1 a 4\nDigite um novo codigo"); }

                Console.WriteLine("Digite o código do tipo de combustível");
                cod = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Preferido Álcool: {cod1} \nPreferido Gasolina: {cod2} \nPreferido Diesel: {cod3}\n4.Fim\n");
            Console.WriteLine("MUITO OBRIGADO");
            
        }
    }
}
