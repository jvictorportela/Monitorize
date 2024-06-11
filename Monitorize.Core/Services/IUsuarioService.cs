using Monitorize.Core.Models;
using Monitorize.Core.Requests.Usuarios;
using Monitorize.Core.Responses;

namespace Monitorize.Core.Services;

public interface IUsuarioService
{
    Task<Response<Usuario?>> CreateAsync(CreateUsuarioRequest request);

    Task<Response<Usuario?>> UpdateAsync(UpdateUsuarioRequest request);

    Task<Response<Usuario?>> DeleteAsync(DeleteUsuarioRequest request);

    Task<Response<Usuario?>> GetByIdAsync(GetUsuarioByIdRequest request);

    Task<PagedResponse<List<Usuario>?>> GetAllAsync(GetAllUsuariosRequest request);
}
