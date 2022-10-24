﻿using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Angelo ", sobrenome:"Souza");
Pessoa p2 = new Pessoa(nome: "Maria ", sobrenome:"Matos");
Pessoa p3 = new Pessoa(nome: "Joao ", sobrenome:"Henrique");
Pessoa p4 = new Pessoa(nome: "Claudia ", sobrenome:"Grande");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 150);


// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
Console.WriteLine(p1.NomeCompleto);
Console.WriteLine(p2.NomeCompleto);
Console.WriteLine(p3.NomeCompleto);
Console.WriteLine(p4.NomeCompleto);
