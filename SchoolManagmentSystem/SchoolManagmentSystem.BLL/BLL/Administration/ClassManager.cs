using System;
using System.Collections.Generic;
using System.Text;
using SchoolManagmentSystem.Model.Model.Administration;
using SchoolManagmentSystem.Repository.Repository.Administration;

namespace SchoolManagmentSystem.BLL.BLL.Administration
{
    public class ClassManager
    {
        private ClassRepository _classRepository = new ClassRepository();

        public bool Add(Class clas)
        {
            return _classRepository.Add(clas);
        }
        public List<Class> GetAll()
        {
            return _classRepository.GetAll();
        }
        public Class GetById(int id)
        {
            return _classRepository.GetById(id);
        }
        public bool Update(Class clas)
        {
            return _classRepository.Update(clas);
        }
        public bool Delete(Class clas)
        {
            return _classRepository.Delete(clas);
        }
    }
}
