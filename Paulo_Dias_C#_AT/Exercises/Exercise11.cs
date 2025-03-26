
namespace AT
{
    public class Exercise11
    {
        public void Exercise011()
        {
            string nomeDoArquivo = "contatos.txt";
            string caminhoDoArquivo = Path.Combine(Directory.GetCurrentDirectory(), nomeDoArquivo);

            if (!File.Exists(caminhoDoArquivo))
            {
                Console.WriteLine("Criando arquivo estoque.txt...");

                using (StreamWriter writer = new StreamWriter(caminhoDoArquivo))
                {
                }
                Console.WriteLine($"Arquivo criado em: {caminhoDoArquivo}");
            }

            while (true)
            {

                Console.WriteLine("\n=== Gerenciador de Contatos ===");
                Console.WriteLine("");
                Console.WriteLine("01 - Adicionar novo contato");
                Console.WriteLine("02 - Listar contatos cadastrados");
                Console.WriteLine("");
                Console.WriteLine("03 - Sair");

                string opcao = Console.ReadLine();

                if (!Program.validarEntradaNumericaSemEspaco(opcao))
                {
                    Console.WriteLine("Entrada inválida!");
                    continue;
                }

                int opcaoConvertida = Convert.ToInt32(opcao);


                if (opcaoConvertida == 3)
                {
                    Console.WriteLine("Encerrando do programa...");
                    break;
                }
                else if (opcaoConvertida == 1)
                {
                    using (StreamWriter writer = new StreamWriter(caminhoDoArquivo, true))
                    {
                        while (true)
                        {
                            Console.Write("\nDigite o nome do contato que deseja inserir: ");
                            string nome = Console.ReadLine();

                            Console.Write("Digite o telefone do contato (Formato XX XXXXX-XXXX): ");
                            string telefone = Console.ReadLine();

                            Console.Write("Digite o e-mail do contato (Deve conter um @): ");
                            string email = Console.ReadLine();

                            if (!Program.ValidarEntradaAlfabetica(nome))
                            {
                                Console.WriteLine("\nDados inválidos, digite dados alfabéticos para o nome. \nOperação cancelada!");
                                break;
                            }

                            if (!Program.validadeEntradaDeTelefone(telefone))
                            {
                                Console.WriteLine("\nDados inválidos, digite um telefone no formato\n DDD dois dígitos; \nInicio do telefone com 5 dígitos;\nUm traço;\nE o final do telefone com 4 dígitos.\n Operação cancelada!");
                                break;
                            }

                            if (!Program.validadeEntradaDeEmail(email))
                            {
                                Console.WriteLine("\nDados inválidos, digite o e-mail com um @. \nOperação cancelada!");
                                break;
                            }

                            writer.WriteLine($"{nome}, {telefone}, {email}");
                            Console.WriteLine("Contato cadastrado com sucesso!");

                            Console.WriteLine("\nDeseja adicionar mais um produto? S/N");
                            string resposta = Console.ReadLine().ToUpper();
                            Console.WriteLine(" ");

                            if (resposta != "S")
                            {
                                break;
                            }
                        }
                    }
                }

                else if (opcaoConvertida == 2)
                {

                    if (new FileInfo(caminhoDoArquivo).Length == 0)
                    {
                        Console.WriteLine("O arquivo não contém dados!");
                    }
                    else
                    {
                        Console.WriteLine("Contatos cadastrados:");
                        using (StreamReader reader = new StreamReader(caminhoDoArquivo))
                        {
                            string linha;
                            while ((linha = reader.ReadLine()) != null)
                            {

                                string[] dadosProduto = linha.Split(",");
                                
                                if (dadosProduto.Length == 3)
                                {
                                    string nome = dadosProduto[0];
                                    string telefone= dadosProduto[1];
                                    string email = dadosProduto[2];

                                    Console.WriteLine($"* Nome: {nome} | Telefone: {telefone} | E-mail: {email}");
                                }
                                else
                                {
                                    Console.WriteLine("Erro ao ler os dados do produto.");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
