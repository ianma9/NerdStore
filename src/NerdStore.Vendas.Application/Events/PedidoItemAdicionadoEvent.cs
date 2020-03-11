using System;
using NerdStore.Core.Messages;

namespace NerdStore.Vendas.Application.Events
{
    public class PedidoItemAdicionadoEvent : Event
    {
        

        public Guid ClienteId { get; private set; }
        public Guid PedidoId { get; private set; }
        public Guid ProdutoId { get; private set; }
        public string ProdutoNome { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public int Quantidade { get; private set; }

        public PedidoItemAdicionadoEvent(Guid clienteId, Guid pedidoId)
        {
            AggregateId = pedidoId;
            ClienteId = clienteId;
            PedidoId = pedidoId;
        }

        public PedidoItemAdicionadoEvent(Guid clienteId, Guid pedidoId, Guid produtoId, string produtoNome, decimal valorUnitario, int quantidade)
        {
            AggregateId = pedidoId;
            ClienteId = clienteId;
            PedidoId = pedidoId;
            ProdutoNome = produtoNome;
            ProdutoId = produtoId;
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
        }
    }
}