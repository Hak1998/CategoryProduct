using Grdonam.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Grdonam.Services
{
    internal class CategoryService: ICategoryServie
    {
        private readonly IDbConetxt _dbContext;
        public CategoryService(IDbConetxt dbConetxt)
        {
            _dbContext = dbConetxt;
        }
        public void Add(CategoryModel model)
        {
            model.Id = Guid.NewGuid();
            _dbContext.Categories.Add(model);
        }
        public List<CategoryModel> GetAll()
        {
            return _dbContext.Categories;
        }
        public CategoryModel Get(Guid id)
        {
            CategoryModel category = _dbContext.Categories.FirstOrDefault(p => p.Id == id);
            return category;
        }
        public void Update(CategoryModel category)
        {
            CategoryModel categoryTobeChanged = Get(category.Id);
            int index = _dbContext.Categories.IndexOf(categoryTobeChanged);
            _dbContext.Categories[index] = category;
        }
        public void Delete(Guid id)
        {
            CategoryModel category = Get(id);
            _dbContext.Categories.Remove(category);
        }
    }
}
