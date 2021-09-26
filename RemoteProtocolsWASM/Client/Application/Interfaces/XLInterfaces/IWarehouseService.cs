using RemoteProtocolsWASM.Shared.ViewModels.XLViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Client.Application.Interfaces.XLInterfaces
{
    public interface IWarehouseService
    {
        Task<IEnumerable<WarehouseListVm>> GetAllWarehouses();
        Task<IEnumerable<WarehouseListVm>> GetDinoWarehouses();
        Task<IEnumerable<WarehouseListVm>> GetItecomWarehouses();
    }
}
