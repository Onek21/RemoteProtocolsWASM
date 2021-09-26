using RemoteProtocolsWASM.Client.Application.Interfaces.XLInterfaces;
using RemoteProtocolsWASM.Shared.ViewModels.XLViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Client.Application.Services.XLServices
{
    public class WarehouseService : IWarehouseService
    {
        private readonly HttpClient _httpClient;
        public WarehouseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<WarehouseListVm>> GetAllWarehouses()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<WarehouseListVm>>("api/Warehouse/GetAllWarehouse");
        }

        public async Task<IEnumerable<WarehouseListVm>> GetItecomWarehouses()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<WarehouseListVm>>("api/Warehouse/GetWarehouseItecom");
        }

        public async Task<IEnumerable<WarehouseListVm>> GetDinoWarehouses()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<WarehouseListVm>>("api/Warehouse/GetWarehouseDino");
        }
    }
}
