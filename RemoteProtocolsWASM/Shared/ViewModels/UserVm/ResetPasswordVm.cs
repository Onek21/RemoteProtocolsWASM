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
    public class ResetPasswordVm : IMapFrom<User>
    {
        public string Id { get; set; }
        [DisplayName("Nazwa użytkownika")]
        [Required(ErrorMessage = "Nazwa użytkownika nie może być pusta")]
        public string UserName { get; set; }
        [DisplayName("Hasło")]
        [Required(ErrorMessage = "Hasło nie może być puste")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Potwierdź hasło")]
        [Required(ErrorMessage = "Potwierdź hasło nie może być puste")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = ("Hasła muszą być zgodne"))]
        public string ConfirmPassword { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ResetPasswordVm, User>()
                .ReverseMap();
        }
    }
}
