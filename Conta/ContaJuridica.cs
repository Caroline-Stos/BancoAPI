namespace Conta
{
    public class ContaJuridica : Conta
    {
        public string NomeFantasia { get; set; } 
        private int CNPJ { get; set; } = 0;
        public string Socio_1 { get; set; }
        public string Socio_2 { get; set; }
        public int CPF_Socio_1 { get; set; }
        public int CPF_Socio_2 { get; set; }

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
