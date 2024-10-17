using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal()
        {
            _categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Programlama", CategoryDescription="Temel Seviye"},
                new Category{CategoryId=2, CategoryName="VeriTabanı", CategoryDescription="Temel SQL Eğitimi"}
            };
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            var categoryDelete = _categories.Where(c => c.CategoryId == category.CategoryId).SingleOrDefault();
            if (categoryDelete != null)
            {
                _categories.Remove(categoryDelete);
            }

        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category category)
        {
            var UpdateCategory =_categories.Where(c=>c.CategoryId==category.CategoryId).SingleOrDefault();
            if(UpdateCategory != null)
            {
                UpdateCategory = category;
            }
        }
    }
}
