using System;
using System.Collections.Generic;
using System.Text;
using SchoolManagmentSystem.Model.Model.Administration;
using SchoolManagmentSystem.Repository.Repository.Administration;

namespace SchoolManagmentSystem.BLL.BLL.Administration
{
    public class ShiftManager
    {
        private ShiftRepository _shiftRepository = new ShiftRepository();

        public bool Add(Shift shift)
        {
            return _shiftRepository.Add(shift);
        }
        public List<Shift> GetAll()
        {
            return _shiftRepository.GetAll();
        }
        public Shift GetById(int id)
        {
            return _shiftRepository.GetById(id);
        }
        public bool Update(Shift shift)
        {
            return _shiftRepository.Update(shift);
        }
        public bool Delete(Shift shift)
        {
            return _shiftRepository.Delete(shift);
        }
    }
}
