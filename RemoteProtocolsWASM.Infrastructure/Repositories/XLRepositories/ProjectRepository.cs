using Microsoft.EntityFrameworkCore;
using RemoteProtocolsWASM.Domain.Interface.XLInterface;
using RemoteProtocolsWASM.Domain.Model.XLModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Infrastructure.Repositories.XLRepositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly XLContext _xlContext;
        public ProjectRepository(XLContext xLContext)
        {
            _xlContext = xLContext;
        }

        public IQueryable<Project> GetProjects()
        {
            var projects = _xlContext.Projects.FromSqlRaw("select Projekty_ID as 'ProjectId', Kod_projektu as 'ProjectCode', Nazwa_projektu as 'ProjectName', Aktywny as 'IsActive' from cdn.ITEProjekty ");
            return projects;
        }

        public void CreateProject(Project project)
        {
            _xlContext.Database.ExecuteSqlRaw($"Insert Into CDN.IteProjekty (Kod_Projektu, Nazwa_projektu, Aktywny) VALUES ({project.ProjectCode}, {project.ProjectName},{project.IsActive})");
        }

        public void UpdateProject(Project project)
        {
            _xlContext.Database.ExecuteSqlRaw($"Update Cdn.IteProjekty Set Kod_Projektu = {project.ProjectCode}, Nazwa_projektu = {project.ProjectName} Where Projekty_Id = {project.ProjectId}");
        }

        public void DeactivateProject(Project project)
        {
            _xlContext.Database.ExecuteSqlRaw($"Update Cdn.IteProjekty Set Aktywny = {project.IsActive} Where Projekty_Id = {project.ProjectId}");
        }
    }
}
