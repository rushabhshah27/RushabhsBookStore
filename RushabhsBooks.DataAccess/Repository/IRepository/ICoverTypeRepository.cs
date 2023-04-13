using System;
using System.Collections.Generic;
using System.Text;
using RushabhsBooks.Models;

namespace RushabhsBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}