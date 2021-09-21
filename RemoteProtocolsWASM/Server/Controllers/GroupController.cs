using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RemoteProtocolsWASM.Application.Interfaces;
using RemoteProtocolsWASM.Shared.ViewModels.GroupVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupService _groupService;
        public GroupController(IGroupService groupService)
        {
            _groupService = groupService;
        }

        [HttpPost("CreateGroup")]
        public IActionResult CreateGroup(NewGroupVm model)
        {
            var id = _groupService.CreateGroup(model);
            if(id != 0)
            {
                return Ok();
            }
            return NotFound();
        }

        [HttpGet("GetActiveGroups")]
        public ActionResult<IEnumerable<GroupListVm>> GetActiveGroups()
        {
            var groups = _groupService.GetActiveGroups();
            return Ok(groups);
        }

        [HttpGet("GroupDetails/{id}")]
        public ActionResult<GroupDetailVm> GroupDetals(int id)
        {
            var group = _groupService.GroupDetails(id);
            return Ok(group);
        }
        [HttpPut("UpdateGroup/{id}")]
        public IActionResult UpdateGroup(NewGroupVm model)
        {
            if(ModelState.IsValid)
            {
                _groupService.UpdateGroup(model);
                return NoContent();
            }
            return NotFound();
        }

        [HttpPut("DeactivateGroup/{id}")]
        public IActionResult DeactivateGroup(NewGroupVm model)
        {
            _groupService.DeactiveGroup(model);
            return NoContent();
        }

    }
}
