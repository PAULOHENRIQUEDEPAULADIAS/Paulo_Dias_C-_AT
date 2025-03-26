
namespace AT
{
    public class Exercise10
    {

        public void Adivinhacao()
        {
            Random random = new Random(); 
            int numeroAleatorio = random.Next(1, 51); 
            int tentativas = 5; 
            bool numeroCorreto = false; 

            Console.WriteLine("Bem-vindo ao jogo! Adivinhe o número de 1 a 50.");
            Console.WriteLine("Você tem 5 tentativas!");

            for (int i = 0; i < tentativas; i++)
            {
                try
                {
                    Console.WriteLine($"\nTentativa {i + 1} de {tentativas}:");
                    Console.Write("Digite um número: ");
                    string input = Console.ReadLine();

                    if (!Program.validarEntradaNumericaSemEspaco(input))
                    {
                        Console.WriteLine("Por favor, digite um número válido.");
                        continue; 
                    }

                    int palpite = Convert.ToInt32(input);

                    if (palpite < 1 || palpite > 50)
                    {
                        ExibirX();
                        Console.WriteLine("Erro: O número deve estar entre 1 e 50.");
                        continue;
                    }

                    if (palpite == numeroAleatorio)
                    {
                        numeroCorreto = true;
                        Console.WriteLine($"Parabéns! Você acertou o número {numeroAleatorio}.");
                        break; 
                    }
                    else if (palpite > numeroAleatorio)
                    {
                        Console.WriteLine("O número é menor que o seu palpite.");
                    }
                    else
                    {
                        Console.WriteLine("O número é maior que o seu palpite.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
                }
            }

            if (!numeroCorreto)
            {
                Console.WriteLine($"Você perdeu! O número era {numeroAleatorio}.");
            }
        }
             
        
        public static void ExibirX()
        {
            int tamanho = 25;
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    if (i == j || i + j == tamanho - 1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
