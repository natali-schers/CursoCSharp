namespace Exercicio9
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }

        public string Titular { get; set; }

        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public ContaBancaria(int numeroConta, string titular, double saldo) : this(numeroConta, titular) { 
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return "Conta: " + NumeroConta + ". Titular: " + Titular + ". Saldo: R$" + Saldo.ToString("F2") + ".";
        }
    }
}