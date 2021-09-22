using Microsoft.AspNetCore.Authorization;
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
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpPost("CreateCar")]
        public IActionResult CreateCar(NewCarVm model)
        {
            var id = _carService.CreateCar(model);

            if (id != 0)
            {
                return Ok();
            }
            return NotFound();

        }
        [HttpGet("GetActiveCars")]
        public ActionResult<IEnumerable<CarListVm>> GetActiveCars()
        {
            var cars = _carService.GetActiveCars();
            return Ok(cars);
        }
        [HttpPut("UpdateCar/{id}")]
        public IActionResult EditCar(NewCarVm carVm)
        {
            if (ModelState.IsValid)
            {
                _carService.UpdateCar(carVm);
                return NoContent();
            }
            return NotFound();
        }
        [HttpGet("CarDetail/{id}")]
        public ActionResult<CarDetailVm> CarDetails(int id)
        {
            var car = _carService.CarDetails(id);
            return Ok(car);
        }
        [HttpPut("DeactivateCar/{id}")]
        public IActionResult DeactivateCar(NewCarVm carVm)
        {
            if(ModelState.IsValid)
            {
                _carService.DeactivateCar(carVm);
                return NoContent();
            }
            return NotFound();
        }
         
    }
}
