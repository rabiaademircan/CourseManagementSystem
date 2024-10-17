using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager : IGenericService<Category>
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category item)
        {
            _categoryDal.Add(item);
        }

        public void Delete(Category item)
        {
            _categoryDal.Delete(item);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Update(Category item)
        {
            _categoryDal.Update(item);
        }
    }
}
