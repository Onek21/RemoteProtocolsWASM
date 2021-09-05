using AutoMapper;
using AutoMapper.QueryableExtensions;
using RemoteProtocolsWASM.Application.Interfaces;
using RemoteProtocolsWASM.Domain.Interface;
using RemoteProtocolsWASM.Domain.Model;
using RemoteProtocolsWASM.Shared.ViewModels.CarVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Application.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepo;
        private readonly IMapper _mapper;

        public CarService(ICarRepository carRepository, IMapper mapper)
        {
            _carRepo = carRepository;
            _mapper = mapper;
        }
        public int CreateCar(NewCarVm model)
        {
            model.IsActive = true;
            var car = _mapper.Map<Car>(model);
            var id = _carRepo.CreateCar(car);
            return id;
        }

        public List<CarListVm> GetActiveCars()
        {
            var cars = _carRepo.GetCars().Where(x => x.IsActive == true).ProjectTo<CarListVm>(_mapper.ConfigurationProvider).ToList();
            return cars;
        }

        public void UpdateCar(NewCarVm model)
        {
            var car = _mapper.Map<Car>(model);
            _carRepo.UpdateCar(car);
        }

        public CarDetailVm CarDetails(int id)
        {
            var car = _carRepo.GetCarById(id);
            var carVm = _mapper.Map<CarDetailVm>(car);
            return carVm;
        }

        public void DeactivateCar(NewCarVm model)
        {
            model.IsActive = false;
            var car = _mapper.Map<Car>(model);
            _carRepo.DeactivateCar(car);
        }
    }
}
