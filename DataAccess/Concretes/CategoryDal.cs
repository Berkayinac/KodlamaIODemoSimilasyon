using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal()
        {
            Category category1 = new Category
            {
                Id = 1,
                Name = "Yazılım Programlama"
            };

            Category category2 = new Category
            {
                Id = 2,
                Name = "Veritabanı Programlama"
            };

            _categories = new List<Category>();

            _categories.Add(category1);
            _categories.Add(category2);
        }
        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetById(int id)
        {
            return _categories.SingleOrDefault(c => c.Id == id);
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            _categories.Remove(category);
        }

        public void Update(Category category)
        {
            var updatedCategory = GetById(category.Id);
            updatedCategory.Name = category.Name;
        }
    }
}
