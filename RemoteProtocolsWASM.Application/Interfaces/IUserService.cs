using Microsoft.AspNetCore.Identity;
using RemoteProtocolsWASM.Shared.ViewModels.UserVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Application.Interfaces
{
    public interface IUserService
    {
        Task<IdentityResult> AddRole(NewRoleVm newRoleVm);
        Task<IdentityResult> AddUser(NewUserVm newUserVm);
        Task<IdentityResult> ChangeUserRoles(string id, List<string> roles);
        Task<IdentityResult> DeleteRole(string id);
        Task<IdentityResult> EditUser(EditUserVm userToEdit);
        List<RoleListVm> GetRoles();
        EditUserVm GetUserById(string id);
        ResetPasswordVm GetUserByIdToResetPassword(string id);
        List<UserListVm> GetUsers();
        Task<IdentityResult> ResetPasword(ResetPasswordVm newUser);
    }
}
