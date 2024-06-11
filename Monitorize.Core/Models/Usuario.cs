using Monitorize.Core.Enums;

namespace Monitorize.Core.Models;

public class Usuario
{
    public long Id { get; set; }
    public string Login { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public EStatus Status { get; set; } = EStatus.Ativo;
}
