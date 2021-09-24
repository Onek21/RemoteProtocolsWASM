using RemoteProtocolsWASM.Client.Application.Interfaces;
using RemoteProtocolsWASM.Shared.ViewModels.UserVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Client.Application.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;
        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<UserListVm>> GetUsers()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<UserListVm>>("api/User/GetUsers");
        }
        public async Task CreateUser(NewUserVm newUser)
        {
            await _httpClient.PostAsJsonAsync<NewUserVm>("api/User/CreateUser", newUser);
        }
        public async Task<IEnumerable<RoleListVm>> GetRoles()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<RoleListVm>>("api/User/GetRoles");
        }
        public async Task CreateRole(NewRoleVm newRole)
        {
            await _httpClient.PostAsJsonAsync<NewRoleVm>("api/User/CreateRole", newRole);
        }
        public async Task DeleteRole(string id)
        {
            await _httpClient.PostAsync($"api/User/DeleteRole/{id}", null);
        }
        public async Task EditUser(EditUserVm editUser)
        {
            await _httpClient.PostAsJsonAsync<EditUserVm>("api/User/EditUser", editUser);
        }
        public async Task<EditUserVm> GetUserById(string id)
        {
            return await _httpClient.GetFromJsonAsync<EditUserVm>($"api/User/GetUserById/{id}");
        }
        public async Task ChangeUserRole(EditUserVm editUser)
        {
            await _httpClient.PostAsJsonAsync<EditUserVm>("api/User/ChangeUserRole", editUser);
        }
        public async Task<ResetPasswordVm> GetUserByIdToResetPassword(string id)
        {
            return await _httpClient.GetFromJsonAsync<ResetPasswordVm>($"api/User/GetUserByIdToResetPassword/{id}");
        }
        public async Task ResetPassword(ResetPasswordVm resetPasswordVm)
        {
            await _httpClient.PostAsJsonAsync<ResetPasswordVm>("api/User/ResetPassword", resetPasswordVm);
        }
    }
}
