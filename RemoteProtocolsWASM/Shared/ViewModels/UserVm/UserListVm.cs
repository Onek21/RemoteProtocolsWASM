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
        public bool IsLockout { get; set; }
        public DateTimeOffset LockoutEnd { get; set; }
        [DisplayName("Magazyn")]
        public string Warehouse { get; set; }
        [DisplayName("MagazynDino")]
        public string WarehouseDino { get; set; }
        [DisplayName("Samochód")]
        public string Car { get; set; }
        [DisplayName("Grupa")]
        public string Group { get; set; }
        public string ManagerId { get; set; }
        [DisplayName("Przełożony")]
        public string Manager { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<User, UserListVm>()
                .ForMember(src => src.Name, opt => opt.Ignore())
                .ForMember(src => src.Roles, opt => opt.Ignore())
                .ForMember(src => src.Car, opt => opt.MapFrom(dto => dto.Car.RegistrationNumber))
                .ForMember(src => src.Group, opt => opt.MapFrom(dto => dto.Group.Code))
                .ForMember(src => src.Manager, opt => opt.Ignore());
        }
    }
}
