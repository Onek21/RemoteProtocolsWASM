using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RemoteProtocolsWASM.Application.Interfaces;
using RemoteProtocolsWASM.Shared.ViewModels.UserVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("GetUsers")]
        public ActionResult<IEnumerable<UserListVm>> GetUsers()
        {
            var users = _userService.GetUsers();
            return users;
        }
        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser(NewUserVm newUser)
        {
            var result = await _userService.AddUser(newUser);
            return Ok(result);
        }
        [HttpGet("GetRoles")]
        public ActionResult<IEnumerable<RoleListVm>> GetRoles()
        {
            var roles = _userService.GetRoles();
            return roles;
        }
        [HttpPost("CreateRole")]
        public async Task<IActionResult> CreateRole(NewRoleVm newRole)
        {
            var result = await _userService.AddRole(newRole);
            return Ok(result);
        }
        [HttpPost("DeleteRole/{id}")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var result = await _userService.DeleteRole(id);
            return Ok(result);
        }
        [HttpPost("EditUser")]
        public async Task<IActionResult> EditUser(EditUserVm newUser)
        {
            var result = await _userService.EditUser(newUser);
            return Ok(result);
        }
        [HttpGet("GetUserById/{id}")]
        public ActionResult<EditUserVm> GetUserById(string id)
        {
            var user = _userService.GetUserById(id);
            return user;
        }
        [HttpPost("ChangeUserRole")]
        public async Task<IActionResult> ChangeUserRole(EditUserVm newUser)
        {
            var result = await _userService.ChangeUserRoles(newUser.Id, newUser.UserRoles);
            return Ok(result);
        }

        [HttpGet("GetUserByIdToResetPassword/{id}")]
        public ActionResult<ResetPasswordVm> GetUserByIdToResetPassword(string id)
        {
            var user = _userService.GetUserByIdToResetPassword(id);
            return user;
        }
        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordVm resetPassword)
        {
            var result = await _userService.ResetPasword(resetPassword);
            return Ok(result);
        }
    }
}
