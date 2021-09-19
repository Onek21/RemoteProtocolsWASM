using RemoteProtocolsWASM.Client.Application.Interfaces;
using RemoteProtocolsWASM.Shared.ViewModels.EventVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Client.Application.Services
{
    public class EventService : IEventService
    {
        private readonly HttpClient _httpClient;
        public EventService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<EventListVm>> GetActiveEvents()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EventListVm>>("api/Event/GetActiveEvents");
        }

        public async Task CreateEvent(NewEventVm model)
        {
            await _httpClient.PostAsJsonAsync<NewEventVm>("api/Event/CreateEvent", model);
        }

        public async Task<NewEventVm> GetEventDetail(int id)
        {
            return await _httpClient.GetFromJsonAsync<NewEventVm>($"api/Event/EventDetail/{id}");
        }

        public async Task EditEvent(NewEventVm model)
        {
            await _httpClient.PutAsJsonAsync<NewEventVm>($"api/Event/UpdateEvent/{model.EventId}", model);
        }

        public async Task DeactivateEvent(NewEventVm model)
        {
            await _httpClient.PutAsJsonAsync<NewEventVm>($"api/Event/DeactivateEvent/{model.EventId}", model);
        }
    }
}
