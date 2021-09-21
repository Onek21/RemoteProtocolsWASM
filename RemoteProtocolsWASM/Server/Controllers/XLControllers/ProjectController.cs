using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RemoteProtocolsWASM.Application.Interfaces.XLInterface;
using RemoteProtocolsWASM.Shared.ViewModels.XLViewModels.ProjectVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Server.Controllers.XLControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet("GetActiveProjects")]
        public ActionResult<IEnumerable<ProjectListVm>> GetActiveProjects()
        {
            var project = _projectService.GetActiveProjects();
            return Ok(project);
        }

        [HttpPost("CreateProject")]
        public IActionResult CreateProject(NewProjectVm newProject)
        {
            _projectService.CreateProject(newProject);
            return Ok();
        }

        [HttpGet("GetProjectById/{id}")]
        public ActionResult<NewProjectVm> GetProjectById(int id)
        {
            var project = _projectService.GetProjectById(id);
            return project;
        }
        [HttpPut("UpdateProject/{id}")]
        public IActionResult UpdateProject(NewProjectVm newProject)
        {
            if(ModelState.IsValid)
            {
                _projectService.UpdateProject(newProject);
                return NoContent();
            }
            return NotFound();
        }

        [HttpPut("DeactivateProject/{id}")]
        public IActionResult DeactivateProject(NewProjectVm newProject)
        {
            if (ModelState.IsValid)
            {
                _projectService.DeactivateProject(newProject);
                return NoContent();
            }
            return NotFound();
        }
    }
}
