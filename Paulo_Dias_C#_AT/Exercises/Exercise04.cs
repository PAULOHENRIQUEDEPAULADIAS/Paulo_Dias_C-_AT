using System;
using System.Globalization;


namespace AT
{
    public class AT_04
    {
        public void Exercise4()
        {
            while(true)
            {
                DateTime date = DateTime.Now;
                CultureInfo ptBr = CultureInfo.CreateSpecificCulture("pt-BR");

                Console.WriteLine("Digite sua data de nascimento (Formato dd/mm/YYYY)");
                string birthday = Console.ReadLine();

                if (!Program.validadeEntradaDeData(birthday))
                {
                    Console.WriteLine("Entrada inválida!");
                    continue;
                }

                DateTime convertedBirthday = DateTime.ParseExact(birthday, "dd/MM/yyyy", ptBr);


                int birthdayDay = convertedBirthday.Day;
                int birthdayMonth = convertedBirthday.Month;
                int bithdayYear = convertedBirthday.Year;

                int dateDay = date.Day;
                int dateMonth = date.Month;
                int dateYear = date.Year;

                DateTime nextBirthday;

                if (birthdayMonth < dateMonth || (birthdayMonth == dateMonth && birthdayDay < dateDay))
                {
                    nextBirthday = new DateTime(dateYear + 1, birthdayMonth, birthdayDay);
                }
                else
                {
                    nextBirthday = new DateTime(dateYear, birthdayMonth, birthdayDay);
                }

                TimeSpan intervalo = nextBirthday - date;


                if (intervalo.Days < 7)
                {
                    Console.WriteLine($"Seu aniversário está muitoooo perto, faltam {intervalo.Days} dias pra chegar.");
                    break;
                }

                Console.WriteLine($"Faltam {intervalo.Days} dias para o próximo aniversário.");
                break;
            }    
        }
    }
}
