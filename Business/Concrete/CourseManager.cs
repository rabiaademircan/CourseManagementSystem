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
    public class CourseManager : IGenericService<Course>
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void Add(Course item)
        {
            _courseDal.Add(item);
        }

        public void Delete(Course item)
        {
            _courseDal.Delete(item);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void Update(Course item)
        {
            _courseDal.Update(item);
        }
    }
}
