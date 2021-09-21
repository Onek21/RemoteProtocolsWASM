using RemoteProtocolsWASM.Shared.ViewModels.GroupVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Application.Interfaces
{
    public interface IGroupService
    {
        int CreateGroup(NewGroupVm model);
        void DeactiveGroup(NewGroupVm model);
        List<GroupListVm> GetActiveGroups();
        NewGroupVm GroupDetails(int id);
        void UpdateGroup(NewGroupVm model);
    }
}
