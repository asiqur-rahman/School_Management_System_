using System;
using System.Collections.Generic;
using System.Text;
using SchoolManagmentSystem.Model.Model.Others;
using SchoolManagmentSystem.Repository.Repository.Others;

namespace SchoolManagmentSystem.BLL.BLL.Others
{
    public class DivisionManager
    {
        DivisionRepository _divisionRepository = new DivisionRepository();
        public List<Division> GetAll()
        {
            return _divisionRepository.GetAll();
        }
    }
}
