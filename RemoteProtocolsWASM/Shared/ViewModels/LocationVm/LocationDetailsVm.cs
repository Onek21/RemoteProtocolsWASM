using AutoMapper;
using RemoteProtocolsWASM.Domain.Model;
using RemoteProtocolsWASM.Shared.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Shared.ViewModels.LocationVm
{
    public class LocationDetailsVm : IMapFrom<Location>
    {
        public int LocationId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Location, LocationDetailsVm>();
        }
    }
}
