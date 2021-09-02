using RemoteProtocolsWASM.Domain.Interface;
using RemoteProtocolsWASM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Infrastructure.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly Context _context;

        public CarRepository(Context context)
        {
            _context = context;
        }

        public int CreateCar(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
            return car.CarId;
        }
    }
}
