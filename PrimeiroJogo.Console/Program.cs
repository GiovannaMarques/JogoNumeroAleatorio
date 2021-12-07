using System;

namespace PrimeiroJogo.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Jogo Aleatorio!\n Escolha um nivél!\n F - Fácil\n M - Médio\n D - Dificil");
            string nivel = Console.ReadLine();

            if (nivel == "F" || nivel == "f")
            {
                Jogar(5, 1, 10);
            }

            if (nivel == "m" || nivel == "M")
            {
                Jogar(4, 1, 15);
            }

            if (nivel == "d" || nivel == "D")
            {
                Jogar(3, 1, 20);
            }
        }

        static void Jogar(int chances, int menorNumeroPossivel, int maiorNumeroPossivel)
        {
            Random random = new Random();
            int numero = random.Next(menorNumeroPossivel, maiorNumeroPossivel);
            Console.WriteLine("Você escolheu o nível Fácil!");

            while (true)
            {
                Console.WriteLine("Escolha um número de 1 a 10");
                string resposta = Console.ReadLine();

                if (numero.ToString() == resposta)
                {
                    Console.WriteLine($"Parabéns você ganhou, o número era {numero}");
                    break;
                }
                else
                {
                    chances = chances - 1;
                    if (chances > 0)
                    {
                        Console.WriteLine($"Você errou, você tem mais {chances} chances");
                    }
                    else
                    {
                        Console.WriteLine($"Suas chances acabaram, o número era {numero}");
                        break;
                    }
                }
            }
        }
    }
}