using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Domain.Model
{
    public class Event
    {
        public int EventId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public ICollection<Protocol> Protocols { get; set; }
    }
}
