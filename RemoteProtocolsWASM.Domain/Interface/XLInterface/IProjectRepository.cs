using RemoteProtocolsWASM.Domain.Model.XLModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Domain.Interface.XLInterface
{
    public interface IProjectRepository
    {
        void CreateProject(Project project);
        void DeactivateProject(Project project);
        IQueryable<Project> GetProjects();
        void UpdateProject(Project project);
    }
}
