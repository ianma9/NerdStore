using System;
using System.Collections.Generic;

namespace NerdStore.Core.DomainObjects.DTO
{
    public class ListaProdutoPedido
    {
        public Guid PedidoId { get; set; }
        public ICollection<Item> Items { get; set; }
    }

    public class Item
    {
        public Guid Id { get; set; }
        public int Quantidade { get; set; }
    }
}