using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        void Add(Course category);
        void Update(Course category);
        void Delete(Course category);


    }
}
