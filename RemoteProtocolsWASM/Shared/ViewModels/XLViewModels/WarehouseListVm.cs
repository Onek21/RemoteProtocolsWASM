using AutoMapper;
using RemoteProtocolsWASM.Domain.Model.XLModel;
using RemoteProtocolsWASM.Shared.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Shared.ViewModels.XLViewModels
{
    public class WarehouseListVm : IMapFrom<Warehouse>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Warehouse, WarehouseListVm>();
        }
    }
}
