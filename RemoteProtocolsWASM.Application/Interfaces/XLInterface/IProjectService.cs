using RemoteProtocolsWASM.Shared.ViewModels.XLViewModels.ProjectVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Application.Interfaces.XLInterface
{
    public interface IProjectService
    {
        void CreateProject(NewProjectVm projectVm);
        void DeactivateProject(NewProjectVm projectVm);
        List<ProjectListVm> GetActiveProjects();
        NewProjectVm GetProjectById(int id);
        void UpdateProject(NewProjectVm projectVm);
    }
}
