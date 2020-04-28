using ASP_Core_EF.Models;
using ASP_Core_EF.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Core_EF.Reposotory
{
    public class GenderRepository : IGender
    {
        private DB_Context db;
        public GenderRepository(DB_Context _db)
        {
            db = _db;
        }

        //Getting all the Genders info from the Database in following line
        public IEnumerable<Gender> GetGenders => db.Genders;

        public void Add(Gender _Gender)
        {
            db.Genders.Add(_Gender);
            db.SaveChanges();
        }

        public Gender GetGender(int? Id)
        {
            //GetGender only one student
            //  Gender dbEntity = db.Genders.Find(Id);
            Gender dbEntity = db.Genders.Include(s => s.Students).SingleOrDefault(m => m.GenderId == Id);
            
            return dbEntity;
        }

        public void Remove(int? Id)
        {
            Gender dbEntity = db.Genders.Find(Id);
            db.Genders.Remove(dbEntity);
            db.SaveChanges();
        }

        
    }
}
