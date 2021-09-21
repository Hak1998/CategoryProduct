using Grdonam.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Grdonam.Services
{
    internal class ProductService: IProductServie
    {
        private readonly IDbConetxt _dbConetxt;
        public ProductService(IDbConetxt dbConetxt)
        {
            _dbConetxt = dbConetxt;
        }
        public void Add(ProductModel model)
        {
            model.Id = Guid.NewGuid();
            _dbConetxt.Products.Add(model);
        }
        public List<ProductModel> GetAll()
        {
            return _dbConetxt.Products;
        }
        public ProductModel Get(Guid id)
        {
            ProductModel product = _dbConetxt.Products.FirstOrDefault(p => p.Id == id);
            return product;
        }
        public void Update(ProductModel product)
        {
            ProductModel productTobeChanged = Get(product.Id);
            int index = _dbConetxt.Products.IndexOf(productTobeChanged);
            _dbConetxt.Products[index] = product;
        }
        public void Delete(Guid id)
        {
            ProductModel product = Get(id);
            _dbConetxt.Products.Remove(product);
        }
    }
}
