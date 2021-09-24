using AutoMapper;
using RemoteProtocolsWASM.Domain.Model;
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
    public class NewUserVm : IMapFrom<User>
    {
        public string Id { get; set; }
        [DisplayName("Nazwa użytkownika")]
        [Required(ErrorMessage = "Nazwa użytkownika nie może być pusta")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Email nie może być pusty")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [DisplayName("Hasło")]
        [Required(ErrorMessage ="Hasło nie może być puste")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Potwierdź hasło")]
        [Required(ErrorMessage ="Potwierdź hasło nie może być puste")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage =("Hasła muszą być zgodne"))]
        public string ConfirmPassword { get; set; }
        [DisplayName("Imię i nazwisko")]
        [Required(ErrorMessage = "Imię i nazwisko jest wymagane")]
        public string Name { get; set; }
        public List<string> UserRoles { get; set; }
        public List<RoleListVm> Roles { get; set; }
        public bool IsLockout { get; set; }
        public DateTimeOffset LockoutEnd { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewUserVm, User>()
                .ReverseMap();
        }
    }
}
