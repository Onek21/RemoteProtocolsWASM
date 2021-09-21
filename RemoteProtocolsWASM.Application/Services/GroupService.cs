using AutoMapper;
using AutoMapper.QueryableExtensions;
using RemoteProtocolsWASM.Application.Interfaces;
using RemoteProtocolsWASM.Domain.Interface;
using RemoteProtocolsWASM.Domain.Model;
using RemoteProtocolsWASM.Shared.ViewModels.GroupVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Application.Services
{
    public class GroupService : IGroupService
    {
        private readonly IGroupRepository _groupRepo;
        private readonly IMapper _mapper;

        public GroupService(IGroupRepository groupRepository, IMapper mapper)
        {
            _groupRepo = groupRepository;
            _mapper = mapper;
        }

        public int CreateGroup(NewGroupVm model)
        {
            model.IsActive = true ;
            var group = _mapper.Map<Group>(model);
            var id = _groupRepo.CreateGroup(group);
            return id;
        }

        public List<GroupListVm> GetActiveGroups()
        {
            var groups = _groupRepo.GetGroups().Where(x => x.IsActive == true).ProjectTo<GroupListVm>(_mapper.ConfigurationProvider).ToList();
            return groups;
        }

        public void UpdateGroup(NewGroupVm model)
        {
            var group = _mapper.Map<Group>(model);
            _groupRepo.UpdateGroup(group);
        }

        public NewGroupVm GroupDetails(int id)
        {
            var group = _groupRepo.GetGroupById(id);
            var groupVm = _mapper.Map<NewGroupVm>(group);
            return groupVm;
        }

        public void DeactiveGroup(NewGroupVm model)
        {
            model.IsActive = false;
            var group = _mapper.Map<Group>(model);
            _groupRepo.DeactivateGroup(group);
        }
    }
}
