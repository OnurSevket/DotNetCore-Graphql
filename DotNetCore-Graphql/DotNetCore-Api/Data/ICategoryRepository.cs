using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore_Api.Models;

namespace DotNetCore_Api.Data
{
    public interface ICategoryRepository
    {

        Task<List<Category>> CategoriesAsync();
        Task<Category> GetCategoryAsync(int id);

    }
}
