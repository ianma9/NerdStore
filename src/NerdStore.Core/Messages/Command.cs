using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using MediatR;
using FluentValidation.Results;

namespace NerdStore.Core.Messages
{
    public abstract class Command : Message, IRequest<bool>
    {
        public DateTime TimeStamp { get; private set; }
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            TimeStamp = DateTime.Now;
        }
        public virtual bool EhValido()
        {
            throw  new NotImplementedException();
        }
    }
}