
using System;
using System.Collections.Generic;
using System.Text;
using SchoolManagmentSystem.Model.Model.Administration;
using SchoolManagmentSystem.Repository.Repository.Administration;

namespace SchoolManagmentSystem.BLL.BLL.Administration
{
    public class GroupManager
    {
        private GroupRepository _groupRepository = new GroupRepository();

        public bool Add(Group group)
        {
            return _groupRepository.Add(group);
        }
        public List<Group> GetAll()
        {
            return _groupRepository.GetAll();
        }
        public Group GetById(int id)
        {
            return _groupRepository.GetById(id);
        }
        public bool Update(Group group)
        {
            return _groupRepository.Update(group);
        }
        public bool Delete(Group group)
        {
            return _groupRepository.Delete(group);
        }
    }
}
