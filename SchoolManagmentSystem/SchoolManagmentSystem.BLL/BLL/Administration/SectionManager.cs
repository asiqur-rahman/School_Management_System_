using System;
using System.Collections.Generic;
using System.Text;
using SchoolManagmentSystem.Model.Model.Administration;
using SchoolManagmentSystem.Repository.Repository.Administration;

namespace SchoolManagmentSystem.BLL.BLL.Administration
{
    public class SectionManager
    {
        private SectionRepository _sectionRepository = new SectionRepository();

        public bool Add(Section section)
        {
            return _sectionRepository.Add(section);
        }
        public List<Section> GetAll()
        {
            return _sectionRepository.GetAll();
        }
        public Section GetById(int id)
        {
            return _sectionRepository.GetById(id);
        }
        public bool Update(Section section)
        {
            return _sectionRepository.Update(section);
        }
        public bool Delete(Section section)
        {
            return _sectionRepository.Delete(section);
        }
    }
}
