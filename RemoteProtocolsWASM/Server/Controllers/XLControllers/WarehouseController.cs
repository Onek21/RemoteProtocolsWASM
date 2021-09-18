using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RemoteProtocolsWASM.Application.Interfaces.XLInterface;
using RemoteProtocolsWASM.Shared.ViewModels.XLViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Server.Controllers.XLControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseService _warehouseService;

        public WarehouseController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

        [HttpGet("GetWarehouseItecom")]
        public ActionResult<IEnumerable<WarehouseListVm>> GetWarehouseItecom()
        {
            var warehouses = _warehouseService.GetWarehouseItecomList();
            if (warehouses.Count > 0)
            {
                return Ok(warehouses);
            }
            return NotFound();
        }
    }
}
