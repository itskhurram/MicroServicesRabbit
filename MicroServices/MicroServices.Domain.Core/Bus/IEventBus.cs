using MicroServices.Domain.Core.Commands;
using MicroServices.Domain.Core.Events;

using System.Threading.Tasks;

namespace MicroServices.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T: Command;
        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
