using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using RushabhsBooks.DataAccess.Repository.IRepository;
using RushabhsBooks.Models;
using RushabhsBookStore.DataAccess.Data;

namespace RushabhsBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork //Make the method public to access the class
    {
        private readonly ApplicationDbContext _db; //The using statement
        public UnitOfWork(ApplicationDbContext db) //Constructor to use DI and inject into the repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }
        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save() //All changes will be saved when the Save method is called at the 'Parent' level
        {
            _db.SaveChanges();
        }
    }
}