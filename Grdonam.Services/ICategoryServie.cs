using Grdonam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grdonam.Services
{
    public interface ICategoryServie
    {
        void Add(CategoryModel model);
        List<CategoryModel> GetAll();
        CategoryModel Get(Guid id);
        void Update(CategoryModel category);
        void Delete(Guid id);
    }
}
