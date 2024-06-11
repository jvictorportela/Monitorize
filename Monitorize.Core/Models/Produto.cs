using Monitorize.Core.Enums;

namespace Monitorize.Core.Models;

public class Produto
{
    public long Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public long CategoriaId { get; set; } // Chave estrangeira para Categoria
    public Categoria? Categoria { get; set; }
    public string? Descricao { get; set; }
    public DateTime DataCompra { get; set; } = DateTime.Now;
    public DateTime? DataVenda { get; set; }
    public decimal ValorCompra { get; set; }
    public decimal? ValorAtualDeMercado { get; set; }
    public EStatus Status { get; set; } = EStatus.Ativo;
}
