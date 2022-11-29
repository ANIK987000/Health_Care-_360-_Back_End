using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Doctor, int, Doctor> DoctorDataAccess()
        {
            return new DoctorRepo();
        }
        public static IRepo<Patient, int, Patient> PatientDataAccess()
        {
            return new PatientRepo();
        }
        public static IRepo<Hospital, int, Hospital> HospitalDataAccess()
        {
            return new HospitalRepo();
        }
        public static IRepo<Staff, int, Staff> StaffDataAccess()
        {
            return new StaffRepo();
        }
        //public static IAuth AuthDataAccess()
        //{
        //    return new UserRepo();
        //}
        //public static IRepo<Token, string, Token> TokenDataAccess()
        //{
        //    return new TokenRepo();
        //}
    }
 }
