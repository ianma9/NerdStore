﻿using System;
using MediatR;
using NerdStore.Core.Messages;

namespace NerdStore.Vendas.Application.Commands
{
    public class FinalizarPedidoCommand : Command, IRequest<Unit>
    {
        public Guid PedidoId { get; private set; }
        public Guid ClienteId { get; private set; }

        public FinalizarPedidoCommand(Guid pedidoId, Guid clienteId)
        {
            AggregateId = pedidoId;
            PedidoId = pedidoId;
            ClienteId = clienteId;
        }
    }
}