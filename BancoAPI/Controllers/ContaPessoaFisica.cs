using Microsoft.AspNetCore.Mvc;
using TiposConta;

namespace BancoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaPessoaFisicaController : ControllerBase
    {

        ContaFisica conta;

        public ContaPessoaFisicaController()
        {
            conta = new ContaFisica("Caroline", "444666777", 26, "Desenvolvedora");
            conta.NumConta = 12345;
            conta.NumAgencia = 0001;
            conta.TipoConta = ETipoConta.TipoCorrente;
            conta.Endereco = "Avenida Rio Pequeno, 118";
            conta.Saldo = 50000;
        }

        [HttpGet("VerSaldo")]
        public ActionResult<string> Get()
        {
            try
            {
                return conta.VerSaldo();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Sacar")]
        public ActionResult<string> Get(int valor)
        {
            try
            {
                return conta.Sacar(valor);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("DepositarValor")]
        public ActionResult<string> Post(int valor)
        {
            try
            {
                return conta.Depositar(valor);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("AlterarProfissao")]
        public ActionResult<ContaFisica> Put(string novaProfissao)
        {
            try
            {
                conta.Profissao = novaProfissao;
                return Ok(conta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpDelete("DesativarConta")]
        public ActionResult<ContaFisica> Delete()
        {
            try
            {
                conta.DesativarConta();
                return conta;
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        
    }
}
