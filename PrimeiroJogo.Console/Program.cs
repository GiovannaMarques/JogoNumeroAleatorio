using System;

namespace PrimeiroJogo.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iniciase o Jogo, Bem vindo!
            // Escolher o nível
            // Dar orientações e solicitar o número aleatório
            // Então o jogo pede para que o usuário digite um número
            // Então, o programa verifica se o número digitado é igual ao número aleatório definido pelo programa
            // Se o usuário acertou, o jogo dá os parabéns
            // e se o usuário errou
            //          informa as chances restantes
            //          Acabando as chances o usuário perde
            // 
            // Em seguida o jogo reinicia

            Console.WriteLine("Bem vindo ao Jogo Aleatorio!\n Escolha um nivél!\n F - Fácil\n M - Médio\n D - Dificil");
            string nivel = Console.ReadLine();

            if (nivel == "F" || nivel == "f")
            {
                Random random = new Random();
                int numero = random.Next(1, 10);
                int chances = 5;
                Console.WriteLine("Você escolheu o nível Fácil!");

                while (true)
                {
                    Console.WriteLine("Escolha um número de 1 a 10");
                    int resposta = int.Parse(Console.ReadLine());

                    if (numero == resposta)
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

            if (nivel == "m" || nivel == "M")
            {
                Random random = new Random();
                int numero = random.Next(1, 15);
                int chances = 4;
                Console.WriteLine("Você escolheu o nível Médio!");

                while (true)
                {
                    Console.WriteLine("Escolha um número de 1 a 15");
                    int resposta = int.Parse(Console.ReadLine());

                    if (numero == resposta)
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

            if (nivel == "d" || nivel == "D")
            {
                Random random = new Random();
                int numero = random.Next(1, 20);
                int chances = 3;
                Console.WriteLine("Você escolheu o nível Dificil!");

                while (true)
                {
                    Console.WriteLine("Escolha um número de 1 a 20");
                    int resposta = int.Parse(Console.ReadLine());

                    if (numero == resposta)
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
}