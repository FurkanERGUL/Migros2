using Migros.DAL.Abstract;
using Migros.DAL.Contexts;
using Migros.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migros.DAL.Concrete
{
    public class OrderRepo : BaseRepo<Order>, IOrderRepo
    {
        public OrderRepo(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
