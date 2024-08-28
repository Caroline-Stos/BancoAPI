using System.ComponentModel.DataAnnotations;

namespace TiposConta
{
    public class Conta : IConta
    {
        private int _saldo;

        [Required]
        public int NumAgencia { get; set; } = 0;

        [Required]
        public int NumConta { get; set; } = 0;

        [Required]
        public ETipoConta TipoConta { get; set; } = 0;

        [Required]
        public bool Status {  get; set; } = true;

        [Required]
        public double Saldo { get; set; } = 0;

        [Required]
        public string Endereco {  get; set; } = string.Empty;

        //metodos
        public virtual string Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                return $"Saque concluído no valor de R$ {valor}, saldo atual: R$ {Saldo}";
            }
            else
            {
                throw new Exception("Saldo insuficente.");
            }
        }

        public virtual string Depositar(double valor)
        {
            if (double.IsPositive(valor))
            {
                Saldo += valor;
                return $"Depósito realizado com sucesso no valor de R$ {valor}, saldo atual: R$ {Saldo}";
            }
            else
            {
                throw new Exception("Valor de deposito inválido");
            }
        }
        public virtual string VerSaldo()
        {
            return $"Saldo: R$ {Saldo} disponível";
        }

        public virtual string DesativarConta()
        {
            Status = false;
            return "Conta desativada com sucesso.";
        }
    }
}
