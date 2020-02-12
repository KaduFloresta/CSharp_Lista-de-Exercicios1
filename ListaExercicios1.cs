using System;

namespace ListaExercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Kadu Floresta");

        // Exercicio1 - MEDIA
        int nota1 = 10;
        int nota2 = 15;
        int nota3 = 20;
        float media1;

        media1 = ((nota1 + nota2 + nota3) / 3);
        Console.WriteLine($"Exercício #1 - Resposta: {media1}");

        // Exercicio2 - ÁREA
        int lado1 = 10;
        int lado2 = 20;
        long area2;

        area2 = lado1 * lado2;
        Console.WriteLine($"Exercício #2 - Resposta:  {area2}");

        // // Exercicio3 - VOLUME
        int larg = 100;
        int alt = 150;
        int prof = 200;
        long volume3;

        volume3 = larg * alt * prof;
        Console.WriteLine($"Exercício #3 - Resposta: {volume3}");

        // // Exercicio4 - > ou < DOBRO
        long dobro4;
        int valor1 = 30;
        int valor2 = 10;

        dobro4 = (valor2 + valor2);

        Console.WriteLine("Exercício #4 - Resposta: ");
        Console.WriteLine($" -->Valor#1 = {valor1}");
        Console.WriteLine($" -->Valor#2 = {valor2}");

            if (valor1 > dobro4) {
                Console.WriteLine(" -->O Valor#1 é MAIOR que o dobro do Valor#2!");
            } else {
                Console.WriteLine(" -->O Valor#1 é MENOR que o dobro do Valor#2!");
            }

        // // Exercicio5 - BHASKARA
        int a = 1;
        int b = 12;
        int c = -13;
        double delta, x1, x2;

        delta = (b * b) + (-4 * (a * c));
        Console.WriteLine("Exercício #5 - Resposta: ");
        Console.WriteLine($" Delta: {delta}");

            if (delta >= 0) {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($" x1 = " + x1);
                Console.WriteLine($" x2 = " + x2);
            } else {
                Console.WriteLine(" Delta Não Possui Raiz!");
            }

        // // Exercicio6 - VELOCIDADE
        float dist6 = 240; // metros
        float tempo6 = 3;  // horas
        float veloc6;

        veloc6 = dist6 / tempo6;
        Console.WriteLine($"Exercício #6 - Resposta: {veloc6} Km/h");

        // // Exercicio7 - IMPOSTO
        float perc7 = 10;
        float fatur7 = 5000;
        float imposto7;

        imposto7 = (fatur7 * perc7) / 100;
        Console.WriteLine($"Exercício #7 - Resposta: R${imposto7}");

        // // Exercicio8 - PAR ou ÍMPAR
        int num1 = 2;

        if (num1 < 0) {
            Console.WriteLine("Exercício #8 - Resposta: O NÚMERO É NEGATIVO");
        }
        if (num1 > 0)
            if (num1 % 2 == 0) {
                Console.WriteLine($"Exercício #8 - Resposta: {num1} É PAR");
            } else {
                Console.WriteLine($"Exercício #8 - Resposta: {num1} É ÍMPAR");
            }

        // Exercicio9 - DOBRO*
            {
            Console.WriteLine("Exercício #9 - EXERCÍCIO REPETIDO!");
            }
        // Exercicio10 - STRINGS
            {
                String str1 = "teste1";
                String str2 = "teste2".Substring(1);

                Console.WriteLine("str1: " + str1 + ", str2: " + str2);
                    if (str1 == str2) {
                        Console.WriteLine("Exercício 10 - Resposta: STRING#1 é igual a STRING#2");
                    } else {
                        Console.WriteLine("Exercício #10 - Resposta: STRING#1 é diferente de STRING#2");
                    }
            }
        // Exercicio11 - STRINGS para INT
            try {
                String numero = "10.5";
                int numeroConvertido = Convert.ToInt32(numero);
                int numeroVezes2 = numeroConvertido * 2;

                Console.WriteLine("Exercício #11 - Resposta: " + numeroVezes2);
            }

            catch (FormatException e) {
                Console.WriteLine("Exercício #11 - Resposta: Número inválido!");
            }

        // Exercicio12 - IMPOSTO DE RENDA
            double salarioM = 3500.00;
            double porc12 = salarioM <= 1903.98
                    ? 0
                    : salarioM >= 1903.99 && salarioM <= 2826.65 
                        ? 7.5
                        : salarioM >= 2826.66 && salarioM <= 3751.05
                            ? 15
                            : salarioM >= 3751.06 && salarioM <= 4664.68 
                                ? 22.5 : 27.5;

            Console.WriteLine("Exercício #12 - Resposta: ");
            Console.WriteLine("  ->Salário é: " + salarioM.ToString("C"));
            Console.WriteLine("  ->Alíquota do IR: " + porc12 + " %");

        // // DESAFIO - NÚMERO PRIMO
        long numDes = 9973;
        double numeroDouble = numDes;
            if ((numeroDouble / numeroDouble) == (numDes / numDes)) {
                if (numeroDouble / 2 != numDes / 2 || numDes == 2) {
                    Console.WriteLine("DESAFIO - Resposta: Este numero É PRIMO!\n\n");
                } else {
                    Console.WriteLine("DESAFIO - Resposta: Este numero NÃO É PRIMO!\n\n");
                }
            } else {
                Console.WriteLine("DESAFIO - Resposta: Numero NÃO É PRIMO!\n\n");
            }
        }
    }
}
