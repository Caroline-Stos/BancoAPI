using Conta;
using System.Net;

ContaFisica Pessoa = new ContaFisica();

Console.WriteLine(Pessoa.VerSaldo());

Console.WriteLine(Pessoa.Depositar(15));

Console.WriteLine(Pessoa.Sacar(16));

Pessoa.Nome = "Caroline";
Pessoa.CPF = 12345678;
Pessoa.Idade = 26;
Pessoa.Profissao = "Desenvolvedora Junior";
Pessoa.Endereco = "Avenida Rio Pequeno, 118";
