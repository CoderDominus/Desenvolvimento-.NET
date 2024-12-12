
using System;

namespace GerenciadorEstoque;

class Program
{
    static void Main()
    {
        var estoque = new EstoqueVirtual();
        
        //Adicionando produtos ao estoque.
        estoque.AdicionarProduto(new Produto("Notebook", 15, 3500.00m, CategoriaProduto.Eletronicos, StatusProduto.Disponivel));
        estoque.AdicionarProduto(new Produto("Camiseta", 100, 45.50m, CategoriaProduto.Roupas, StatusProduto.Disponivel));
        estoque.AdicionarProduto(new Produto("Livro C# Avançado", 20, 89.90m, CategoriaProduto.Livros, StatusProduto.Disponivel));
        
        //Consultando um produto.
        var produto = estoque.ConsultarProduto("Notebook");
        if (produto != null)
        {
            Console.WriteLine($"\nProduto encontrado: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: R${produto.Preco:F2}");
            
        }
    }
}