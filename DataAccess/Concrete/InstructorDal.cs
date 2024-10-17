using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal()
        {
            _instructors = new List<Instructor>
            {
                new Instructor{InstructorId=1, InstructorFirstName="Ayşe", InstructorlastName="Demir"},
                new Instructor{InstructorId=2, InstructorFirstName="Ahmet", InstructorlastName="Yazıcı"}
            };
        }
        
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            var instructorDelete = _instructors.Where(i => i.InstructorId == instructor.InstructorId).SingleOrDefault();
            if(instructorDelete != null)
            {
                _instructors.Remove(instructor);
            }
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor instructor)
        {
            var instructorUpdate = _instructors.Where(i => i.InstructorId==instructor.InstructorId).SingleOrDefault();
            if(instructorUpdate != null)
            {
                instructorUpdate = instructor;
            }
        }
    }
}
