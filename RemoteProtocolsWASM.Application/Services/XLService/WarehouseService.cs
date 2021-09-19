using AutoMapper;
using AutoMapper.QueryableExtensions;
using RemoteProtocolsWASM.Application.Interfaces.XLInterface;
using RemoteProtocolsWASM.Domain.Interface.XLInterface;
using RemoteProtocolsWASM.Shared.ViewModels.XLViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Application.Services.XLService
{
    public class WarehouseService : IWarehouseService
    {
        private readonly IWarehouseRepository _warehouseRepo;
        private readonly IMapper _mapper;

        public WarehouseService(IWarehouseRepository warehouseRepository, IMapper mapper)
        {
            _warehouseRepo = warehouseRepository;
            _mapper = mapper;
        }

        public List<WarehouseListVm> GetWarehouseItecomList()
        {
            var warehouses = _warehouseRepo.GetWarehouses().Where(x=> (x.Name.StartsWith("Tech") && !x.Name.EndsWith("Dino")) || x.Name == "Serwis").ProjectTo<WarehouseListVm>(_mapper.ConfigurationProvider).ToList();
            return warehouses;
        }

        public List<WarehouseListVm> GetWarehouseDinoList()
        {
            var warehouses = _warehouseRepo.GetWarehouses().Where(x => x.Name.StartsWith("Tech") && x.Name.EndsWith("DINO")).ProjectTo<WarehouseListVm>(_mapper.ConfigurationProvider).ToList();
            return warehouses;
        }

        public List<WarehouseListVm> GetAllWarehouseList()
        {
            var warehouses = _warehouseRepo.GetWarehouses().Where(x => x.Name.StartsWith("Tech") || x.Name == "Serwis").ProjectTo<WarehouseListVm>(_mapper.ConfigurationProvider).ToList();
            return warehouses;
        }

    }
}
