class Problema02{
    private double valorPresente;
    private double taxa;
    private int periodo;
    private double rendimento;
    private double valorTotal;
    private double rendimentoLiquido;

    public void Calcular(double valorPresente, double taxa, int periodo){
        this.periodo = 1;
        this.valorPresente = valorPresente;
        this.taxa = taxa;
        Console.WriteLine("Periodo Mes \t Valor Presente \t Taxa Juros \t Rendimento \t Renda Liquida");
        for(int i = 0; i < periodo; i++){
            this.rendimento = valorPresente*(Math.Pow((this.taxa + 1), this.periodo));
            this.rendimentoLiquido = this.rendimento - valorPresente;
            Math.Round(this.rendimento, 2);
            Math.Round(this.rendimentoLiquido, 2);
            Console.WriteLine($"{this.periodo} \t\t {this.valorPresente.ToString("N2")} \t\t {this.taxa.ToString("N4")} \t {this.rendimento.ToString("N2")} \t {this.rendimentoLiquido.ToString("N2")}");
            this.valorPresente = this.rendimento;
            this.periodo += 1;
            Math.Round(this.valorPresente, 2);
        }
        Console.WriteLine($"O valor final é {this.rendimento.ToString("N2")} e a renda líquida foi de {this.rendimentoLiquido.ToString("N2")}.");
    }
}