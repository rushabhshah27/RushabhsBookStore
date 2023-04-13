using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RushabhsBooks.DataAccess.Repository.IRepository;
using RushabhsBooks.Models;
using RushabhsBookStore.DataAccess.Data;

namespace RushabhsBooks.DataAccess.Repository
{
    public class CoverTypeRepository :Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            //Use .NET LINQ to retrieve the first or default category object,
            //Then pass the id as a generic entity which matches the category ID

            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null) //Save changes if not null
            {
                objFromDb.Name = coverType.Name;
                //_db.SaveChanges();

            }
        }
    }
}