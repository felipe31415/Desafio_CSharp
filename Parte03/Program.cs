// See https://aka.ms/new-console-template for more information

//Problema 06

// int op;
// double valor = 5500, taxa = 0.0248;
// int periodo = 8;
// int diasUltimoMes = 10;
// double[] meses = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

// while(true)
// {
    
//     try
//     {
//         Console.WriteLine("Digite o mês que contém os 10 dias: ");
//         int numeroMes = Convert.ToInt32(Console.ReadLine());
//         numeroMes -= 1;
//         double periodoFinal = diasUltimoMes/(meses[numeroMes]);

//         Problema06.gerarTabela(valor, taxa, periodo, periodoFinal);

//         Console.WriteLine("Deseja gerar outro relatório: \n 1. Sim\n 2. Não");
//         op = Convert.ToInt32(Console.ReadLine());
//         if(op != 1){
//             break;
//         }
//     }
//     catch
//     {
//         Console.WriteLine("Os valores inseridos são inválidos! Tente Novamente: \n");
//     }
// }

//Problema 07

// int op;
// double valor = 5500, taxa = 0.0248;
// int periodo = 8;
// int diasUltimoMes = 10;
// double[] meses = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

// while(true)
// {
    
//     try
//     {
//         Console.WriteLine("Digite o mês que contém os 10 dias: ");
//         int numeroMes = Convert.ToInt32(Console.ReadLine());
//         numeroMes -= 1;
//         double periodoFinal = diasUltimoMes/(meses[numeroMes]);

//         Problema07.gerarTabelaComResgate(valor, taxa, periodo, periodoFinal);

//         Console.WriteLine("Deseja gerar outro relatório: \n 1. Sim\n 2. Não");
//         op = Convert.ToInt32(Console.ReadLine());
//         if(op != 1){
//             break;
//         }
//     }
//     catch
//     {
//         Console.WriteLine("Os valores inseridos são inválidos! Tente Novamente: \n");
//     }
// }

int op;
double valor = 0, taxa = 0, periodoA = 0, periodoB = 0;
int periodo = 0;
string dataInicio, dataFinal;
int ano, mes, dia, anoFinal, mesFinal, diaFinal;
char aTaxa;
double[] meses = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

while(true)
{
    
    Console.WriteLine("Por favor, digite o valor (R$): ");
    try
    {
        valor = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
        Console.WriteLine("Digite o valor da taxa (em porcentagem): ");
        taxa = Convert.ToDouble(Console.ReadLine().Replace(".", ",").Replace("%", ""));
        Console.WriteLine("Digite a base de tempo da taxa: \'m\' para meses e \'a\' para anos: ");
        taxa /= 100;
        aTaxa = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Digite a data de início (formato 00/00/0000): ");
        dataInicio = Console.ReadLine();
        ano = Convert.ToInt32(dataInicio.Substring(6, 4));
        mes = Convert.ToInt32(dataInicio.Substring(3, 2));
        dia = Convert.ToInt32(dataInicio.Substring(0, 2));

        Console.WriteLine("Digite a data de final (formato 00/00/0000): ");
        dataFinal = Console.ReadLine();
        anoFinal = Convert.ToInt32(dataFinal.Substring(6, 4));
        mesFinal = Convert.ToInt32(dataFinal.Substring(3, 2));
        diaFinal = Convert.ToInt32(dataFinal.Substring(0, 2));

        if(aTaxa == 'a'){
            taxa = Math.Pow(1 + taxa, 1.0/12.0) - 1;
        }

        periodoA = (meses[mes-1] - dia + 1)/meses[mes-1];
        periodoB = (diaFinal-1)/meses[mesFinal-1];
        periodo = calcularMes(anoFinal, mesFinal, ano, mes);

        Problema08.gerarTabelaComResgate(valor, taxa, periodo, periodoA, periodoB);

        Console.WriteLine("Deseja gerar outro relatório: \n 1. Sim\n 2. Não");
        op = Convert.ToInt32(Console.ReadLine());
        if(op != 1){
            break;
        }
    }
    catch
    {
        Console.WriteLine("Os valores inseridos são inválidos! Tente Novamente: \n");
    }
}

static int calcularMes(int anoFinal, int mesFinal, int ano, int mes){
    int resultado = 12*(anoFinal-1) + mesFinal - 12*(ano-1) - mes;
    return resultado;
}

Console.WriteLine("Processo Encerrado.");