using AutoMapper;
using Microsoft.AspNetCore.Identity;
using RemoteProtocolsWASM.Shared.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Shared.ViewModels.UserVm
{
    public class NewRoleVm : IMapFrom<IdentityRole>
    {
        public string Id { get; set; }
        [DisplayName("Nazwa")]
        [Required(ErrorMessage = "Pole nazwa nie może być puste")]
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewRoleVm, IdentityRole>().ReverseMap();
        }
    }
}
