using RemoteProtocolsWASM.Shared.ViewModels.CarVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Application.Interfaces
{
    public interface ICarService
    {
        int CreateCar(NewCarVm model);
    }
}
