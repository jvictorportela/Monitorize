using System.ComponentModel.DataAnnotations;

namespace Monitorize.Core.Requests.Categorias;

public class CreateCategoryRequest : Request
{
    [Required(ErrorMessage = "O campo Nome é obrigatório")]
    [MaxLength(25, ErrorMessage = "O tamanho do campo Nome não pode exceder 25 caracteres")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "Descrição Inválida")]
    public string Descricao { get; set; } = string.Empty;
}
