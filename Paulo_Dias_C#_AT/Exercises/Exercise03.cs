
namespace AT
{
    public class AT_03
    {
        public void Exercise3()
        {
            while (true)
            {
                Console.WriteLine("Digite dois números separados por espaço diferentes de 0 (Formato 'XX XX')");
                string number = Console.ReadLine();
                Console.WriteLine(" ");


                // Permite a entrada de números com 0 à sua direita, mas não numerais 0 somente, também, exige separação dos númeors por espaço.
                if (!Program.validarEntradaNumericaComEspaco(number))
                {
                    Console.WriteLine("Entrada inválida!");
                    continue;
                }

                string[] splittedNumbers = number.Split(" ");

                int[] convertedNumbers = new int[splittedNumbers.Length];

                for (int i = 0; i < splittedNumbers.Length; i++)
                {
                    convertedNumbers[i] = Convert.ToInt32(splittedNumbers[i]);
                }


                int a = convertedNumbers[0];
                int b = convertedNumbers[1];

                Console.WriteLine("Digite o número da opção desejada");
                Console.WriteLine("01 - Soma");
                Console.WriteLine("02 - Subtração");
                Console.WriteLine("03 - Multiplicação");
                Console.WriteLine("04 - Divisão");
                Console.WriteLine(" ");

                string operation = Console.ReadLine();

                if (!Program.validarEntradaNumericaSemEspaco(operation))
                {
                    Console.WriteLine("Número de operação inválido!");
                    continue;
                }

                int convertedOperation = Convert.ToInt32(operation);

                switch (convertedOperation)
                {
                    case 1: Console.WriteLine($"A soma de {a} e {b} é: {a + b}");
                        break;
                    case 2: Console.WriteLine($"A subtração de {a} e {b} é: {a - b}");
                        break;
                    case 3: Console.WriteLine($"A multiplicação de {a} e {b} é: {a * b}");
                        break;
                    case 4: Console.WriteLine($"A divisão de {a} e {b} é: {a / b}");
                        break;
                    default: Console.WriteLine("Opção da operação inválida, operação cancelada");
                        break;
                }

                break;
            }

        }
    }
}

