using System;
using System.Collections.Generic;
using System.Text;
using RushabhsBooks.Models;

namespace RushabhsBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
