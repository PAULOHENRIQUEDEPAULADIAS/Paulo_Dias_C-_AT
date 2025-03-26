
namespace AT
{
    public class ContaBancaria
    {
        public string titular;
        private double saldo;

        public ContaBancaria(string titular, double saldo)
        {
            this.titular = titular;
            this.saldo = saldo;
        }

        public string Titular { get; private set; }

        public double Saldo => saldo;

        public void Depositar(double deposito)
        {
            if (deposito <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo!");
            }
            else
            {
                this.saldo += deposito;
                Console.WriteLine($"Depósito de R$ {deposito} realizado com sucesso!");
            }
        }

        public void Sacar(double saque)
        {

            Console.WriteLine($"Tentativa de saque: R$ {saque}");

            if (saque <= 0)
            {
                Console.WriteLine("O valor do saque deve ser positivo!");
            }
            else if (saque > this.saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque!");
            }
            else if (saque < this.saldo)
            {
                this.saldo -= saque;
                Console.WriteLine($"Saque de R$ {saque} realizado com sucesso!");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Titular: {this.titular}\n" +
                              $"Saldo atual: R$ {this.saldo}");
        }
    
    }
}
