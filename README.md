# EstudosCSharp
Repositório criado para estudo na linguagem C# com anotações feitas para cada módulo estudado.

Anotações de estudos desde a preparação de ambiente até o último módulo estudado. Sempre que tiver mais anotações pretendo adiciona-las neste Readme.

Espero poder contribuir para alguem que estiver iniciando na linguagem ou no mundo da programação e queira aproveitar essas anotações que fiz e que me ajudaram.
Marquei tudo aquilo que achava necessário e importante na linguagem.



////// Preparação de ambiente e introdução

Win + R = abrir cmd 
Dentro do cmd usar dotnet --info = trás informações sobre o .NET instalado na maquina

OBS. Também é possível usar o comando dentro do terminal do VSCode.

Quando estiver no VSCode, usar o comando: dotnet new console para criar um novo projeto.
Para executar o algoritmo de .NET, usar o comando: dotnet run

Sempre usar CTRL+S para salvar antes de tentar executar!

///// Sintaxe e identação

Nunca esquecer ; no final da linha.

Classes possuem informações que podem ser recebidas ou atribuidas por variáveis e sempre 
terão uma função que executarão.

Sempre que criar uma classe ela primeiramente terá seus atributos e em segundo o método.

Todo nome de classe deve começar com Maiúsculo.

Se a classe não for reconhecida, conferir se o Namespace da classe está correto.

ex. Console.WriteLine($"Olá, meu nome é "+
        $"{Nome}, e tenho {Idade} anos");
Quebra de linha feita dentro do código para diminuir o tamanho da linha.

ex. Console.WriteLine($"Olá, meu nome é {Nome} \n e tenho {Idade} anos");
Quebra de linha feita para saída do código, apenas usar o comando \n aonde você quer
a quebra de linha no OutPut.

C# usa apenas camelCase e PascalCase.
Nome de classe sempre em PascalCase.
Nome de propriedade e de método sempre em Maiúsculo na primeira letra.
Variaveis sempre em camelCase.
Nunca abreviar nome de Classe, propriedade e variavel, sempre colocar o nome por extenso.
Sempre seguir as convenções do C#.

/////// Tipos de dados

Os tipos de dados mais utilizados no dia-a-dia são: string, bool, decimal, double, int e object. 

Int e Long são os tipos de dados que mais são utilizados para representar números inteiros, 
mas ainda tem outras opções que seriam uint, short e ulong.

Os três tipos de dados mais utilizados para representar números flutuantes são decimal, double
e float.

"double" costuma ser mais efetivo que "float".

Sempre que for trabalhar com valores monetários no C# deve-se utilizar o "decimal" para números
flutuantes.

DateTime serve para datas e horário.
DateTime é a variável mais importante para lidar com datas.
DateTime dataAtual = DateTime.Now; Console.WriteLine(dataAtual);
Para adicionar mais dias ou horas é só usar Now.add que irá aparecer alguns métodos do C#.
Também é possível usar o método ToString("dd/MM/yyyy HH:mm") logo após usar printar a variável 
somente com a data e horário sem minutos.

///// Operadores de Atribuição

Servem para que você possa atribuir um determinado valor para uma variável.

É possível converter o tipo da variável em c# utilizando o método Cast/Casting, que consiste
em usar o método Convert.To'tipo'.
Também existe o método Parse para essa função
A diferança entre Parse para o Convert é o tratamento de valores nulos.
Convert recebe o valor nulo, mas consegue retornar 0, já o Parse quebra o código.
Para converter um valor para String, basta usar a função 'variavel'.ToString();.
Existe o método de Cast Implícito, que se baseia em criar uma variável com o tipo que você
quer receber e passar a variável que está com o valor que você precisa dentro da variável nova.
Porém Cast Implicito só é bem situacional, não podendo ser utilizado sempre.
Existe a função TryParse para fazer conversão de forma segura.

Para aumentar a prioridade de uma operação matemática, deve se usar () e passar a conta
que tem prioridade dentro desse parenteses.

//////// Operadores Condicionais 

É possível passar uma variável dentro de um IF em c#, porém apenas se tiver uma lógica por trás.
Existe um jeito de ter mais de um IF dentro do código, esse método é o IF aninhado que funciona 
como o ELIF do Python.
Quando tiver que usar um IF aninhado, é melhor usar o Switch Case, facilita para futuras
manutenções de código.

//////// Operadores Lógicos

Operador OR também é chamado de operador Pipe.
||= serve como OR. (exp1 || exp2)
&& = Serve como AND. (exp1 && exp2)
! = Serve como negação ou NOT. !(exp) 

OR sempre continua tentando validar as condições até encontrar uma que seja verdadeira, 
então se tiver apenas uma condição verdadeira ele vai validar.

AND é o operador mais restrito dos operadores lógicos, isso se deve pelo fato de que ao 
contrário de OR, AND só é verdadeiro se todas as condições forem verdadeiras, se uma delas
for falsa o código sempre irá pelo caminho falso.

NOT tem a função para inverter uma condição ou apenas para negação.


//////////// Operadores aritméticos

+ adição, - subtração, * multiplicação, / divisão - Operadores de matemática normal.

% = Módulo - Serve para representar o resto da divisão. EXP. x % y
++ = Incremento - Significa que vai aumentar o valor em 1. EXP. x++
-- = Decremento - Significa que vai diminuir o valor em 1. EXP. x--

Para outras operações matemáticas mais avançadas, pode ser usada a classe "Math".

/////////// Estrutura de repetição 

O laço de estrutura de repetição funciona a partir de um contador, que repetira uma 
condicional enquanto ela é verdadeira até que ela seja falsa.
