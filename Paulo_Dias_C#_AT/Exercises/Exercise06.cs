
namespace AT
{
    public class Aluno
    {
        private string nome;
        private string matricula;
        private string curso;
        private double mediaDeNotas;

        public Aluno(string nome, string matricula, string curso, double mediaDeNotas)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.curso = curso;
            this.mediaDeNotas = mediaDeNotas;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {this.nome}\n" +
                              $"Matricula: {this.matricula}\n" +
                              $"Curso: {this.curso}\n" +
                              $"Media de Notas: {this.mediaDeNotas}");

        }

        public string VerificarAprovacao()
        {
            if(this.mediaDeNotas >= 7.00)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
    }
}
