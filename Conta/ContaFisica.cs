namespace TiposConta
{
    public class ContaFisica : Conta
    {
        public string Nome { get; set; }
        public string CPF { get; set; } = string.Empty;
        public int Idade { get; set; } = 0;
        public string Profissao { get; set; }

        public ContaFisica(string nome, string cpf, int idade, string profissao)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            Profissao = profissao;
        }

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
        public override string DesativarConta()
        {
            return base.DesativarConta();
        }
    }
}
