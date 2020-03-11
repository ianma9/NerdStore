using System;
using System.Threading.Tasks;
using NerdStore.Core.DomainObjects.DTO;

namespace NerdStore.Catalogo.Domain.Services.Interfaces
{
    public interface IEstoqueService : IDisposable
    {
        Task<bool> DebitarEstoque(Guid produtoId, int quantidade);
        Task<bool> DebitarListaProdutosPedido(ListaProdutoPedido lista);
        Task<bool> ReporEstoque(Guid produtoId, int quantidade);
        Task<bool> ReporListaProdutosPedido(ListaProdutoPedido lista);
    }
}