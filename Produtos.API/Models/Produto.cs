using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Produtos.API.Models
{
    public class ProdutoModel
    {
        [Key]
        public int? ProdutoId { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public int Quantidade { get; set; }

        // Restante das propriedades...

        public ProdutoModel() { }

        public ProdutoModel(int? id, string nome, decimal preco, int quantidade)
        {
            ProdutoId = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}
