using RemoteProtocolsWASM.Domain.Interface;
using RemoteProtocolsWASM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Infrastructure.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly Context _context;
        public GroupRepository(Context context)
        {
            _context = context;
        }

        public int CreateGroup(Group model)
        {
            _context.Groups.Add(model);
            _context.SaveChanges();
            return model.GroupId;
        }

        public IQueryable<Group> GetGroups()
        {
            var models = _context.Groups;
            return models;
        }

        public void UpdateGroup(Group model)
        {
            _context.Attach(model);
            _context.Entry(model).Property("Code").IsModified = true;
            _context.Entry(model).Property("Name").IsModified = true;
            _context.SaveChanges();
        }

        public Group GetGroupById(int id)
        {
            var model = _context.Groups.FirstOrDefault(x => x.GroupId == id);
            return model;
        }

        public void DeactivateGroup(Group model)
        {
            _context.Attach(model);
            _context.Entry(model).Property("IsActive").IsModified = true;
            _context.SaveChanges();
        }
    }
}
