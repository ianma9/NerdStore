using System;
using NerdStore.Core.DomainObjects.DTO;

namespace NerdStore.Core.Messages.CommonMessages.IntegrationEvents
{
    public class PedidoEstoqueConfirmadoEvent : IntegrationEvent
    {
        public Guid PedidoId { get; private set; }
        public Guid ClienteId { get; private set; }
        public decimal ValorTotal { get; private set; }
        public ListaProdutoPedido ProdutosPedido { get; private set; }
        public string NomeCartao { get; private set; }
        public string NumeroCartao { get; private set; }
        public string ExpiracaoCartao { get; private set; }
        public string CvvCartao { get; private set; }

        public PedidoEstoqueConfirmadoEvent(Guid pedidoId, Guid clienteId, decimal valorTotal, ListaProdutoPedido produtosPedido, string nomeCartao, string numeroCartao, string expiracaoCartao, string cvvCartao)
        {
            AggregateId = pedidoId;
            PedidoId = pedidoId;
            ClienteId = clienteId;
            ValorTotal = valorTotal;
            ProdutosPedido = produtosPedido;
            NomeCartao = nomeCartao;
            NumeroCartao = numeroCartao;
            ExpiracaoCartao = expiracaoCartao;
            CvvCartao = cvvCartao;
        }
    }
}