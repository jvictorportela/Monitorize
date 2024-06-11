namespace Monitorize.Core.Requests.Usuarios;

public class CreateUsuarioRequest : Request
{
    public string Login { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
}
