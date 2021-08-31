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
        public virtual Protocol Protocol { get; set; }
        public virtual AspNetUsersInfo AspNetUsersInfo { get; set; }
    }
}
