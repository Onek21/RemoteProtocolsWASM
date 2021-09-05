using RemoteProtocolsWASM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Domain.Interface
{
    public interface ICarRepository
    {
        int CreateCar(Car car);
        void DeactivateCar(Car car);
        Car GetCarById(int id);
        IQueryable<Car> GetCars();
        void UpdateCar(Car car);
    }
}
