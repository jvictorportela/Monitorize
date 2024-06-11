using Monitorize.Core.Models;
using Monitorize.Core.Requests.Categorias;
using Monitorize.Core.Responses;

namespace Monitorize.Core.Services;

public interface ICategoriaService
{
    Task<Response<Categoria?>> CreateAsync(CreateCategoryRequest request);

    Task<Response<Categoria?>> UpdateAsync(UpdateCategoryRequest request);

    Task<Response<Categoria?>> DeleteAsync(DeleteCategoryRequest request);

    Task<Response<Categoria?>> GetByIdAsync(GetCategoryByIdRequest request);

    Task<PagedResponse<List<Categoria>?>> GetAllAsync(GetAllCategoriesRequest request);
}
