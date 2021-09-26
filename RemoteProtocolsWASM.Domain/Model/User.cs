using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Domain.Model
{
    public class User : IdentityUser
    {
        public string Warehouse { get; set; }
        public string WarehouseDino { get; set; }
        public string ManagerId { get; set; }
        public virtual User Manager { get; set; }
        public virtual ICollection<User> ManagersCollection { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<Protocol> ProtocolsManagers { get; set; }
        public virtual ICollection<Protocol> ProtocolsTechnicans { get; set; }
        public virtual ICollection<Protocol> ProtocolsAccounting { get; set; }

    }
}
