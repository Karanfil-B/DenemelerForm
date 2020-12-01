using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EtradeContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
