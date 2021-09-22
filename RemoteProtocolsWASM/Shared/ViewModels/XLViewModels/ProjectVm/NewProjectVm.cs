using AutoMapper;
using RemoteProtocolsWASM.Domain.Model.XLModel;
using RemoteProtocolsWASM.Shared.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Shared.ViewModels.XLViewModels.ProjectVm
{
    public class NewProjectVm : IMapFrom<Project>
    {
        public int ProjectId { get; set; }
        [Required(ErrorMessage ="Kod projektu musi być uzupełniony")]
        public string ProjectCode { get; set; }
        [Required(ErrorMessage = "Nazwa projektu musi być uzupełniona")]
        public string ProjectName { get; set; }
        public string IsActive { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewProjectVm, Project>().ReverseMap();
        }
    }
}
