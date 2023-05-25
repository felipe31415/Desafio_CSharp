class Problema04{
    private double valorPresente;
    private double taxa;
    private int periodo;
    private double rendimento;
    private double valorTotal;
    private double rendimentoLiquido;
    private double rendaAcumulada;
    private double[] resgate = new double[20];

    public void Calcular(double valorPresente, double taxa, double periodo){
        this.periodo = 1;
        this.taxa = taxa;
        int mesResg;
        this.rendimento = valorPresente;
        this.rendaAcumulada = valorPresente;
        while(true){
            Console.WriteLine("Digite o núemro do mês que deseja por um resgate (digite 0 caso não queira): ");
            mesResg = Convert.ToInt32(Console.ReadLine());
            if(mesResg == 0){
                break;
            }
            Console.WriteLine("Digite o valor que se deseja resgatar (usando vírgula): ");
            resgate[mesResg - 1] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Periodo Mes \t Valor Presente \t Taxa Juros \t Rendimento \t Renda Liquida \tRenda Acumulada Resgate");
        for(int i = 0; i < periodo; i++){
            this.rendaAcumulada *= (1+this.taxa);
            this.rendimento *= (1+this.taxa);
            this.rendimentoLiquido = this.rendimento - valorPresente;
            Math.Round(this.rendimento, 2);
            Math.Round(this.rendimentoLiquido, 2);
            this.rendaAcumulada -= resgate[i];
            Console.WriteLine($"{this.periodo} \t\t {valorPresente.ToString("N2")} \t\t {this.taxa.ToString("N4")} \t {this.rendimento.ToString("  0.00")} \t {this.rendimentoLiquido.ToString("   0.00")} \t{this.rendaAcumulada.ToString("   0.00")} \t{resgate[i].ToString("N2")}");
            this.rendimento -= resgate[i];
            this.periodo += 1;
        }
        Console.WriteLine($"O valor final é {this.rendimento.ToString("N2")} e a renda líquida foi de {this.rendimentoLiquido.ToString("N2")}.");
    }
}