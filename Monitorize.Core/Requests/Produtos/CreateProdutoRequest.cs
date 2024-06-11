using Monitorize.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace Monitorize.Core.Requests.Produtos;

public class CreateProdutoRequest : Request
{
    [Required(ErrorMessage = "O campo Nome é obrigatório")]
    [MaxLength(25, ErrorMessage = "O tamanho do campo Nome não pode exceder 25 caracteres")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O campo Categoria é obrigatório")]
    public int CategoriaId { get; set; } // Chave estrangeira para Categoria
    public Categoria? Categoria { get; set; }

    [MaxLength(350, ErrorMessage = "O tamanho do campo Descricao não pode exceder 350 caracteres")]
    public string Descricao { get; set; } = string.Empty;

    public DateTime DataCompra { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "O campo ValorCompra é obrigatório")]
    public decimal ValorCompra { get; set; }

    public decimal? ValorAtualDeMercado { get; set; }
}
