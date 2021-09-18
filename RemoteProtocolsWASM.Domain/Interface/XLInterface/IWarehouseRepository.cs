using RemoteProtocolsWASM.Domain.Model.XLModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Domain.Interface.XLInterface
{
    public interface IWarehouseRepository
    {
        IQueryable<Warehouse> GetWarehouses();
    }
}
