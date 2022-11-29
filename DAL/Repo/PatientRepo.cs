using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class PatientRepo : IRepo<Patient, int, Patient>
    {
        public Patient Add(Patient obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Patient obj)
        {
            throw new NotImplementedException();
        }

        public List<Patient> Get()
        {
            throw new NotImplementedException();
        }

        public Patient Get(int id)
        {
            throw new NotImplementedException();
        }

        public Patient Update(Patient obj)
        {
            throw new NotImplementedException();
        }
    }
}
