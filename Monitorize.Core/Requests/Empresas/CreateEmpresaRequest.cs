using System.ComponentModel.DataAnnotations;

namespace Monitorize.Core.Requests.Empresas;

public class CreateEmpresaRequest : Request
{
    [Required(ErrorMessage = "O campo Nome é obrigatório")]
    [MaxLength(25, ErrorMessage = "O tamanho do campo Nome não pode exceder 25 caracteres")]
    public string Nome { get; set; } = string.Empty;
}
