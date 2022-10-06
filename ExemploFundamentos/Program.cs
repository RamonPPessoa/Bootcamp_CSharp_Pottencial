
using ExemploFundamentos.Models;


DateTime dataAtual = DateTime.Now;

System.Console.WriteLine(dataAtual);

DateTime dataAtua2 = DateTime.Now.AddDays(2);
System.Console.WriteLine(dataAtua2);
System.Console.WriteLine(dataAtua2.ToString("dd/MM/yyyy HH:mm"));

// string apresentacao = "Hello, welcome";

// int quantidade = 3;
//  double altura = 1.84;

//  decimal preco = 1.50M;
//  bool condicao = true;

//  Console.WriteLine( apresentacao);
//  Console.WriteLine("Quantidade:" + quantidade);
//  Console.WriteLine("Altura: " + altura.ToString("0.00"));
//  Console.WriteLine("Preço: " + preco);
//  Console.WriteLine("Condição: " + condicao);



// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "João";
// pessoa1.Idade = 18;
// pessoa1.Apresentar();