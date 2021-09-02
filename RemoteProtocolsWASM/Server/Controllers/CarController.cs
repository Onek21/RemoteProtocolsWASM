using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RemoteProtocolsWASM.Application.Interfaces;
using RemoteProtocolsWASM.Shared.ViewModels.CarVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private static ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpPost("CreateCar")]
        public IActionResult CreateCar(NewCarVm model)
        {
            var id = _carService.CreateCar(model);

            if(id != 0)
            {
                return Ok();
            }
            return NotFound();

        }
    }
}
