

namespace AT
{
    public class AT_02
    {
        public void Exercise2()
        {

            while (true)
            {
                Console.Write("Digite um nome a ser Cifrado: ");
                string name = Console.ReadLine();

                if (!Program.ValidarEntradaAlfabetica(name))
                {
                    Console.WriteLine("Entrada inválida, por favor digite apenas dígitos alfabéticos!");
                    break;
                }

                char[] result = new char[name.Length];


                for (int i = 0; i < name.Length; i++)
                {
                    char c = name[i];

                    if (c == ' ')
                    {
                        result[i] = ' ';
                    }

                    else
                    {

                        if (char.IsUpper(c))
                        {
                            int newIndex = (c - 'A' + 2) % 26 + 'A';

                            result[i] = (char)newIndex;
                        }
                        else if (char.IsLower(c))
                        {
                            int newIndex = (c - 'a' + 2) % 26 + 'a';

                            result[i] = (char)newIndex;
                        }
                    }
                }

                string converted = new string(result);
                Console.WriteLine("Resultado: " + converted);
                break;
            }
        }
    }
}