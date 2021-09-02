using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Domain.Model
{
    public class MontageStage
    {
        public int MontageStageId { get; set; }
        public string Name { get; set; }
        public bool IsActivce { get; set; }
        public ICollection<MontageProducts> MontageProducts { get; set; }
    }
}
