using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Domain.Model
{
    public class ProtocolNumeration
    {
        public int ProtocolNumerationId { get; set; }
        public int ProtocolNumber { get; set; }
        public int ProtocolMonth { get; set; }
        public int ProtocolYear { get; set; }
    }
}
