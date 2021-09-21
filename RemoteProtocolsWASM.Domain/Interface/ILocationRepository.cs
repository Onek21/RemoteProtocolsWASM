using RemoteProtocolsWASM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Domain.Interface
{
    public interface ILocationRepository
    {
        int CreateLocation(Location locaiton);
        void DeactivateLocation(Location location);
        Location GetLocationById(int id);
        IQueryable<Location> GetLocations();
        void UpdateLocation(Location location);
    }
}
