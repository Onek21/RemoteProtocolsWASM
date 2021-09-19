using RemoteProtocolsWASM.Shared.ViewModels.EventVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Application.Interfaces
{
    public interface IEventService
    {
        int CreateEvent(NewEventVm model);
        void DeactivateEvent(NewEventVm model);
        NewEventVm EventDetails(int id);
        List<EventListVm> GetActiveEvents();
        void UpdateEvent(NewEventVm model);
    }
}
