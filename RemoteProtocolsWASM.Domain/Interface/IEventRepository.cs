using RemoteProtocolsWASM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Domain.Interface
{
    public interface IEventRepository
    {
        int CreateEvent(Event model);
        void DeactivateEvent(Event model);
        Event GetEventById(int id);
        IQueryable<Event> GetEvents();
        void UpdateEvent(Event model);
    }
}
