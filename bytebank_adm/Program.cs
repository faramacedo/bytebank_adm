﻿using bytebank_adm.Funcionarios;


Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro Malazartes";
pedro.Cpf = "123456789";
pedro.Salario = 2000;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor();
roberta.Nome = "Roberta Silva";
roberta.Cpf = "987654321";
roberta.Salario = 5000;

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());