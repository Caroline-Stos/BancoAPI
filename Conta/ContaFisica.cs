namespace Conta
{
    public class ContaFisica : Conta
    {
        public string Nome { get; set; }
        public int CPF { get; set; } = 0;
        public int Idade { get; set; } = 0;
        public string Profissao { get; set; }

        // metodos
        public override string Sacar(double valor)
        {
            return base.Sacar(valor);
        }
        public override string Depositar(double valor)
        {
            return base.Depositar(valor);
        }
        public override string VerSaldo()
        {
            return base.VerSaldo();
        }
    }
}
