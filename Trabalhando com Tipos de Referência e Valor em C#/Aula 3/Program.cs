using static System.Console;

Pessoa p1 = new Pessoa();

p1.Nome = "João";
p1.Idade = 20;
p1.EnderecoPessoa = new Endereco() {
    Logradouro = "Rua dos Bobos",
    Numero = 0,
    CEP = "00000-000",
    Cidade = "São Paulo"
};
