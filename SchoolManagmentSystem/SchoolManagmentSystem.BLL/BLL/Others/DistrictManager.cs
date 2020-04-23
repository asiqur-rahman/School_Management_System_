using System;
using System.Collections.Generic;
using System.Text;
using SchoolManagmentSystem.Model.Model.Others;
using SchoolManagmentSystem.Repository.Repository.Others;

namespace SchoolManagmentSystem.BLL.BLL.Others
{
    public class DistrictManager
    {
        DistrictRepository _districtRepository = new DistrictRepository();
        public List<District> GetAll(int id)
        {
            return _districtRepository.GetAll(id);
        }
    }
}
