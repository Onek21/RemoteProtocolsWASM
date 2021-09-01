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
        public virtual ICollection<Protocol> ProtocolsManagers { get; set; }
        public virtual ICollection<Protocol> ProtocolsTechnicans { get; set; }
        public virtual ICollection<Protocol> ProtocolsAccounting { get; set; }
        public virtual ICollection<AspNetUsersInfo> Users { get; set; }
        public virtual ICollection<AspNetUsersInfo> UserManagers { get; set; }
    }
}
