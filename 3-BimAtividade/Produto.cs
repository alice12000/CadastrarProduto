
public class Produto
{


    public string  Codigo { get; set; }

    public string Descricao { get; set; }

    public double Compra { get; set; }

    public double Venda { get; set; }

    public double ValorFinal { get; set; }


    public Produto()
    {

    }

    //construtor vazio:
    public Produto(string codigo, string descricao, double compra, double venda, double valorFinal)
    {
        this.Codigo = codigo;
        this.Descricao = descricao;
        this.Compra = compra;
        this.Venda = venda;
        this.ValorFinal = valorFinal;    
    }
}