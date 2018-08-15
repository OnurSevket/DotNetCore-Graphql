using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore_Api.Models;

namespace DotNetCore_Api.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private List<Category> _categories;

        public CategoryRepository()
        {
            _categories = new List<Category>
            {
                new Category()
                {
                    Id=1,
                    Name="Computer"
                },
                new Category()
                {
                    Id=2,
                    Name="Mobile Phones"
                }
            };
        }

        public Task<List<Category>> CategoriesAsync()
        {
            return Task.FromResult(_categories);
        }

        public Task<Category> GetCategoryAsync(int id)
        {
            return Task.FromResult(_categories.FirstOrDefault(_ => _.Id == id));
        }
    }
}
