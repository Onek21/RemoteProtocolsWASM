using AutoMapper;
using RemoteProtocolsWASM.Domain.Model;
using RemoteProtocolsWASM.Shared.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Shared.ViewModels.LocationVm
{
    public class NewLocationVm : IMapFrom<Location>
    {
        public int LocationId { get; set; }
        [Required(ErrorMessage ="Pole Kod jest wymagane")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Pole Nazwa jest wymagane")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Pole Adres jest wymagane")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Pole Email jest wymagane")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="Email wpisano w błędnym formacie")]
        public string Email { get; set; }
        public bool IsActive { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewLocationVm, Location>().ReverseMap();
        }
    }
}
