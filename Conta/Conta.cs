namespace Conta 
{
    public class Conta : IConta
    {
        private int _saldo;
        public int NumAgencia { get; set; } = 0;
        public int NumConta { get; set; } = 0;
        public string TipoConta { get; set; } = string.Empty;
        public double Saldo { get; set; } = 0;
        public string Endereco {  get; set; } = string.Empty;

        //metodos
        public virtual string Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                return $"Saque concluído no valor de R${valor}";
            }
            else
            {
                return "Saldo insuficiente";
            }
        }

        public virtual string Depositar(double valor)
        {
            if (double.IsPositive(valor))
            {
                Saldo += valor;
                return $"Depósito realizado com sucesso no valor de R${Saldo}";
            }
            else
            {
                return "Valor de deposito inválido";
            }
        }
        public virtual string VerSaldo()
        {
            return $"Saldo: R${Saldo} disponível";
        }
    }
}
