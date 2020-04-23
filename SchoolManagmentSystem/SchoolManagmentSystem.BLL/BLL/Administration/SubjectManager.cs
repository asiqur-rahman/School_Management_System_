using System;
using System.Collections.Generic;
using System.Text;
using SchoolManagmentSystem.Model.Model.Administration;
using SchoolManagmentSystem.Repository.Repository.Administration;

namespace SchoolManagmentSystem.BLL.BLL.Administration
{
    public class SubjectManager
    {
        private SubjectRepository _SubjectRepository = new SubjectRepository();

        public bool Add(Subject subject)
        {
            return _SubjectRepository.Add(subject);
        }
        public List<Subject> GetAll()
        {
            return _SubjectRepository.GetAll();
        }
        public Subject GetById(int id)
        {
            return _SubjectRepository.GetById(id);
        }
        public bool Update(Subject subject)
        {
            return _SubjectRepository.Update(subject);
        }
        public bool Delete(Subject subject)
        {
            return _SubjectRepository.Delete(subject);
        }
    }
}
