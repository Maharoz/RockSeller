using RockSelling.Data;
using RockSelling_DataAccess.Data.Repository.IRepository;
using RockSelling_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockSelling_DataAccess.Data.Repository
{
    public class CategoryRepository:Repository<Category>,ICategoryRepository
    {
        private readonly ApplicationDBContext _db;

        public CategoryRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Category obj)
        {
            var objFromDb = base.FirstOrDefault(u=>u.Id==obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.DisplayOrder = obj.DisplayOrder;
            }
        }
    }
}
