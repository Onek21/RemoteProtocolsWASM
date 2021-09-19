using AutoMapper;
using RemoteProtocolsWASM.Domain.Model;
using RemoteProtocolsWASM.Shared.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Shared.ViewModels.EventVm
{
    public class NewEventVm : IMapFrom<Event>
    {
        public int EventId { get; set; }
        [Required(ErrorMessage ="Pole Kod nie może być puste")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Pole Nazwa nie może być puste")]
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewEventVm, Event>()
                .ReverseMap();
        }
    }
}
