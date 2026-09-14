using System.Runtime.CompilerServices;

public class Estoque
{
    private List<Produto> Produtos = new List<Produto>();
    public void AdicionarNovoProduto(Produto Produto)
    {
        Produtos.Add(Produto);
    }
    public void ExibirProdutosDoEstoque()
    {
        System.Console.WriteLine("Lista de produtos do Estoque: \n");
        foreach(var produto in Produtos)
        {
            System.Console.WriteLine($"Produto: {produto.Nome}");
        }
    }
}