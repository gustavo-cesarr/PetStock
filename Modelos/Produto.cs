public class Produto
{
    public string Nome { get; set; }
    public string Marca { get; set; }
    private double _preco;
    public double Preco { get => _preco;
    set
        {
            if (value <= 0)
            {
                System.Console.WriteLine("Não podemos ter preço nulo ou negativo.");
            }
            else
            {
                _preco = value;
            }
        } 
    }

    private int _quantidade;
    public int Quantidade { get => _quantidade;
    set
        {
            if (value < 0)
            {
                System.Console.WriteLine("Não podemos ter estoque negativo.");
            }
            else
            {
                _quantidade = value;
            }
        }
    }
    public string DescricaoDetalhada => $"O {Nome} é da marca {Marca}, custa um valor R$ {Preco} e temos {Quantidade} quantidades no estoque.";

    public static Produto CriarProduto(){
        System.Console.WriteLine("Digite o nome do novo produto: ");
        string nomeDoProduto = Console.ReadLine()!;
        System.Console.WriteLine("Digite a marca do novo produto: ");
        string marcaDoProduto = Console.ReadLine()!;
        System.Console.WriteLine("Digite o preço do novo produto: ");
        double precoDoProduto = double.Parse(Console.ReadLine()!);
        Produto produto = new Produto();
        produto.Nome = nomeDoProduto;
        produto.Marca = marcaDoProduto;
        produto.Preco = precoDoProduto;
        return produto;
    }
}
