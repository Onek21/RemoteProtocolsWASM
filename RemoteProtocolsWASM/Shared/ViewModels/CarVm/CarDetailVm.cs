using AutoMapper;
using RemoteProtocolsWASM.Domain.Model;
using RemoteProtocolsWASM.Shared.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Shared.ViewModels.CarVm
{
    public class CarDetailVm : IMapFrom<Car>
    {
        public int CarId { get; set; }
        public string RegistrationNumber { get; set; }
        public string Model { get; set; }
        public bool IsActive { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Car, CarDetailVm>();
        }
    }
}
