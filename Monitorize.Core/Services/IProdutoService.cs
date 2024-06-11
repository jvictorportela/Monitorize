using Monitorize.Core.Models;
using Monitorize.Core.Requests.Produtos;
using Monitorize.Core.Responses;

namespace Monitorize.Core.Services;

public interface IProdutoService
{
    Task<Response<Produto?>> CreateAsync(CreateProdutoRequest request);

    Task<Response<Produto?>> UpdateAsync(UpdateProdutoRequest request);

    Task<Response<Produto?>> DeleteAsync(DeleteProdutoRequest request);

    Task<Response<Produto?>> GetByIdAsync(GetProdutoByIdRequest request);

    Task<PagedResponse<List<Produto>?>> GetAllAsync(GetAllProdutosRequest request);
}
