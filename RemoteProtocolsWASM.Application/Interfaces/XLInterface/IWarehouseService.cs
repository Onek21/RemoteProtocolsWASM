using RemoteProtocolsWASM.Shared.ViewModels.XLViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Application.Interfaces.XLInterface
{
    public interface IWarehouseService
    {
        List<WarehouseListVm> GetAllWarehouseList();
        List<WarehouseListVm> GetWarehouseDinoList();
        List<WarehouseListVm> GetWarehouseItecomList();
    }
}
