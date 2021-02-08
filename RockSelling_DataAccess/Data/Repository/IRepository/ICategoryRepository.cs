using RockSelling_Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockSelling_DataAccess.Data.Repository.IRepository
{
    public interface ICategoryRepository:IRepository<Category>
    {
        void Update(Category obj);
    }
}
