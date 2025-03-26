
namespace AT
{
    public class Funcionario
    {
        private string nome;
        private string cargo;
        private double salarioBase;

        public Funcionario(string nome, string cargo, double salarioBase)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salarioBase = salarioBase;
        }

        public virtual double CalcularSalario()
        {
            return salarioBase;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Funcionário: {nome}\nCargo: {cargo}\nSalário: R$ {CalcularSalario():F2}");
        }
    }

    public class Gerente : Funcionario
    {
        public Gerente(string nome, string cargo, double salarioBase)
            : base(nome, cargo, salarioBase)
        {
        }

        public override double CalcularSalario()
        {
            return base.CalcularSalario() * 1.2;
        }
    }
}
