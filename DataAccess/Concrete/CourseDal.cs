using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal()
        {
            _courses = new List<Course>
            {
                new Course{CourseId=1, CategoryId=1, CourseName="C#", CoursePrice=2000},
                new Course{CourseId=2, CategoryId=1, CourseName="JavaScprit", CoursePrice=1500},
                new Course{CourseId=3, CategoryId=2, CourseName="SQL", CoursePrice=2500}
            };
        }
        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            var courseDelete = _courses.Where(c => c.CourseId == course.CourseId).SingleOrDefault();
            if(courseDelete != null)
            {
                _courses.Remove(courseDelete);
            }
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course course)
        {
            var courseUpdate=_courses.Where(c=>c.CourseId==course.CourseId).SingleOrDefault();
            if(courseUpdate != null)
            {
                courseUpdate = course;
            }
        }
    }
}
