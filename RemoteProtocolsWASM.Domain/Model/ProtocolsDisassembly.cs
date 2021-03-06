using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Domain.Model
{
    public class ProtocolsDisassembly
    {
        public int ProtocolDisassemblyId { get; set; }
        public int ProtocolId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string DPNumber { get; set; }
        public string SerialNumber { get; set; }
        public bool Used { get; set; }
        public virtual Protocol Protocol { get; set; }
    }
}
