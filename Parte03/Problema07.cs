class Problema07{
    private static double valorPresente;
    private static double taxa;
    private static int periodo;
    private static double rendimento;
    private static double[] resgate = new double[30];

    private static void inicializacao(double ValorPresente, double Taxa){
        periodo = 1;
        valorPresente = ValorPresente;
        taxa = Taxa;
        rendimento = ValorPresente;
    }

    public static void gerarTabelaComResgate(double ValorPresente, double Taxa, int Periodo, double periodoFinal){
        inicializacao(ValorPresente, Taxa);
        int mesResg = 0;
				for(int i = 0; i < resgate.Length; i++){
            resgate[i] = 0;
        }
        while(true){
            Console.WriteLine("Digite o número do mês que deseja por um resgate (digite 0 caso não queira): ");
            try
            {
                mesResg = Convert.ToInt32(Console.ReadLine());
            }
            catch{
                Console.WriteLine("O valor inserido é inválido! Tente novamente: ");
                continue;
            }
            if(mesResg == 0){
                break;
            }
            if(mesResg < 0){
                Console.WriteLine("O valor não deve ser negativo.");
                continue;
            }
            if(mesResg > Periodo)
            {
                Console.WriteLine("O mês não está inserido dentro do período.");
                continue;
            }
            Console.WriteLine("Digite o valor que se deseja resgatar (usando vírgula): ");
            try
            {
                resgate[mesResg - 1] = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            }
            catch
            {
                Console.WriteLine("O valor inserido é inválido! ");
            }
            if(resgate[mesResg - 1] < 0)
            {
                Console.WriteLine("O valor não deve ser negativo.");
            }
        }
        Console.WriteLine("Posição \t Periodo Mes \t Valor Investido \t Taxa Juros \t Rendimento \tResgate");

        for(int i = 0; i < Periodo; i++){
            rendimento *= (1+taxa);
            if(resgate[i] >= rendimento){
                resgate[i] = rendimento;
            }
            rendimento -= resgate[i];
            Console.WriteLine($"{i+1} \t\t {periodo} \t\t  {valorPresente.ToString("N2")} \t\t {taxa.ToString("00.00%")} \t   {rendimento.ToString("N2")} \t {resgate[i].ToString("N2")}");
            periodo += 1;
        }

        if(periodoFinal != 0){
            rendimento *= Math.Pow(1+taxa, periodoFinal);
            if(resgate[Periodo] >= rendimento){
                resgate[Periodo] = rendimento;
            }
            rendimento -= resgate[Periodo];
            Console.WriteLine($"{Periodo+1} \t\t {(periodoFinal+Periodo).ToString("N2")} \t\t  {valorPresente.ToString("N2")} \t\t {taxa.ToString("00.00%")} \t   {rendimento.ToString("N2")} \t {resgate[Periodo].ToString("N2")}");
            periodo += 1;
        }
        
        Console.WriteLine($"O valor final é R${rendimento.ToString("N2")} e o resgate total foi de R${resgate.Sum().ToString("N2")}.");
    }
}