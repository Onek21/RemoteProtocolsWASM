using RemoteProtocolsWASM.Shared.ViewModels.LocationVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Client.Application.Interfaces
{
    public interface ILocationService
    {
        Task<int> CreateLocation(NewLocationVm newLocation);
        Task DeactivateLocation(NewLocationVm model);
        Task EditLocation(NewLocationVm model);
        Task<IEnumerable<LocationListVm>> GetActiveLocations();
        Task<NewLocationVm> GetLocationDetails(int id);
    }
}
