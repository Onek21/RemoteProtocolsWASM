using RemoteProtocolsWASM.Shared.ViewModels.UserVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Client.Application.Interfaces
{
    public interface IUserService
    {
        Task ChangeUserRole(EditUserVm editUser);
        Task CreateRole(NewRoleVm newRole);
        Task CreateUser(NewUserVm newUser);
        Task DeleteRole(string id);
        Task EditUser(EditUserVm editUser);
        Task<IEnumerable<RoleListVm>> GetRoles();
        Task<EditUserVm> GetUserById(string id);
        Task<ResetPasswordVm> GetUserByIdToResetPassword(string id);
        Task<IEnumerable<UserListVm>> GetUsers();
        Task ResetPassword(ResetPasswordVm resetPasswordVm);
    }
}
