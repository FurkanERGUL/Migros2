using Migros.DAL.Abstract;
using Migros.DAL.Concrete;
using Migros.DATA.Concrete;
using Migros.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migros.Service.Concrete
{
    public class ProductService : BaseService<Product>, IProductService
    {
        public ProductService(IBaseRepo<Product> repo) : base(repo)
        {
        }
    }
}
