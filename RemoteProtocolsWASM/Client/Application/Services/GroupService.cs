using RemoteProtocolsWASM.Client.Application.Interfaces;
using RemoteProtocolsWASM.Shared.ViewModels.GroupVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Client.Application.Services
{
    public class GroupService : IGroupService
    {
        private readonly HttpClient _httpClient;
        public GroupService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<GroupListVm>> GetActiveGroups()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GroupListVm>>("api/Group/GetActiveGroups");
        }

        public async Task CreateGroup(NewGroupVm model)
        {
            await _httpClient.PostAsJsonAsync<NewGroupVm>("api/Group/CreateGroup", model);
        }

        public async Task<NewGroupVm> GetGroupDetail(int id)
        {
            return await _httpClient.GetFromJsonAsync<NewGroupVm>($"api/Group/GroupDetails/{id}");
        }
        public async Task EditGroup(NewGroupVm model)
        {
            await _httpClient.PutAsJsonAsync<NewGroupVm>($"api/Group/UpdateGroup/{model.GroupId}", model);
        }
        public async Task DeactivateGroup(NewGroupVm model)
        {
            await _httpClient.PutAsJsonAsync<NewGroupVm>($"api/Group/DeactivateGroup/{model.GroupId}", model);
        }
    }
}
