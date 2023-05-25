// See https://aka.ms/new-console-template for more information

// Problema 01

// double valor = 1000;
// double taxa = 0.053;
// int periodo = 6;
// Problema01 tabela = new Problema01();
// tabela.Calcular(valor, taxa, periodo);

//Problema 02

// double valor = 3800;
// double taxa = 0.0125;
// int periodo = 6;
// Problema02 tabela = new Problema02();
// tabela.Calcular(valor, taxa, periodo);

//Problema 03

// Console.WriteLine("Por favor, digite o valor (R$): ");
// double valor = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
// Console.WriteLine("Agora, por favor, digite a taxa (em decimal e com vírgula): ");
// double taxa = Convert.ToDouble(Console.ReadLine());
// taxa /= 100;
// Console.WriteLine("Finalmente, digite o período, tal qual a base de tempo coincida com a base de tempo da taxa: ");
// int periodo = Convert.ToInt32(Console.ReadLine());
// Problema03 tabela = new Problema03();
// tabela.Calcular(valor, taxa, periodo);

//Problema 04

// Console.WriteLine("Por favor, digite o valor (R$): ");
// double valor = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
// Console.WriteLine("Digite o valor da taxa (em porcentagem): ");
// double taxa = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
// Console.WriteLine("Digite a base de tempo da taxa: \'m\' para meses e \'a\' para anos: ");
// char aTaxa = Convert.ToChar(Console.ReadLine());
// taxa /= 100;
// Console.WriteLine("Digite o valor do periodo:");
// int periodo = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Digite a base de tempo do periodo: \'m\' para meses e \'a\' para anos:");
// char aPeriodo = Convert.ToChar(Console.ReadLine());
// if(aTaxa != aPeriodo){
//     if(aTaxa == 'm'){
//         periodo *= 12;
//     } else{
//         taxa = Math.Pow(1 + taxa, 1.0/12.0) - 1;
//     }
// }

// Problema04 relatorio = new Problema04();
// relatorio.Calcular(valor, taxa, periodo);

//Problema 05

// Console.WriteLine("Deseja descobrir o valor de: \n 1. Valor Presente\n 2. Taxa\n 3. Periodo");
// int op = Convert.ToInt32(Console.ReadLine());
// double valor = 0, taxa = 0;
// double periodo = 0;

// Console.WriteLine("Digite o valor final: ");
// double valorFinal = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
// if(op != 1){
//     Console.WriteLine("Digite o valor presente: ");
//     valor = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
// }
// if(op != 2){
//     Console.WriteLine("Digite o valor da taxa (em porcentagem): ");
//     taxa = Convert.ToDouble(Console.ReadLine().Replace(".", ",").Replace("%", ""));
//     taxa /= 100;
// }
// if(op != 3){
//     Console.WriteLine("Digite o valor do periodo: ");
//     periodo = Convert.ToDouble(Console.ReadLine());
// }
// if(op == 1){
//     valor = valorFinal/Math.Pow((1+taxa), periodo);
//     Console.WriteLine($"O valor presente equivale a {valor.ToString("0.00R$")}.");
// }
// if(op == 2){
//     taxa = Math.Pow((valorFinal/valor), 1/periodo) - 1;
//     Console.WriteLine($"O valor da taxa equivale a {taxa.ToString("0.00%")}.");
// }
// if(op == 3){
//     periodo = Math.Log(valorFinal/valor, 1 + taxa);
//     Console.WriteLine($"O período se compreende a {periodo.ToString("0.")}.");
// }
// Problema05.gerarTabela(valor, taxa, periodo);