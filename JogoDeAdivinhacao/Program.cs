namespace JogoDeAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numeroRandom = new Random();
            int quantidadeTentativas = 0;
            int chute;
            int pontuacao = 1000;
            int numeroAleatorio = numeroRandom.Next(1, 20);

                Console.WriteLine("Escolha nivel de dificuldade: (1) Facil (2) Médio (3) Dificil {0} {1} {2} ");
                int nivelDificuldade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Escolha: {nivelDificuldade} {0}");

                    if (nivelDificuldade == 1)
                    {
                    quantidadeTentativas = 15;
                    }

                    if (nivelDificuldade == 2)
                    {
                        quantidadeTentativas = 10;
                    }
                    else if (nivelDificuldade == 3)
                    {
                        quantidadeTentativas = 5;
                    }

                    for (int i = 1; i <= quantidadeTentativas; i++ )
                    {
                        Console.WriteLine($"Tentativa {i} de {quantidadeTentativas}");
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine($"Qual seu chute numero {i}º ?");
                        chute = Convert.ToInt32(Console.ReadLine());

                        if (chute == numeroAleatorio)
                        {
                           
                            Console.WriteLine($"Qual seu {i}º chute? {chute} \n Parabéns, você acertou!");
                            return;

                        }
                        if (chute > numeroAleatorio)
                        {
                        pontuacao -= Math.Abs((chute - numeroAleatorio) / 2);
                        Console.WriteLine($"Qual o seu {i}º chute? {chute}º \n Seu chute foi maior que o numero secreto!");
                        Console.WriteLine($"Voce fez {pontuacao} pontos");

                        }
                        else if (chute < numeroAleatorio)
                        {
                        pontuacao -= Math.Abs((chute - numeroAleatorio) / 2);
                        Console.WriteLine($"Qual o seu {i}º chute? {chute}º \n Seu chute foi menor que o numero secreto!");
                        Console.WriteLine($"Voce fez {pontuacao} pontos");
                        }
                
                    
                    }
            
        }
    }
}