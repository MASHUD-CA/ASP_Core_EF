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

        // Edited for Gender
        public void Add(Gender _Gender)
        {
            if(_Gender.GenderId == 0)
            {
                db.Genders.Add(_Gender);
                db.SaveChanges();
            }
            else
            {
                var dbEntity = db.Genders.Find(_Gender.GenderId);
                dbEntity.GenderName = _Gender.GenderName;
                db.SaveChanges();
            }
        }

        public Gender GetGender(int? Id)
        {
            //GetGender only one student
            //  Gender dbEntity = db.Genders.Find(Id);
           //   Gender dbEntity = db.Genders.Include(s => s.Students).SingleOrDefault(m => m.GenderId == Id);
            //  return dbEntity;
            return db.Genders.Include(s => s.Students).SingleOrDefault(a => a.GenderId == Id);
        }

        public void Remove(int? Id)
        {
            Gender dbEntity = db.Genders.Find(Id);
            db.Genders.Remove(dbEntity);
            db.SaveChanges();
        }

        
    }
}
