public class Produto
{
    public Produto(string nome, string marca, double preco)
    {
        Nome = nome;
        Marca = marca;
        Preco = preco;
    }
    private string _nome = string.Empty;
    public string Nome { get => _nome;
        set
        {
            if(value == null)
            {
                throw new ArgumentException("Não podemos ter nome nulo.");
            }
            List<string> especiais = new List<string>{"@",".","!","_","-","?"};
            bool temEspecial = especiais.Any(e => value.Contains(e));
            if (value.All(char.IsDigit) || temEspecial == true)
            {
                throw new ArgumentException("Não podemos ter nome com dígitos ou caracteres especiais.");
            }       
        } 
    }
    public string Marca { get; set; } = string.Empty;
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

    public string DescricaoDetalhada => $"O {Nome} é da marca {Marca}, custa um valor R$ {Preco} e temos {Quantidade} quantidades no estoque.";

    public static Produto CriarProduto(){
        Console.Clear();
        Thread.Sleep(1200);
        System.Console.WriteLine("Área de criação do produto.");
        System.Console.WriteLine("Digite o nome do novo produto: ");
        string nomeDoProduto = Console.ReadLine()!;
        System.Console.WriteLine("Digite a marca do novo produto: ");
        string marcaDoProduto = Console.ReadLine()!;
        System.Console.WriteLine("Digite o preço do novo produto: ");
        double precoDoProduto = double.Parse(Console.ReadLine()!);
        Produto produto = new Produto(nomeDoProduto, marcaDoProduto, precoDoProduto);
        return produto;
    }
}
