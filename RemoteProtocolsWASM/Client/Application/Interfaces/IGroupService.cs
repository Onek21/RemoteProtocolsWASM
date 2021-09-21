using RemoteProtocolsWASM.Shared.ViewModels.GroupVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Client.Application.Interfaces
{
    public interface IGroupService
    {
        Task CreateCar(NewGroupVm model);
        Task DeactivateGroup(NewGroupVm model);
        Task EditGroup(NewGroupVm model);
        Task<IEnumerable<GroupListVm>> GetActiveGroups();
        Task<NewGroupVm> GetGroupDetail(int id);
    }
}
