using Microsoft.EntityFrameworkCore;
using RemoteProtocolsWASM.Domain.Interface.XLInterface;
using RemoteProtocolsWASM.Domain.Model.XLModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Infrastructure.Repositories.XLRepositories
{
    public class WarehouseRepository : IWarehouseRepository
    {
        private readonly XLContext _xLContext;

        public WarehouseRepository(XLContext xLContext)
        {
            _xLContext = xLContext;
        }

        public IQueryable<Warehouse> GetWarehouses()
        {
            var warehouses = _xLContext.Warehouses.FromSqlRaw("select MAG_GIDNumer as [Id], MAG_Kod as [Name] from cdn.Magazyny");
            return warehouses;
        }
    }
}
