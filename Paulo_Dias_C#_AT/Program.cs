using System.Text.RegularExpressions;

namespace AT
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== Menu de Exercícios ===");
                Console.WriteLine("1 - Exercício 1 - Criando e Executando seu Primeiro Programa");
                Console.WriteLine("2 - Exercício 2 - Manipulação de Strings - Cifrador de Nome");
                Console.WriteLine("3 - Exercício 3 - Calculadora de Operações Matemáticas");
                Console.WriteLine("4 - Exercício 4 - Manipulação de Datas - Dias até o Próximo Aniversário");
                Console.WriteLine("5 - Exercício 5 - Tempo Restante para Conclusão do Curso - Diferença Entre Datas");
                Console.WriteLine("6 - Exercício 6 - Cadastro de Alunos");
                Console.WriteLine("7 - Exercício 7 - Banco Digital (Encapsulamento)");
                Console.WriteLine("8 - Exercício 8 - Cadastro de Funcionários (Herança)");
                Console.WriteLine("9 - Exercício 9 - Controle de Estoque via Linha de Comando");
                Console.WriteLine("10 - Exercício 10 - Jogo de Adivinhação");
                Console.WriteLine("11 - Exercício 11 - Manipulação de Arquivos - Cadastro e Listagem de Contatos");
                Console.WriteLine("12 - Exercício 12 - Manipulação de Arquivos com Herança e Polimorfismo - Formatos de Exibição");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                string exercicio = Console.ReadLine();

                if (!int.TryParse(exercicio, out int opcao))
                {
                    Console.WriteLine("Erro: digite uma numeral valido!");
                }

                if (opcao == 1)
                {
                    Console.WriteLine("Executando Exercício 1...");
                    AT_01 exercicio1 = new AT_01();
                    exercicio1.Exercise1();
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Executando Exercício 2...");
                    AT_02 exercicio2 = new AT_02();
                    exercicio2.Exercise2();

                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Executando Exercício 3...");
                    AT_03 exercicio3 = new AT_03();
                    exercicio3.Exercise3();

                }
                else if (opcao == 4)
                {
                    Console.WriteLine("Executando Exercício 4...");
                    AT_04 exercicio4 = new AT_04();
                    exercicio4.Exercise4();
                }
                else if (opcao == 5)
                {
                    Console.WriteLine("Executando Exercício 5...");
                    AT_05 exercicio5 = new AT_05();
                    exercicio5.Exercise5();

                }
                else if (opcao == 6)
                {
                    Console.WriteLine("Executando Exercício 6...");
                    Aluno exercicio6 = new Aluno("George Alfredo", "55031", "Engenharia de Software", 7.1);

                    Console.WriteLine("\n=== Selecione uma ação abaixo ===");
                    Console.WriteLine("1 - Exibir Dados");
                    Console.WriteLine("2 - Verificar se Aprovado");

                    string opc = Console.ReadLine();

                    if (!int.TryParse(opc, out int opcConvertido))
                    {
                        Console.WriteLine("Erro: digite uma numeral valido!");
                    }

                    if (opcConvertido == 1)
                    {
                        exercicio6.ExibirDados();
                    }
                    else if (opcConvertido == 2)
                    {
                        Console.WriteLine(exercicio6.VerificarAprovacao());
                    }

                }
                else if (opcao == 7)
                {
                    Console.WriteLine("Executando Exercício 7...");
                    ContaBancaria exercicio7 = new ContaBancaria("Maria Gorgiana", 10000.00);

                    while (true)
                    {
                        Console.WriteLine("\n=== Selecione uma ação abaixo ===");
                        Console.WriteLine("1 - Sacar");
                        Console.WriteLine("2 - Depositar");
                        Console.WriteLine("3 - Exibir Saldo");
                        Console.WriteLine("0 - Sair");


                        string opc = Console.ReadLine();

                        if (!int.TryParse(opc, out int opcConvertido))
                        {
                            Console.WriteLine("Erro: digite uma numeral valido!");
                        }

                        if (opcConvertido == 1)
                        {
                            Console.Write("Digite o valor de saque desejado: R$ ");
                            string saque = Console.ReadLine();

                            if (!Double.TryParse(saque, out double saqueConvertido))
                            {
                                Console.WriteLine("Digite um valor valido!");
                                continue;
                            }

                            exercicio7.Sacar(saqueConvertido);

                        }
                        else if (opcConvertido == 2)
                        {

                            Console.Write("Digite o valor de deposito desejado: R$ ");
                            string deposito = Console.ReadLine();

                            if (!Double.TryParse(deposito, out double depositoConvertido))
                            {
                                Console.WriteLine("Digite um valor valido!");
                                continue;
                            }

                            exercicio7.Depositar(depositoConvertido);
                        }

                        else if (opcConvertido == 3)
                        {
                            exercicio7.ExibirSaldo();
                        }
                        else if (opcConvertido == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Opcao inexistente!");
                        }
                    }

                }
                else if (opcao == 8)
                {
                    Console.WriteLine("Executando Exercício 8...");
                    Funcionario exercise7 = new Funcionario("Patricia Vieira de Oliveira", "Superintendente", 100000);
                    Gerente exerciseg7 = new Gerente("Nina Souza dos Santos", "Gerente", 100000);

                    exercise7.ExibirDados();
                    exerciseg7.ExibirDados();
                }
                else if (opcao == 9)
                {
                    Console.WriteLine("Executando Exercício 9...");
                    Console.WriteLine("\n=== Deseja interagir com... ===");
                    Console.WriteLine("1 - Pequeno Estoque 1 - Array[5]");
                    Console.WriteLine("2 - Pequeno Estoque 2 - .txt");
                    Console.WriteLine("0 - Sair");


                    string opc = Console.ReadLine();

                    if (!int.TryParse(opc, out int opcConvertido))
                    {
                        Console.WriteLine("Erro: digite uma numeral valido!");
                    }

                    if (opcConvertido == 1)
                    {

                        AT_09 exercicio9 = new AT_09();
                        exercicio9.PequenoEstoque01();

                    }
                    else if (opcConvertido == 2)
                    {

                        AT_09 exercicio9_2 = new AT_09();
                        exercicio9_2.PequenoEstoque02();
                    }

                    else if (opcConvertido == 3)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Error: Opcao Inexistente");
                    }
                }
                else if (opcao == 10)
                {
                    Console.WriteLine("Executando Exercício 10...");
                    Exercise10 exercise10 = new Exercise10();
                    exercise10.Adivinhacao();

                }
                else if (opcao == 11)
                {
                    Console.WriteLine("Executando Exercício 11...");
                    Exercise11 exercise11 = new Exercise11();
                    exercise11.Exercise011();

                }
                else if (opcao == 12)
                {
                    Console.WriteLine("Executando Exercício 12...");
                    Exercise12 exercise12 = new Exercise12();
                    exercise12.Exercise012();
                }
                else if (opcao == 0)
                {
                    Console.WriteLine("Saindo do programa...");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }
            }
        }



        // Regex para validar letras (maiúsculas e minúsculas) e espaços
        public static bool ValidarEntradaAlfabetica(string entrada)
        {
            string pattern = @"^[A-Za-zà-úÀ-Ú\s]+$";
            return Regex.IsMatch(entrada, pattern);
        }

        // Expressão regular que permite apenas números e espaços
        public static bool validarEntradaNumericaComEspaco(string entrada)
        {

            string pattern = @"^(?!0(\s|$))([1-9][0-9]*)(\s([1-9][0-9]*))*$";
            return Regex.IsMatch(entrada, pattern);
        }

        // Expressão regular que permite apenas números com casas decimais

        public static bool validarEntradaNumericaComCasasDecimais(string entrada)
        {
            string pattern = @"^\d{1,3}(?:,\d{3})*(?:\.\d+)?$";
            return Regex.IsMatch(entrada, pattern);
        }


        // Expressão regular que permite apenas números sem espaços
        public static bool validarEntradaNumericaSemEspaco(string entrada)
        {

            string pattern = @"^[0-9]*$";
            return Regex.IsMatch(entrada, pattern);
        }

        // Expressão regular que valida entrada no padrão dd/mm/YYYY
        public static bool validadeEntradaDeData(string entrada)
        {
            string pattern = @"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}$";
            return Regex.IsMatch(entrada, pattern);

        }

        // Expressão regular que valida entrada no padrão XX XXXXX-XXXX
        public static bool validadeEntradaDeTelefone(string entrada)
        {
            string pattern = @"^\d{2} \d{5}-\d{4}$";
            return Regex.IsMatch(entrada, pattern);

        }


        // Expressão regular que valida entrada no @ no e-mail 
        public static bool validadeEntradaDeEmail(string entrada)
        {
            string pattern = @"^.*@.*$";
            return Regex.IsMatch(entrada, pattern);

        }


    }



}
