using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PatientService
    {
        public static PatientDTO Add(PatientDTO patient)
        {
            var config = Service.Mapping<PatientDTO, Patient>();
            var mapper = new Mapper(config);
            var data = mapper.Map<Patient>(patient);
            var access = DataAccessFactory.PatientDataAccess().Add(data);
            if (access != null)
            {
                return mapper.Map<PatientDTO>(access);
            }return null;
        }
        public static List<PatientDTO> Get()
        {
            var config = Service.OneTimeMapping<Patient, PatientDTO>();
            var mapper = new Mapper(config);
            var access = DataAccessFactory.PatientDataAccess().Get();
            return mapper.Map<List<PatientDTO>>(access);            
        }
        public static PatientDTO Get(int id)
        {
            var config = Service.OneTimeMapping<Patient, PatientDTO>();
            var mapper = new Mapper(config);
            var access = DataAccessFactory.PatientDataAccess().Get(id);
            return mapper.Map<PatientDTO>(access);
        }
    }
}
