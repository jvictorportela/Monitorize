using Monitorize.Core.Enums;

namespace Monitorize.Core.Models;

public class Categoria
{
    public long Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public EStatus Status { get; set; } = EStatus.Ativo;
}
