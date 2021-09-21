using RemoteProtocolsWASM.Client.Application.Interfaces;
using RemoteProtocolsWASM.Shared.ViewModels.LocationVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Client.Application.Services
{
    public class LocationService : ILocationService
    {
        private readonly HttpClient _httpClient;
        public LocationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<LocationListVm>> GetActiveLocations()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<LocationListVm>>("api/Location/GetActiveLocations");
        }

        public async Task<int> CreateLocation(NewLocationVm newLocation)
        {
            var response = await _httpClient.PostAsJsonAsync<NewLocationVm>("api/Location/CreateLocation", newLocation);
            int value = await response.Content.ReadFromJsonAsync<int>();
            return value;
        }
        public async Task<NewLocationVm> GetLocationDetails(int id)
        {
            return await _httpClient.GetFromJsonAsync<NewLocationVm>($"api/Location/LocationDetails/{id}");
        }

        public async Task EditLocation(NewLocationVm model)
        {
            await _httpClient.PutAsJsonAsync<NewLocationVm>($"api/Location/UpdateLocation/{model.LocationId}", model);
        }

        public async Task DeactivateLocation(NewLocationVm model)
        {
            await _httpClient.PutAsJsonAsync<NewLocationVm>($"api/Location/DeactivateLocation/{model.LocationId}", model);
        }
    }
}
