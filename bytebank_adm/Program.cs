using bytebank_adm.Funcionarios;


Funcionario pedro = new Funcionario("123456789", 2000);
pedro.Nome = "Pedro Malazartes";
//pedro.Cpf = "123456789";
//pedro.Salario = 2000;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor("987654321",5000);
roberta.Nome = "Roberta Silva";
//roberta.Cpf = "987654321";
//roberta.Salario = 5000;

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine($"Total de bonificações: R$ {gerenciador.GetBonificacao()}");
Console.WriteLine($"Total de funcionários: {Funcionario.TotalDeFuncionarios} \n");

pedro.AumentarSalario();
roberta.AumentarSalario();

Console.WriteLine($"Novo salário do Pedro: R$ {pedro.Salario}");
Console.WriteLine($"Novo salário do Roberta: {roberta.Salario}");
