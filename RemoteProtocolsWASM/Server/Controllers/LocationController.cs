using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RemoteProtocolsWASM.Application.Interfaces;
using RemoteProtocolsWASM.Shared.ViewModels.LocationVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;
        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpPost("CreateLocation")]
        public IActionResult CreateLocation(NewLocationVm locationVm)
        {
            var id = _locationService.CreateLocation(locationVm);
            return Ok(id);
        }

        [HttpGet("GetActiveLocations")]
        public ActionResult<IEnumerable<LocationListVm>> GetActiveLocations()
        {
            var locations = _locationService.GetActiveLocations();
            return Ok(locations);
        }

        [HttpGet("LocationDetails/{id}")]
        public ActionResult<NewLocationVm> LocationDetails(int id)
        {
            var location = _locationService.GetLocationDetails(id);
            return Ok(location);
        }

        [HttpPut("UpdateLocation/{id}")]
        public IActionResult UpdateLocation(NewLocationVm newLocation)
        {
            if(ModelState.IsValid)
            {
                _locationService.UpdateLocation(newLocation);
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut("DeactivateLocation/{id}")]
        public IActionResult DeactivateLocation(NewLocationVm newLocation)
        {
            if (ModelState.IsValid)
            {
                _locationService.DeactivateLocation(newLocation);
                return NoContent();
            }
            return NotFound();
        }

    }
}
