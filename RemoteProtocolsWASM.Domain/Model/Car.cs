using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Domain.Model
{
    public class Car
    {
        public int CarId { get; set; }
        public string RegistrationNumber { get; set; }
        public string Model { get; set; }
        public ICollection<Protocol> Protocols { get; set; }
        public ICollection<AspNetUsersInfo> AspNetUsersInfos { get; set; }
    }
}
