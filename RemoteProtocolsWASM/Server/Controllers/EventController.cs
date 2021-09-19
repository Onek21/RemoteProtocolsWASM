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
        public IActionResult CreateCar(NewEventVm model)
        {
            var id = _eventService.CreateEvent(model);

            if (id != 0)
            {
                return Ok();
            }
            return NotFound();

        }

        [HttpGet("GetActiveEvents")]
        public ActionResult<IEnumerable<EventListVm>> GetActiveCars()
        {
            var events = _eventService.GetActiveEvents();
           
            
                return Ok(events);
            
        }

        [HttpPut("UpdateEvent/{id}")]
        public IActionResult EditCar(NewEventVm model)
        {
            if (ModelState.IsValid)
            {
                _eventService.UpdateEvent(model);
                return NoContent();
            }
            return NotFound();
        }

        [HttpGet("EventDetail/{id}")]
        public ActionResult<EventDetailVm> CarDetails(int id)
        {
            var eventModel = _eventService.EventDetails(id);
            return Ok(eventModel);
        }

        [HttpPut("DeactivateEvent/{id}")]
        public IActionResult DeactivateCar(NewEventVm model)
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
