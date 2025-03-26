using System;
using System.Globalization;


namespace AT
{
    public class AT_05
    {
        public void Exercise5()
        {
            while (true)
            {

                CultureInfo ptBr = CultureInfo.CreateSpecificCulture("pt-BR");
                DateTime converteGraduationDate = DateTime.ParseExact("15/06/2027", "dd/MM/yyyy", ptBr);

                Console.WriteLine("Digite a data atual (formato dd/mm/YYYY)");

                string date = Console.ReadLine();

                if (!Program.validadeEntradaDeData(date))
                {
                    Console.WriteLine("Entrada Inválida!");
                }

                DateTime converteDate = DateTime.ParseExact(date, "dd/MM/yyyy", ptBr);

                int graduationDay = converteGraduationDate.Day;
                int graduationMonth = converteGraduationDate.Month;
                int graduationYear = converteGraduationDate.Year;

                int dateDay = converteDate.Day;
                int dateMonth = converteDate.Month;
                int dateYear = converteDate.Year;

                int dayDiff = graduationDay - dateDay;
                int monthDiff = graduationMonth - dateMonth;
                int yearDiff = graduationYear - dateYear;

                TimeSpan interval = converteGraduationDate - converteDate;

                if (converteDate > DateTime.Now)
                {
                    Console.WriteLine("Erro: A data informada não pode ser no futuro!");
                    break;
                }

                if (interval.TotalDays < 0)
                {
                    Console.WriteLine("A data de formatura já passou!");
                    Console.WriteLine("Parabéns pela conquista!");
                    break;
                }
                else
                {
                    if (monthDiff < 0)
                    {
                        monthDiff += 12;
                        yearDiff--;
                    }

                    if (dayDiff < 0)
                    {
                        int lastMonth = converteDate.Month - 1;
                        int lastYear = converteDate.Year;

                        if (lastMonth == 0)
                        {
                            lastMonth = 12;
                            lastYear--;
                        }

                        DateTime firstDayofActualMonth = new DateTime(lastYear, lastMonth, 1);
                        DateTime lastDayOfLastMonth = firstDayofActualMonth.AddDays(-1);
                        int daysInLastMonth = lastDayOfLastMonth.Day;

                        dayDiff += daysInLastMonth;
                        monthDiff--; 
                    }
                    if (monthDiff <= 6 && yearDiff == 0)
                    {
                        Console.WriteLine($"Faltam {monthDiff} meses e {dayDiff} dias para a sua formatura!.");
                        Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
                        break;

                    }
                    Console.WriteLine($"Faltam {yearDiff} anos, {monthDiff} meses e {dayDiff} dias para a sua graduação.");
                    break;
                }
            }
        }
    }
}
