using Microsoft.EntityFrameworkCore;
using RemoteProtocolsWASM.Domain.Interface;
using RemoteProtocolsWASM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Infrastructure.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly Context _context;
        public EventRepository(Context context)
        {
            _context = context;
        }

        public int CreateEvent(Event model)
        {
            _context.Events.Add(model);
            _context.SaveChanges();
            return model.EventId;
        }

        public IQueryable<Event> GetEvents()
        {
            var events = _context.Events;
            return events;
        }

        public Event GetEventById(int id)
        {
            var model = _context.Events.FirstOrDefault(x => x.EventId == id);
            return model;
        }

        public void UpdateEvent(Event model)
        {
            _context.Attach(model);
            _context.Entry(model).Property("Code").IsModified = true;
            _context.Entry(model).Property("Name").IsModified = true;
            _context.SaveChanges();
        }

        public void DeactivateEvent(Event model)
        {
            _context.Attach(model);
            _context.Entry(model).Property("IsActive").IsModified = true;
            _context.SaveChanges();
        }
    }
}
