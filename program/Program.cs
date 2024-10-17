using Business.Concretes;
using DataAccess.Concrete;
using Entities.Concretes;

namespace program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            List<Category> categories = categoryManager.GetAll();
            for (int i = 0; i <categories.Count; i++)
            {
                Console.WriteLine(categories[i].CategoryName + "/" + categories[i].CategoryDescription);
            }
            Course course = new Course();
            course.CourseId = 1;
            course.CourseName = "PHP";
            course.CategoryId = 1;
            course.CoursePrice = 250;

            Instructor ınstructor = new Instructor();
            ınstructor.InstructorId = 1;
            ınstructor.InstructorFirstName = "Burcu";
            ınstructor.InstructorlastName = "Akbay";
        }
    }
}
