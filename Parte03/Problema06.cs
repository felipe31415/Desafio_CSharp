class Problema06{
    private static double valorPresente;
    private static double taxa;
    private static int periodo;
    private static double rendimento;

    private static void inicializacao(double ValorPresente, double Taxa){
        periodo = 1;
        valorPresente = ValorPresente;
        taxa = Taxa;
        rendimento = ValorPresente;
    }

    public static void gerarTabela(double ValorPresente, double Taxa, int Periodo, double periodoFinal){
        inicializacao(ValorPresente, Taxa);
        Console.WriteLine("Posição \t Periodo Mes \t Valor Investido \t Taxa Juros \t Rendimento");

        for(int i = 0; i < Periodo; i++){
            rendimento *= (1+taxa);
            Console.WriteLine($"{i+1} \t\t {periodo} \t\t  {valorPresente.ToString("N2")} \t\t {taxa.ToString(" 0.00%")} \t   {rendimento.ToString("N2")}");
            periodo += 1;
        }
        rendimento *= Math.Pow(1+taxa, periodoFinal);
        Console.WriteLine($"{Periodo+1} \t\t {(periodoFinal+Periodo).ToString("N2")} \t\t  {valorPresente.ToString("N2")} \t\t {taxa.ToString(" 0.00%")} \t   {rendimento.ToString("N2")}");
        periodo += 1;
        
        Console.WriteLine($"O valor final é R${rendimento.ToString("N2")}.");
    }
}