namespace Conta
{
    public interface IConta
    {
        // propriedades
        int NumAgencia { get; set; }
        int NumConta { get; set; }
        string TipoConta { get; set; }
        double Saldo { get; set; }
        string Endereco { get; set; }

        // metodos
        string Sacar(double valor);
        string Depositar(double valor);
        string VerSaldo();
    }
}
