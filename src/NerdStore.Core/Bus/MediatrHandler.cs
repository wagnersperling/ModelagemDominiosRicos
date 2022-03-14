﻿using MediatR;
using NerdStore.Core.Bus;
using NerdStore.Core.Messages;
using System.Threading.Tasks;

namespace NerdStore.Core
{
    public class MediatrHandler : IMediatrHandler
    {
        private readonly IMediator _mediator;

        public MediatrHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task PublicarEvento<T>(T evento) where T : Event
        {
            await _mediator.Publish(evento);
        }
    }
}
