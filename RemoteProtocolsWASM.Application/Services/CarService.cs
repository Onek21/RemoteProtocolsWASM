using AutoMapper;
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
            model.IsActivce = true;
            var car = _mapper.Map<Car>(model);
            var id = _carRepo.CreateCar(car);
            return id;
        }
    }
}
