class Problema08{
    private static double valorPresente;
    private static double taxa;
    private static int periodo;
    private static double rendimento;
    private static double[] resgate = new double[30];
    private static double rendimentoLiquido;

    private static void inicializacao(double ValorPresente, double Taxa){
        periodo = 1;
        valorPresente = ValorPresente;
        taxa = Taxa;
        rendimento = ValorPresente;
    }

    public static void gerarTabelaComResgate(double ValorPresente, double Taxa, int Periodo, double periodoA, double periodoB){
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
            if(mesResg > Periodo+2)
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
        Console.WriteLine("Posição \t Periodo Mes \t Valor Investido \t Taxa Juros \t Rendimento \tResgate \t Renda Líquida");
        
        rendimento = valorPresente*Math.Pow(1+taxa, periodoA);
        if(resgate[0] >= rendimento){
            resgate[0] = rendimento;
        }
        rendimento -= resgate[0];
        rendimentoLiquido = rendimento - valorPresente;
        Console.WriteLine($"{1} \t\t {periodoA.ToString("N2")} \t\t  {valorPresente.ToString("N2")} \t\t {taxa.ToString(" 0.00%")} \t   {rendimento.ToString("N2")} \t   {resgate[0].ToString("0.00")} \t   {rendimentoLiquido.ToString("N2")}");
        periodo += 1;

        for(int i = 1; i < Periodo; i++){
            rendimento *= (1+taxa);
            if(resgate[i] >= rendimento){
                resgate[i] = rendimento;
            }
            rendimento -= resgate[i];
            rendimentoLiquido = rendimento - valorPresente;
            Console.WriteLine($"{i+1} \t\t {periodo} \t\t  {valorPresente.ToString("N2")} \t\t {taxa.ToString(" 0.00%")} \t   {rendimento.ToString("N2")} \t   {resgate[i].ToString("0.00")} \t   {rendimentoLiquido.ToString("N2")}");
            periodo += 1;
        }
        if(periodoB != 0){
            rendimento *= Math.Pow(1+taxa, periodoB);
            if(resgate[Periodo] >= rendimento){
                resgate[Periodo] = rendimento;
            }
            rendimento -= resgate[Periodo];
            rendimentoLiquido = rendimento-valorPresente;
            Console.WriteLine($"{Periodo+1} \t\t {(periodoB+Periodo).ToString("N2")} \t\t  {valorPresente.ToString("N2")} \t\t {taxa.ToString(" 0.00%")} \t   {rendimento.ToString("N2")} \t   {resgate[Periodo].ToString("0.00")} \t   {rendimentoLiquido.ToString("N2")}");
            periodo += 1;
        }
        
        Console.WriteLine($"O valor final é R${rendimento.ToString("N2")} e o resgate total foi de R${resgate.Sum().ToString("N2")}.");
    }
}
