using AutoMapper;
using AutoMapper.QueryableExtensions;
using RemoteProtocolsWASM.Application.Interfaces;
using RemoteProtocolsWASM.Domain.Interface;
using RemoteProtocolsWASM.Domain.Model;
using RemoteProtocolsWASM.Shared.ViewModels.EventVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Application.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepo;
        private readonly IMapper _mapper;
        public EventService(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepo = eventRepository;
            _mapper = mapper;
        }

        public int CreateEvent(NewEventVm model)
        {
            model.IsActive = true;
            var eventModel = _mapper.Map<Event>(model);
            var id = _eventRepo.CreateEvent(eventModel);
            return id;
        }

        public List<EventListVm> GetActiveEvents()
        {
            var events = _eventRepo.GetEvents().Where(x => x.IsActive == true).ProjectTo<EventListVm>(_mapper.ConfigurationProvider).ToList();
            return events;
        }

        public void UpdateEvent(NewEventVm model)
        {
            var eventModel = _mapper.Map<Event>(model);
            _eventRepo.UpdateEvent(eventModel);
        }

        public NewEventVm EventDetails(int id)
        {
            var eventModel = _eventRepo.GetEventById(id);
            var eventVm = _mapper.Map<NewEventVm>(eventModel);
            return eventVm;
        }

        public void DeactivateEvent(NewEventVm model)
        {
            model.IsActive = false;
            var eventModel = _mapper.Map<Event>(model);
            _eventRepo.DeactivateEvent(eventModel);
        }
    }
}
