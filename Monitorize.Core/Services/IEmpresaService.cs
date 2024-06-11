using Monitorize.Core.Models;
using Monitorize.Core.Requests.Empresas;
using Monitorize.Core.Responses;

namespace Monitorize.Core.Services;

public interface IEmpresaService
{
    Task<Response<Empresa?>> CreateAsync(CreateEmpresaRequest request);

    Task<Response<Empresa?>> UpdateAsync(UpdateEmpresaRequest request);

    Task<Response<Empresa?>> DeleteAsync(DeleteEmpresaRequest request);

    Task<Response<Empresa?>> GetByIdAsync(GetEmpresaByIdRequest request);

    Task<PagedResponse<List<Empresa>?>> GetAllAsync(GetAllEmpresasRequest request);
}
