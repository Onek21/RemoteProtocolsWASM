using RemoteProtocolsWASM.Domain.Interface;
using RemoteProtocolsWASM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Infrastructure.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly Context _context;
        public LocationRepository(Context context)
        {
            _context = context;
        }

        public int CreateLocation(Location locaiton)
        {
            var existingLocation = _context.Locations.Count(x => x.Code.Equals(locaiton.Code));
            if(existingLocation == 0)
            { 
                _context.Locations.Add(locaiton);
                _context.SaveChanges();
                return locaiton.LocationId;
            }
            return 0;
        }

        public IQueryable<Location> GetLocations()
        {
            var locations = _context.Locations;
            return locations;
        }

        public Location GetLocationById(int id)
        {
            var location = _context.Locations.FirstOrDefault(x => x.LocationId == id);
            return location;
        }

        public void UpdateLocation(Location location)
        {
            _context.Attach(location);
            _context.Entry(location).Property("Code").IsModified = true;
            _context.Entry(location).Property("Name").IsModified = true;
            _context.Entry(location).Property("Address").IsModified = true;
            _context.Entry(location).Property("Email").IsModified = true;
            _context.SaveChanges();
        }

        public void DeactivateLocation(Location location)
        {
            _context.Attach(location);
            _context.Entry(location).Property("IsActive").IsModified = true;
            _context.SaveChanges();
        }
    }
}
