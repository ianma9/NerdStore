using System;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NerdStore.Core.Communication.Mediator;
using NerdStore.Core.Messages.CommonMessages.Notifications;

namespace NerdStore.WebApps.MVC.Controllers
{
    public abstract class ControllerBase : Controller
    {
        protected ControllerBase(DomainNotificationHandler notifications, IMediatrHandler mediatrHandler)
        {
            _notifications = notifications;
            _mediatrHandler = mediatrHandler;
        }

        private readonly DomainNotificationHandler _notifications;
        private readonly IMediatrHandler _mediatrHandler;
        protected Guid ClienteId = Guid.Parse("46020924-8503-4520-bed6-2b7efefd2dbc");

        protected ControllerBase(INotificationHandler<DomainNotification> notifications, IMediatrHandler mediatrHandler)
        {
            _notifications = (DomainNotificationHandler) notifications;
            _mediatrHandler = mediatrHandler;
        }

        protected bool OperacaoValida()
        {
            return !_notifications.TemNotificacao();
        }

        protected IEnumerable<string> ObterMensagemErro()
        {
            return _notifications.ObterNotificacoes().Select(c => c.Value).ToList();
        }

        protected void NotificarErro(string codigo, string message)
        {
            _mediatrHandler.PublicarNotificacao(new DomainNotification(codigo, message));
        }
    }
}