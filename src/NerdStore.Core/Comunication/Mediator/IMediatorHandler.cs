using NerdStore.Core.ComoonMessages.DomainEvents;
using NerdStore.Core.Messages;
using NerdStore.Core.Messages.ComoonMessages.Notifications;
using System.Threading.Tasks;

namespace NerdStore.Core.Comunication.Mediator
{
    public interface IMediatorHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
        Task<bool> EnviarComando<T>(T comando) where T : Command;
        Task PublicarNotificacao<T>(T notificacao) where T : DomainNotification;
        Task PublicarDomainEvent<T>(T evento) where T : DomainEvent;
    }
}
