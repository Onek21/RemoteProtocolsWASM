using RemoteProtocolsWASM.Client.Application.Interfaces;
using RemoteProtocolsWASM.Shared.ViewModels.CarVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Client.Application.Services
{
    public class CarService : ICarService
    {
        private readonly HttpClient _httpClient;
        public CarService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<CarListVm>> GetActiveCars()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<CarListVm>>("api/Car/GetActiveCars");
        }

        public async Task CreateCar(NewCarVm carVm)
        {
            await _httpClient.PostAsJsonAsync<NewCarVm>("api/Car/CreateCar", carVm);
        }

        public async Task <NewCarVm> GetCarDetail(int id)
        {
            return await _httpClient.GetFromJsonAsync<NewCarVm>($"api/Car/CarDetail/{id}");
        }

        public async Task EditCar(NewCarVm carVm)
        {
            await _httpClient.PutAsJsonAsync<NewCarVm>($"api/Car/UpdateCar/{carVm.CarId}", carVm);
        }

        public async Task DeactivateCar(NewCarVm carVm)
        {
            await _httpClient.PutAsJsonAsync<NewCarVm>($"api/Car/DeactivateCar/{carVm.CarId}", carVm);
        }
    }
}
