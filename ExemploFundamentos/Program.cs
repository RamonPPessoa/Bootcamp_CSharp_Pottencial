
using ExemploFundamentos.Models;



// Operador Condicional

int qtdEstoque = 20;
int qtdCompra = 15;
bool venda = qtdEstoque >= qtdEstoque;

Console.WriteLine($"Quantidade no estoque:  {qtdEstoque}");
Console.WriteLine($"Quantidade de compra:  {qtdCompra}");
Console.WriteLine($"Realizar venda? {venda}");



if (venda)
{
   Console.WriteLine("Venda efetuada"); 
}
else
{
    Console.WriteLine("Produto esgotado no estoque");
}






// convertendo de maneira segura

// string a = "15-";

// int.TryParse(a,out int b);
// Console.WriteLine(b);
// Console.WriteLine("Sucesso");


// cast implicito
//  int a = int.MaxValue;
//  long b = a;

//  Console.WriteLine(b);


// int inteiro = 5;
// string a = inteiro.ToString();

// Casting convertesndo tipos de variáveis

//int a = Convert.ToInt32("10"); o convert aceita null

// int a = int.Parse("5"); // o Parse não aceita null
// Console.WriteLine(a);

// int a = 10;
// int b = 5;

// int c = a + b;

// c +=5;

// Console.WriteLine(  c);
// DateTime dataAtual = DateTime.Now;

// System.Console.WriteLine(dataAtual);

// DateTime dataAtua2 = DateTime.Now.AddDays(2);
// System.Console.WriteLine(dataAtua2);
// System.Console.WriteLine(dataAtua2.ToString("dd/MM/yyyy HH:mmgit commit "));

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