//Variaveis
// string nome = "Heitor";
// int idade = 23;
// double altura = 1.76;
// Console.WriteLine("Nome: {0}", nome);
// Console.WriteLine("Idade: {0}", idade); 
// Console.WriteLine("Altura: {0}", altura);


//Variáveis e Operadores
// int valor1,valor2;
// valor1 = 10;
// valor2 = 2;
// Console.WriteLine("Soma: {0}", valor1 + valor2);
// Console.WriteLine("Subtração: {0}", valor1 - valor2);
// Console.WriteLine("Multiplicação: {0}", valor1 * valor2);
// Console.WriteLine("Divisão: {0}", valor1 / valor2);


//Operadores de Atribuição
// double a = 10;
// Console.WriteLine("Resultado: {0}", a);
// a+=3;
// Console.WriteLine("Resultado: {0}", a);
// a-=3;
// Console.WriteLine("Resultado: {0}", a);
// a*=3;
// Console.WriteLine("Resultado: {0}", a);
// a/=3;
// Console.WriteLine("Resultado: {0}", a);
// a%=3;
// Console.WriteLine("Resultado: {0}", a);
// a++;
// Console.WriteLine("Resultado: {0}", a);
// a--;
// Console.WriteLine("Resultado: {0}", a);

//Operadores de Comparação
// int a = 5;
// int b = 5;

// bool Iguais= a == b;

// Console.WriteLine("São iguais? {0}", Iguais);

// int c = 5;
// int d = 4;

// bool Iguais2= c == d;

// Console.WriteLine("São iguais? {0}", Iguais2);

// int e = 5;
// int f = 4;

// bool maior = e > f;

// Console.WriteLine("E é maior que F? {0}", maior);

// int g = 5;
// int h = 4;

// bool menor = g < h;

// Console.WriteLine("G é menor que H? {0}", menor);

// int i = 5;
// int j = 4;

// bool diferente = i != j;

// Console.WriteLine("I é diferente de J? {0}", diferente);

//Operadores Lógicos

// bool emailValido =  false;
// bool senhaValida = true;

// bool acessoPermitido = emailValido && senhaValida;

// Console.WriteLine("Acesso permitido? {0}", acessoPermitido);

// bool emailValido2 =  false;
// bool senhaValida2=  true;

// bool acessoPermitido2 = emailValido2 || senhaValida2;

// Console.WriteLine("Acesso permitido? {0}", acessoPermitido2);

// bool emailValido3 =  false;
// bool senhaValida3=  true;

// bool acessoPermitido3 = !emailValido3 && senhaValida3;

// Console.WriteLine("Acesso permitido? {0}", acessoPermitido3);


//Estruturas de Controle IF

// int idade = 7;
// bool permissaoPais = true;

// if(idade==0){
//     Console.WriteLine("Idade inválida!");
// }
// else if(idade>=18){
//     Console.WriteLine("Acesso permitido!");
// }
// else{
//     if(permissaoPais){
//         Console.WriteLine("Acesso permitido com permissão dos pais.");
//     }
//     else{
//         Console.WriteLine("Acesso negado! É necessário ter permissão dos pais");
//     }
// }


//Estrutura de Controle Switch

Console.WriteLine("Digite um número de 1 a 7 para representar um dia da semana:");
string input = Console.ReadLine();

switch (input)
{
    case "1":
        Console.WriteLine("Domingo");
        break;
    case "2":
        Console.WriteLine("Segunda-feira");
        break;
    case "3":
        Console.WriteLine("Terça-feira");
        break;
    case "4":
        Console.WriteLine("Quarta-feira");
        break;
    case "5":
        Console.WriteLine("Quinta-feira");
        break;
    case "6":
        Console.WriteLine("Sexta-feira");
        break;
    case "7":
        Console.WriteLine("Sábado");
        break;
    default:
        Console.WriteLine("Número inválido! Por favor, digite um número de 1 a 7.");
        break;
}


