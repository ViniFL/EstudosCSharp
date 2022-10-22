using bootcamp_dio.Models;

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Vinicius";
// pessoa1.Idade = 21;
// pessoa1.Apresentar();

// DateTime dataAtual = DateTime.Now; 
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


// int a = int.MaxValue;
// long b = a;
// Console.WriteLine(b);


// double c = 4 / (2 + 2);
// Console.WriteLine(c);

// string a = "15";

// int b = Convert.ToInt32(a);

// Console.WriteLine(b);


// string a = "15-";

// int.TryParse(a, out int b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada");



// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if(quantidadeCompra == 0)
// {
//     Console.WriteLine("Compra inválida");
// }

// if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }


// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":  
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }








// Método usando Pipe para verificação 

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u" )
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é vogal");
// }






// método usando IF, ELSE IF e ELSE, mas o código fica extenso e difícil de fazer manutenção.

// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }










bool ehMaiorDeIdade = false;
bool possuiAutorizacaoDoResponsavel = true;

if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada");
}
else
{
    Console.WriteLine("Entrada negada");
}