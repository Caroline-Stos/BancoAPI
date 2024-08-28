using TiposConta;

Conta Pessoa = new ContaFisica("Caroline", "44455566678", 26, "Desenvolvedora");
ContaFisica PessoaPF = (ContaFisica)Pessoa;

Console.WriteLine(PessoaPF.Nome);
Console.WriteLine(PessoaPF.CPF);
Console.WriteLine(PessoaPF.Profissao);

PessoaPF.NumConta = 12345;
PessoaPF.NumAgencia = 0001;
PessoaPF.TipoConta = ETipoConta.TipoCorrente;

PessoaPF.Endereco = "Avenida Rio Pequeno, 118";

Console.WriteLine(PessoaPF.NumConta);
Console.WriteLine(PessoaPF.NumAgencia);
Console.WriteLine(PessoaPF.TipoConta);
Console.WriteLine(PessoaPF.Endereco);

Console.WriteLine(Pessoa.VerSaldo());

Console.WriteLine(Pessoa.Depositar(200));

Console.WriteLine(Pessoa.VerSaldo());

Console.WriteLine(Pessoa.Sacar(16));

Console.WriteLine(Pessoa.VerSaldo());


