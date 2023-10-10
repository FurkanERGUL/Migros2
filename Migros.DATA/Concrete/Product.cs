using Migros.DATA.Abstract;
using Migros.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migros.DATA.Concrete
{
    public class Product : IBaseEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public Status Status { get; set; }
        
        
        //Navigation Property
        public int CategoryId { get; set; }
        Category Category { get; set; }
        public List<Order> Orders { get; set; }

    }
}
