using AutoMapper;
using Microsoft.AspNetCore.Identity;
using RemoteProtocolsWASM.Shared.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Shared.ViewModels.UserVm
{
    public class RoleListVm : IMapFrom<IdentityRole>
    {
        public string Id { get; set; }
        [DisplayName("Nazwa")]
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<IdentityRole, RoleListVm>();
        }
    }
}
