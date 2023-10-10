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
    public class ProductRepo : BaseRepo<Product>, IProductRepo
    {
        public ProductRepo(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
