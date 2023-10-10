using Migros.DAL.Abstract;
using Migros.DAL.Contexts;
using Migros.DATA.Concrete;
using Migros.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Migros.DAL.Concrete
{
    public class CategoryRepo : BaseRepo<Category>, ICategoryRepo
    {
        public CategoryRepo(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
