using RemoteProtocolsWASM.Shared.ViewModels.EventVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Client.Application.Interfaces
{
    public interface IEventService
    {
        Task CreateEvent(NewEventVm model);
        Task DeactivateEvent(NewEventVm model);
        Task EditEvent(NewEventVm model);
        Task<IEnumerable<EventListVm>> GetActiveEvents();
        Task<NewEventVm> GetEventDetail(int id);
    }
}
