using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Identity;
using RemoteProtocolsWASM.Application.Interfaces;
using RemoteProtocolsWASM.Domain.Model;
using RemoteProtocolsWASM.Shared.ViewModels.UserVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Application.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;

        public UserService(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }
        public List<UserListVm> GetUsers()
        {
            var users = _userManager.Users.ProjectTo<UserListVm>(_mapper.ConfigurationProvider).ToList();
            foreach(var user in users)
            {
                user.Name = GetClaimsByUser(user.Id).FirstOrDefault(x => x.Type == ClaimTypes.Name).Value;
                user.Roles = GetRolesByUser(user.Id).DefaultIfEmpty("").First();
                if (user.LockoutEnd == DateTimeOffset.MaxValue)
                    user.IsLockout = true;
                else
                    user.IsLockout = false;
            }
            return users;
        }

        private IQueryable<Claim> GetClaimsByUser(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            var claims = _userManager.GetClaimsAsync(user).Result.AsQueryable();
            return claims;
        }
        private IQueryable<string> GetRolesByUser(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            var roles = _userManager.GetRolesAsync(user).Result.AsQueryable();
            return roles;
        }

        public async Task<IdentityResult> AddUser(NewUserVm newUserVm)
        {
            var user = _mapper.Map<User>(newUserVm);
            var result = await _userManager.CreateAsync(user, newUserVm.Password);
            if (result.Succeeded)
            {
                if (newUserVm.Name != null)
                    await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Name, newUserVm.Name));
            }
            return result;
        }

        public List<RoleListVm> GetRoles()
        {
            var roles = _roleManager.Roles.ProjectTo<RoleListVm>(_mapper.ConfigurationProvider).ToList();
            return roles;
        }

        public async Task<IdentityResult> AddRole(NewRoleVm newRoleVm)
        {
            var role = _mapper.Map<IdentityRole>(newRoleVm);
            var result = await _roleManager.CreateAsync(role);
            return result;
        }
        private IdentityRole GetRoleById(string id)
        {
            var role = _roleManager.FindByIdAsync(id).Result;
            return role;
        }

        public async Task<IdentityResult> DeleteRole(string id)
        {
            var role = GetRoleById(id);
            var result = await _roleManager.DeleteAsync(role);
            return result;
        }

        private void CheckChangesInUserToEdit(User currentUser, EditUserVm userToEdit)
        {
            if (currentUser.Email != userToEdit.Email)
            {
                currentUser.Email = userToEdit.Email;
            }
            if (userToEdit.IsLockout == true)
            {
                currentUser.LockoutEnd = DateTimeOffset.MaxValue;
            }
            else
            {
                currentUser.LockoutEnd = null;
            }
        }
        public async Task<IdentityResult> EditUser(EditUserVm userToEdit)
        {
            var currentUser = await _userManager.FindByIdAsync(userToEdit.Id);
            CheckChangesInUserToEdit(currentUser, userToEdit);
            var claim = _userManager.GetClaimsAsync(currentUser).Result.FirstOrDefault();
            var result = await _userManager.UpdateAsync(currentUser);
            if (result.Succeeded)
            { 
                await _userManager.RemoveClaimAsync(currentUser, claim);
                await _userManager.AddClaimAsync(currentUser, new Claim(ClaimTypes.Name, userToEdit.Name));
            }
            return result;
        }

        public EditUserVm GetUserById(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            var userVm = _mapper.Map<EditUserVm>(user);
            if (userVm.LockoutEnd == DateTimeOffset.MaxValue)
                userVm.IsLockout = true;
            else
                userVm.IsLockout = false;
            userVm.Name = GetClaimsByUser(user.Id).FirstOrDefault(x => x.Type == ClaimTypes.Name).Value;
            userVm.UserRoles = GetRolesByUser(user.Id).ToList();
            userVm.Roles = GetRoles();
            return userVm;
        }

        private async Task<IdentityResult> AddRolesToUser(User user, List<string> roles)
        {
            if (roles != null)
            {
                var result = await _userManager.AddToRolesAsync(user, roles);
                return result;
            }
            return new IdentityResult();
        }

        private async Task RemoveRolesFromUser(User user)
        {
            var roles = await _userManager.GetRolesAsync(user);
            if (roles.Count > 0)
            {
                await _userManager.RemoveFromRolesAsync(user, roles);
            }
        }

        public async Task<IdentityResult> ChangeUserRoles(string id, IEnumerable<string> roles)
        {
            var user = await _userManager.FindByIdAsync(id);
            await RemoveRolesFromUser(user);
            var roleList = roles.ToList();
            var result = await AddRolesToUser(user, roleList);
            return result;
        }

        public ResetPasswordVm GetUserByIdToResetPassword(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            var userVm = _mapper.Map<ResetPasswordVm>(user);
            return userVm;
        }
        public async Task<IdentityResult> ResetPasword(ResetPasswordVm newUser)
        {
            var user = await _userManager.FindByIdAsync(newUser.Id);
            await _userManager.RemovePasswordAsync(user);
            return await _userManager.AddPasswordAsync(user, newUser.Password);
        }
    }
}
