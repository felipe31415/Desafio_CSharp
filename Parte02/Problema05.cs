class Problema05{
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

    public static void gerarTabela(double ValorPresente, double Taxa, double Periodo){
        inicializacao(ValorPresente, Taxa);
        Console.WriteLine("Periodo Mes \t Valor Presente \t Taxa Juros \t Rendimento");
        for(int i = 0; i < Periodo; i++){
            rendimento *= (1+taxa);
            Console.WriteLine($"{periodo} \t\t {valorPresente.ToString("N2")} \t\t {taxa.ToString("N4")} \t {rendimento.ToString("N2")}");
            valorPresente = rendimento;
            periodo += 1;
            Math.Round(valorPresente, 2);
        }
    }
}