using AutoMapper;
using AutoMapper.QueryableExtensions;
using RemoteProtocolsWASM.Application.Interfaces.XLInterface;
using RemoteProtocolsWASM.Domain.Interface.XLInterface;
using RemoteProtocolsWASM.Domain.Model.XLModel;
using RemoteProtocolsWASM.Shared.ViewModels.XLViewModels.ProjectVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Application.Services.XLService
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepo;
        private readonly IMapper _mapper;
        public ProjectService(IProjectRepository projectRepository, IMapper mapper)
        {
            _projectRepo = projectRepository;
            _mapper = mapper;
        }
         
        public List<ProjectListVm> GetActiveProjects()
        {
            var projects = _projectRepo.GetProjects().Where(x => x.IsActive.Equals("1")).ProjectTo<ProjectListVm>(_mapper.ConfigurationProvider).ToList();
            return projects;
        }

        public NewProjectVm GetProjectById(int id)
        {
            var project = _projectRepo.GetProjects().FirstOrDefault(x => x.ProjectId == id);
            var projectVm = _mapper.Map<NewProjectVm>(project);
            return projectVm;
        }

        public void CreateProject(NewProjectVm projectVm)
        {
            projectVm.IsActive = "1";
            var project = _mapper.Map<Project>(projectVm);
            _projectRepo.CreateProject(project);
        }

        public void UpdateProject(NewProjectVm projectVm)
        {
            var project = _mapper.Map<Project>(projectVm);
            _projectRepo.UpdateProject(project);
        }

        public void DeactivateProject(NewProjectVm projectVm)
        {
            projectVm.IsActive = "2";
            var project = _mapper.Map<Project>(projectVm);
            _projectRepo.DeactivateProject(project);
        }
    }
}
