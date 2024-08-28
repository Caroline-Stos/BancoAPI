using TiposConta;

namespace TiposConta
{
    public interface IConta
    {
        // propriedades
        int NumAgencia { get; set; }
        int NumConta { get; set; }
        ETipoConta TipoConta { get; set; }
        double Saldo { get; set; }
        string Endereco { get; set; }
        bool Status { get; set; }

        // metodos
        string Sacar(double valor);
        string Depositar(double valor);
        string VerSaldo();
    }
}
