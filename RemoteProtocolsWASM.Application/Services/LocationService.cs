using AutoMapper;
using AutoMapper.QueryableExtensions;
using RemoteProtocolsWASM.Application.Interfaces;
using RemoteProtocolsWASM.Domain.Interface;
using RemoteProtocolsWASM.Domain.Model;
using RemoteProtocolsWASM.Shared.ViewModels.LocationVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Application.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepo;
        private readonly IMapper _mapper;
        public LocationService(ILocationRepository locationRepository, IMapper mapper)
        {
            _locationRepo = locationRepository;
            _mapper = mapper;
        }

        public int CreateLocation(NewLocationVm model)
        {
            model.IsActive = true;
            var location = _mapper.Map<Location>(model);
            var id = _locationRepo.CreateLocation(location);
            return id;
        }

        public List<LocationListVm> GetActiveLocations()
        {
            var locations = _locationRepo.GetLocations().Where(x => x.IsActive == true).ProjectTo<LocationListVm>(_mapper.ConfigurationProvider).ToList();
            return locations;
        }

        public NewLocationVm GetLocationDetails(int id)
        {
            var location = _locationRepo.GetLocationById(id);
            var locationVm = _mapper.Map<NewLocationVm>(location);
            return locationVm;
        }

        public void UpdateLocation(NewLocationVm locationVm)
        {
            var location = _mapper.Map<Location>(locationVm);
            _locationRepo.UpdateLocation(location);
        }
        public void DeactivateLocation(NewLocationVm locationVm)
        {
            locationVm.IsActive = false;
            var location = _mapper.Map<Location>(locationVm);
            _locationRepo.DeactivateLocation(location);
        }
    }
}
