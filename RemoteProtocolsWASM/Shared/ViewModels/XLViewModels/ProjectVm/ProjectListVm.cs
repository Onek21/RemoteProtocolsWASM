using AutoMapper;
using RemoteProtocolsWASM.Domain.Model.XLModel;
using RemoteProtocolsWASM.Shared.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Shared.ViewModels.XLViewModels.ProjectVm
{
    public class ProjectListVm : IMapFrom<Project>
    {
        public int ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectFullName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Project, ProjectListVm>()
                .ForMember(src => src.ProjectFullName, opt => opt.MapFrom(src => src.ProjectCode + " " + src.ProjectName));
        }
    }
}
