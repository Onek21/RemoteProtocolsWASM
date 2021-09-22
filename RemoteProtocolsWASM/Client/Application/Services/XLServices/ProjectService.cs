using RemoteProtocolsWASM.Client.Application.Interfaces.XLInterfaces;
using RemoteProtocolsWASM.Shared.ViewModels.XLViewModels.ProjectVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Client.Application.Services.XLServices
{
    public class ProjectService : IProjectService
    {
        private readonly HttpClient _httpClient;
        public ProjectService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ProjectListVm>> GetActiveProjects()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<ProjectListVm>>("api/Project/GetActiveProjects");
        }

        public async Task CreateProject(NewProjectVm newProject)
        {
            await _httpClient.PostAsJsonAsync<NewProjectVm>("api/Project/CreateProject", newProject);
        }

        public async Task<NewProjectVm> GetProjectDetails(int id)
        {
            return await _httpClient.GetFromJsonAsync<NewProjectVm>($"api/Project/GetProjectById/{id}");
        }

        public async Task EditProject(NewProjectVm newProject)
        {
            await _httpClient.PutAsJsonAsync<NewProjectVm>($"api/Project/UpdateProject/{newProject.ProjectId}", newProject);
        }

        public async Task DeactivateProject(NewProjectVm newProject)
        {
            await _httpClient.PutAsJsonAsync<NewProjectVm>($"api/Project/DeactivateProject/{newProject.ProjectId}", newProject);
        }
    }
}
