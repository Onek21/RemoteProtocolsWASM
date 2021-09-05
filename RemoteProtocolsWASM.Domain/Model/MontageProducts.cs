using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Domain.Model
{
    public class MontageProducts
    {
        public int MontageProductsId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int MontageStageId { get; set; }
        public bool IsActive { get; set; }
        public virtual MontageStage MontageStage { get; set; }
    }
}
