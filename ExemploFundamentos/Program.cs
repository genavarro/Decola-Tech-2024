using ExemploFundamentos.Models;


//Listas 
// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");


// Console.WriteLine("Percorrendo o array com o for");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição de N {contador } - {listaString[contador]}");
// }


// Console.WriteLine("Percorrendo o array com o foreach");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição de N {contadorForeach } - {item}");
//     contadorForeach++;
// }
























// //Implementando Array - variavel que armazena diversos valores

// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// int[] arrayInteirosDobrado = new int [arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length );


// //Aumentando a capacidade do array
// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2 );

// Console.WriteLine("Percorrendo o array com o for");
// //Percorrendo o array com o for
// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição numero {contador} - {arrayInteiros[contador]}");
// }

// // //Percorrendo o array com o foreach
// // Console.WriteLine("Percorrendo o array com o foreach");
// // foreach(int valor in arrayInteiros)
// // {
// //     Console.WriteLine(valor);
// // }














// //Refatorando o Exemplo de Menu Interativo com DO WHILE
// string opcao;
// bool exibirmenu = true;
// while(exibirmenu)
// {

//     Console.WriteLine("Digite a sua opção");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//    opcao = Console.ReadLine();  

//    switch(opcao)
//    {
//     case "1":
//         Console.WriteLine("Cadastro de cliente");
//         break;

//     case "2":
//         Console.WriteLine("Buscar cliente");
//         break;

//     case "3":
//         Console.WriteLine("Apagar cliente");
//         break;

//     case "4":
//         Console.WriteLine("Encerrar");
//         exibirmenu = false; 
//         //Environment.Exit(0);
//         break;

//     default:
//         Console.WriteLine("Opção inválida");
//     break;
//    } 

// }

// Console.WriteLine("O programa se encerrou");










//Estrutura de repetição DO WHILE

// int soma = 0, numero = 0;

// do 
// {
//     Console.WriteLine("Escreva um numero: (0 para parar) ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero; 

// } while(numero != 0);

// Console.WriteLine($"Total da soma dos numeros é {soma}");


























// //Interrompendo o fluxo de execução (BREAK)
// int numero = 5;
// int contador = 0;


// while(contador <= 10)
// {
//     Console.WriteLine($"{contador + 1} execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     } 
// }





















// //Estrutura de repetição (FOR) - Tabuada 
// int numero = 5; 


// for(int contador = 0; contador <= 10; contador++)
// {
//    Console.WriteLine($"{numero} x {contador} =  {numero * contador}"); 







// // Raiz quadrada
// Calculadora calc = new Calculadora();

// calc.RaizQuadrada(9);








// //Incremento e Decremento 

// int numeroIncremento = 10;

// Console.WriteLine("Incremento ao numero 10");
// numeroIncremento++;

// Console.WriteLine(numeroIncremento);


// int numeroDecremento = 10;

// Console.WriteLine("Decremento ao numero 10");
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);
















//Classe calculadora utilizando Seno, Coseno e Tangente
// Calculadora calc = new Calculadora();

// calc.Somar(7, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15,45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);

















// //Operador NOT (!)
// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }











// //Operador AND (&&)

// bool possuiPresencaMinima = true; 
// double media = 7; 


// if (possuiPresencaMinima && media >= 7 )

// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }








// // Operador OR (||)
// bool maiorDeIdade = false;
// bool possuiAutorizacaoResponsavel = true;


// if (maiorDeIdade || possuiAutorizacaoResponsavel)
// {
//     Console.WriteLine("Entrada liberada");
// }
// else 
// {
//     Console.WriteLine("Entrada não liberada");
// }






// //Switch Case
// Console.WriteLine("Digite uma letra ");
// string letra = Console.ReadLine();


// switch(letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//         default:
//             Console.WriteLine("Consoante");
//         break;
// }


// if (letra ==  "a" ||
//     letra ==  "e" ||
//     letra ==  "i" ||
//     letra ==  "o" ||
//     letra ==  "u")

//   {
//      Console.WriteLine("Vogal");
    
//   } 

// else
// {
//     Console.WriteLine("Consoante");
// } 






















//Operador Condicional (if aninhado)

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0; 
// bool possivelVenda =quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda?  {possivelVenda}");


// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada");

// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidadr desejada no estoque");
// }
















// int b = 0;

// int.TryParse(a, out b);
// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso");




//Ordem dos operadores
// double a = 4 / (2 + 2); 

// Console.WriteLine(a);


//Cast implicito - converte tipos de variaveis de maneira implicita
// int a = 5;
// double b = a;
// Console.WriteLine(b);



// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);



//Cast/ Casting - convertendo tipos de variáveis
// Convert.ToInt32(metodo); - converte tipos de variáveis - o Convert aceita valor nulo 
// ou
// int.Parse(metodo); - converte tipos de variáveis o Parse não aceita valor nulo


// int a = Convert.ToUInt32("5");
// int a = int.Parse("5");

// Console.WriteLine(a);




// int a = 10;
// int b = 20; 

// int c = a + b;

// // c = c + 5; 
// // combinação de operadores: +=, -=, /=, *= 

// c += 5;


// Console.WriteLine(c);







// DateTime  dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/mm/yyyy"));



// string apresentacao = "Olá, seja bem-vindo!";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;
// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variavel quantidade " + quantidade);
// Console.WriteLine("Valor da variavel altura " + altura);
// Console.WriteLine("Valor da variavel preço " + preco);
// Console.WriteLine("Valor da variavel condição " + condicao);




// // Pessoa pessoa1 = new Pessoa();
// // pessoa1.Nome = "Geovanna";
// // pessoa1.Idade = 21;
// // pe ssoa1.Apresentar();