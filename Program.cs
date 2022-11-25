using bootcamp_dio.Models;

// Exemplo de menu interativo usando uma estrutura de repetição While
string opcao;
bool exibirMenu = true;


while(exibirMenu)
{
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false; // Utilizando essa maneira, fez com que meu código ainda compilasse até o que está fora desse laço. 
            // Environment.Exit(0); = Essa função faria com que o código não compilasse mais nada a partir daqui.
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
Console.WriteLine("O programa se encerrou");
















// Exemplo de do while
// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma +=numero;
// } while(numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");





// Exemplo de laço de repetição com While
// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     }
// }



// Exemplo de laço de repetição com For
// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }







// Calculadora calc = new Calculadora();

// // calc.Somar(10, 30);
// // calc.Subtrair(10, 50);
// // calc.Multiplicar(15, 45);
// // calc.Dividir(2, 2);
// // calc.Potencia(2, 5);
// // calc.Seno(30);
// // calc.Coseno(30);
// // calc.Tangente(30);
// calc.RaizQuadrada(9);


// formula para incremento
// int numeroIncremento = 10;

// Console.WriteLine("Incrementando o 10");
// // numero = numero + 1;
// numeroIncremento++;

// Console.WriteLine(numeroIncremento);

// // formula para decremento
// int numeroDecremento = 20;

// Console.WriteLine("Decrementando o 20");
// // numero = numero - 1;
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);





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







// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = true;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada");
// }
// else
// {
//     Console.WriteLine("Entrada negada");
// }






// bool possuiPresencaMinima = true;
// double media = 7.5;

// if(possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }



