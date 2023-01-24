//Código Modificado por Luiz Gustavo
//Assista as gravações destas modificações no canal L GUSTAVO - PROGRAMADOR PROFISSIONAL
// LINK DO CANAL - https://www.youtube.com/@lgustavo-programador
// LINK da PLAYLIST BOOTCAMP POTTENCIAL - https://www.youtube.com/watch?v=GHP6S3zKy7Y&list=PLNvQEEUeLujsHq1qF7Ze3C7FsE0ll3XyD

using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;


try{
// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Hóspede 3");
Pessoa p4 = new Pessoa(nome: "Hóspede 4");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 8);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
}catch(Exception ex){
Console.WriteLine($"Ocorreu uma exceção genérica.{ex.Message}");  
}

Console.WriteLine("Chegou AQUI"); 