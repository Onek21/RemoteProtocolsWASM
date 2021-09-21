using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RemoteProtocolsWASM.Application.Interfaces;
using RemoteProtocolsWASM.Shared.ViewModels.EventVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;
        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }
        [HttpPost("CreateEvent")]
        public IActionResult CreateEvent(NewEventVm model)
        {
            var id = _eventService.CreateEvent(model);

            if (id != 0)
            {
                return Ok();
            }
            return NotFound();

        }

        [HttpGet("GetActiveEvents")]
        public ActionResult<IEnumerable<EventListVm>> GetActiveEvents()
        {
            var events = _eventService.GetActiveEvents();
           
            
                return Ok(events);
            
        }

        [HttpPut("UpdateEvent/{id}")]
        public IActionResult UpdateEvent(NewEventVm model)
        {
            if (ModelState.IsValid)
            {
                _eventService.UpdateEvent(model);
                return NoContent();
            }
            return NotFound();
        }

        [HttpGet("EventDetail/{id}")]
        public ActionResult<EventDetailVm> EventDetail(int id)
        {
            var eventModel = _eventService.EventDetails(id);
            return Ok(eventModel);
        }

        [HttpPut("DeactivateEvent/{id}")]
        public IActionResult DeactivateEvent(NewEventVm model)
        {
            if (ModelState.IsValid)
            {
                _eventService.DeactivateEvent(model);
                return NoContent();
            }
            return NotFound();
        }
    }
}
