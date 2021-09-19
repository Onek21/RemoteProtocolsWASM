using AutoMapper;
using RemoteProtocolsWASM.Domain.Model;
using RemoteProtocolsWASM.Shared.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Shared.ViewModels.EventVm
{
    public class EventDetailVm : IMapFrom<Event>
    {
        public int EventId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Event, EventDetailVm>();
        }
    }
}
