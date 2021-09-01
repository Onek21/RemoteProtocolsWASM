using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Domain.Model
{
    public class AspNetUsersInfo
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Warehouse { get; set; }
        public string WarehouseDino { get; set; }
        public string ManagerId { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

        public virtual User User { get; set; }
        public virtual User Manager { get; set; }

    }
}
