using AutoMapper;
using RemoteProtocolsWASM.Domain.Model;
using RemoteProtocolsWASM.Shared.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Shared.ViewModels.UserVm
{
    public class UserListVm : IMapFrom<User>
    {
        public string Id { get; set; }
        [DisplayName("Nazwa użytkownika")]
        public string UserName { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Imię i nazwisko")]
        public string Name { get; set; }
        public string Roles { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<User, UserListVm>()
                .ForMember(src => src.Name, opt => opt.Ignore())
                .ForMember(src => src.Roles, opt => opt.Ignore());
        }
    }
}
