using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class DoctorRepo : IRepo<Doctor, int, Doctor>
    {
        public Doctor Add(Doctor obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Doctor obj)
        {
            throw new NotImplementedException();
        }

        public List<Doctor> Get()
        {
            throw new NotImplementedException();
        }

        public Doctor Get(int id)
        {
            throw new NotImplementedException();
        }

        public Doctor Update(Doctor obj)
        {
            throw new NotImplementedException();
        }
    }
}
