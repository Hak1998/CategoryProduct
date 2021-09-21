using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grdonam.Models
{
    internal class DbContext : IDbConetxt
    {
        public DbContext()
        {
            Categories = new List<CategoryModel>();
            Products = new List<ProductModel>();
        }
        public List<CategoryModel> Categories { get;  }
        public List<ProductModel> Products { get ; }
    }
    public interface IDbConetxt
    {
        List<CategoryModel> Categories { get;  }
        List<ProductModel> Products { get;  }
    }

}
