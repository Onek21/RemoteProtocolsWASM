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
        NewCarVm CarDetails(int id);
        int CreateCar(NewCarVm model);
        void DeactivateCar(NewCarVm model);
        List<CarListVm> GetActiveCars();
        void UpdateCar(NewCarVm model);
    }
}
