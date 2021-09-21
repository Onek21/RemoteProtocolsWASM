using RemoteProtocolsWASM.Shared.ViewModels.LocationVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Application.Interfaces
{
    public interface ILocationService
    {
        int CreateLocation(NewLocationVm model);
        void DeactivateLocation(NewLocationVm locationVm);
        List<LocationListVm> GetActiveLocations();
        NewLocationVm GetLocationDetails(int id);
        void UpdateLocation(NewLocationVm locationVm);
    }
}
