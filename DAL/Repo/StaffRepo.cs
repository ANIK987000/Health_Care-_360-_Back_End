using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class StaffRepo : IRepo<Staff, int, Staff>
    {
        public Staff Add(Staff obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Staff obj)
        {
            throw new NotImplementedException();
        }

        public List<Staff> Get()
        {
            throw new NotImplementedException();
        }

        public Staff Get(int id)
        {
            throw new NotImplementedException();
        }

        public Staff Update(Staff obj)
        {
            throw new NotImplementedException();
        }
    }
}
