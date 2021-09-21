using RemoteProtocolsWASM.Shared.ViewModels.XLViewModels.ProjectVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Client.Application.Interfaces.XLInterfaces
{
    public interface IProjectService
    {
        Task CreateProject(NewProjectVm newProject);
        Task DeactivateCar(NewProjectVm newProject);
        Task EditProject(NewProjectVm newProject);
        Task<IEnumerable<ProjectListVm>> GetActiveProjects();
        Task<NewProjectVm> GetProjectDetails(int id);
    }
}
