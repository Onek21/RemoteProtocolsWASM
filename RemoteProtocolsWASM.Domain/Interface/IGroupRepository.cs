using RemoteProtocolsWASM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Domain.Interface
{
    public interface IGroupRepository
    {
        int CreateGroup(Group model);
        void DeactivateGroup(Group model);
        Group GetGroupById(int id);
        IQueryable<Group> GetGroups();
        void UpdateGroup(Group model);
    }
}
