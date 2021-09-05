using RemoteProtocolsWASM.Shared.ViewModels.CarVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Client.Application.Interfaces
{
    public interface ICarService
    {
        Task CreateCar(NewCarVm carVm);
        Task DeactivateCar(NewCarVm carVm);
        Task EditCar(NewCarVm carVm);
        Task<IEnumerable<CarListVm>> GetActiveCars();
        Task<NewCarVm> GetCarDetail(int id);
    }
}
