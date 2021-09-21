using AutoMapper;
using RemoteProtocolsWASM.Domain.Model;
using RemoteProtocolsWASM.Shared.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Shared.ViewModels.GroupVm
{
    public class NewGroupVm : IMapFrom<Group>
    {
        public int GroupId { get; set; }
        [Required(ErrorMessage ="Pole Kod jest wymagane")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Pole Nazwa jest wymagane")]
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewGroupVm, Group>().ReverseMap();
        }
    }
}
