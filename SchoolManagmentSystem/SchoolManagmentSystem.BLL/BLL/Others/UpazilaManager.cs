using System;
using System.Collections.Generic;
using System.Text;
using SchoolManagmentSystem.Model.Model.Others;
using SchoolManagmentSystem.Repository.Repository.Others;

namespace SchoolManagmentSystem.BLL.BLL.Others
{
    public class UpazilaManager
    {
        UpazilaRepository _upazilaRepository = new UpazilaRepository();
        public List<Upazila> GetAll(int id)
        {
            return _upazilaRepository.GetAll(id);
        }
    }
}
