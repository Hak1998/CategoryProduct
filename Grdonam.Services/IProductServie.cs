using Grdonam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grdonam.Services
{
    public interface IProductServie
    {
        void Add(ProductModel model);
        List<ProductModel> GetAll();
        ProductModel Get(Guid id);
        void Update(ProductModel product);
        void Delete(Guid id);
    }
}
