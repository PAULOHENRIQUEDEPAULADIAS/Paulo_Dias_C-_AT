
namespace AT
{
    public class AT_09
    {
        public void PequenoEstoque01()
        {

            (string Nome, int QuantidadeEmEstoque, double PrecoUnitario)[] dados = new (string, int, double)[5];
            int dadosInseridos = 0;

            while (true)
            {
                Console.WriteLine("***** Digite a opção desejada *****");
                Console.WriteLine("");
                Console.WriteLine("01 - Inserir Produto");
                Console.WriteLine("02 - Listar Produtos");
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
                    Console.WriteLine("Saindo do programa...");
                    break;
                }
                else if (opcaoConvertida == 1)
                {
                    while (dadosInseridos < 5)
                    {
                        Console.WriteLine($"\nDigite os dados do produto: {dadosInseridos + 1}");

                        Console.Write("Nome do produto: ");
                        string nome = Console.ReadLine();

                        Console.Write("Quantidade: ");
                        string quantidade = Console.ReadLine();

                        Console.Write("Preço do produto: ");
                        string preco = Console.ReadLine();
                        Console.WriteLine("\n");

                        if (String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(quantidade) || String.IsNullOrEmpty(preco))
                        {
                            Console.WriteLine("Nenhum dos dados pode ser vazio, operação cancelada!");
                            break;
                        }

                        if (!Program.ValidarEntradaAlfabetica(nome))
                        {
                            Console.WriteLine("Nome do produto contém caracteres fora os alfabéticos, operação cancelada!");
                            break;
                        }

                        if (!Program.validarEntradaNumericaSemEspaco(preco) || !Program.validarEntradaNumericaSemEspaco(quantidade))
                        {
                            Console.WriteLine("Preço e quantidade devem ser sem espaços, operação cancelada!");
                            break;
                        }

                        int quantidadeConvertida = Convert.ToInt32(quantidade);
                        double precoConvertido = Convert.ToDouble(preco);


                        dados[dadosInseridos] = (nome, quantidadeConvertida, precoConvertido);
                        dadosInseridos++;

                        if (dadosInseridos < 5)
                        {
                            Console.Write("\nDeseja adicionar mais produtos? (S/N): ");
                            string continuar = Console.ReadLine().ToUpper();

                            if (continuar != "S")
                            {
                                break;
                            }
                        }
                    }
                    if (dadosInseridos >= 5)
                    {
                        Console.WriteLine("\nLimite de produtos atingido!");
                    }
                }
                else if (opcaoConvertida == 2)
                {
                    if (dadosInseridos == 0)
                    {
                        Console.WriteLine("Nenhum produto cadastrado ainda.");
                    }
                    else
                    {
                        Console.WriteLine("\n--- Lista de Produtos Cadastrados ---");
                        for (int i = 0; i < dadosInseridos; i++)
                        {
                            Console.WriteLine($"Produto {i + 1}: Nome: {dados[i].Nome} | Quantidade: {dados[i].QuantidadeEmEstoque} | Preço: R$ {dados[i].PrecoUnitario:F2}");
                        }
                    }
                }
            }
        }

        public void PequenoEstoque02()
        {
            string nomeDoArquivo = "estoque.txt";
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

                Console.WriteLine("\n***** Digite a opção desejada *****");
                Console.WriteLine("");
                Console.WriteLine("01 - Inserir Produto");
                Console.WriteLine("02 - Listar Produtos");
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
                    Console.WriteLine("Saindo do programa...");
                    break;
                }
                else if (opcaoConvertida == 1)
                {
                    using (StreamWriter writer = new StreamWriter(caminhoDoArquivo, true))
                    {
                        while (true)
                        {
                            Console.Write("\nDigite o nome do produto que deseja inserir: ");
                            string produto = Console.ReadLine();

                            Console.Write("Digite o preço unitário do produto inserido: ");
                            string preco = Console.ReadLine();

                            if (!Program.ValidarEntradaAlfabetica(produto) || !Program.validarEntradaNumericaComCasasDecimais(preco))
                            {
                                Console.WriteLine("\nDados inválidos, digite dados alfabéticos para o nome e numéricos para o preço com '.' para casas decimais. \nOperação cancelada!");
                                break;
                            }

                            writer.WriteLine($"{produto} - {preco}");

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
                        using (StreamReader reader = new StreamReader(caminhoDoArquivo))
                        {
                            string linha;
                            while ((linha = reader.ReadLine()) != null)
                            {
                                
                                string[] dadosProduto = linha.Split(" - "); 

                                
                                if (dadosProduto.Length == 2)
                                {
                                    string nome = dadosProduto[0];
                                    double preco = Convert.ToDouble(dadosProduto[1]);

                                    Console.WriteLine($"* {nome} - R$ {preco:F2}");
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
