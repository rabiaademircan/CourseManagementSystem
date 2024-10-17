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
    public class InstructorManager : IGenericService<Instructor>
    {
        IInstructorDal _ınstructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _ınstructorDal = instructorDal;
        }
        public void Add(Instructor item)
        {
            _ınstructorDal.Add(item);
        }

        public void Delete(Instructor item)
        {
            _ınstructorDal.Delete(item);
        }

        public List<Instructor> GetAll()
        {
            return _ınstructorDal.GetAll();
        }

        public void Update(Instructor item)
        {
            _ınstructorDal.Update(item);
        }
    }
}
