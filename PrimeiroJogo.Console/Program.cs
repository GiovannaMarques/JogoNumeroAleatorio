using System;

namespace PrimeiroJogo.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primeiramente, o jogo vai mostrar uma mensagem explicativa para o usuário
            // Quando o usuário der 'enter', o jogo começa e cria um número aleatório
            // Então o jogo pede para que o usuário digite um número
            // Então, o programa verifica se o número digitado é igual ao número aleatório definido pelo programa
            // Se o usuário acertou, o jogo dá os parabéns e se o usuário errou o jogo informa o erro
            // Em seguida o jogo reinicia

            Console.WriteLine("Bem vindo ao Jogo Aleatorio!");
            Random random = new Random();
            int numero = random.Next(1, 10);

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
                    Console.WriteLine($"Você errou. O número era {numero}");
                }
            }
        }
    }
}

// Próxima feature -> Criar mecanismo de chances que o usuário tem para acertar o número
