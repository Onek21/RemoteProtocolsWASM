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
        [DataType(DataType.EmailAddress, ErrorMessage =("Email musi być w odpowiednim formacie"))]
        [EmailAddress]
        public string Email { get; set; }
        [DisplayName("Hasło")]
        [Required(ErrorMessage ="Hasło nie może być puste")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^\da-zA-Z]).*$",
         ErrorMessage = "Hasło musi posiadać małą literę, dużą literę, liczbę oraz znak specjalny")]
        [StringLength(100, ErrorMessage =("Hasło musi posiadać minimum 6 znakow"),MinimumLength =6)]
        public string Password { get; set; }
        [DisplayName("Potwierdź hasło")]
        [Required(ErrorMessage ="Potwierdź hasło nie może być puste")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage =("Hasła muszą być zgodne"))]
        public string ConfirmPassword { get; set; }
        [DisplayName("Imię i nazwisko")]
        [Required(ErrorMessage = "Imię i nazwisko jest wymagane")]
        public string Name { get; set; }
        [DisplayName("Magazyn")]
        public string Warehouse { get; set; }
        [DisplayName("MagazynDino")]
        public string WarehouseDino { get; set; }
        [DisplayName("Samochód")]
        [RegularExpression(@"(.*[1-9].*)|(.*[.].*[1-9].*)",
         ErrorMessage = "Pole samochód jest wymagane")]
        public int CarId { get; set; }
        [DisplayName("Grupa")]
        [RegularExpression(@"(.*[1-9].*)|(.*[.].*[1-9].*)",
         ErrorMessage = "Pole grupa jest wymagane")]
        public int GroupId { get; set; }
        [DisplayName("Przełożony")]
        public string ManagerId { get; set; }
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
