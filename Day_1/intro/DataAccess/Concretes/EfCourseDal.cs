using intro.DataAccess.Abstracts;
using intro.Entities;

namespace intro.DataAccess.Concretes;

public class EfCourseDal:ICourseDal
{
    List<Course> courses;
    public EfCourseDal()
    {
        Course course1 = new Course();
        course1.Id = 0;
        course1.Name = "JavaScript";
        course1.Description = "JavaScript Kursu Ef den...";
        course1.Price = 0;
        Course course2 = new Course();
        course2.Id = 1;
        course2.Name = "Java";
        course2.Description = "Java 17 Kursu";
        course2.Price = 10;
        Course course3 = new Course();
        course3.Id = 2;
        course3.Name = "Python";
        course3.Description = "Python 3.12 Kursu";
        course3.Price = 20;

        courses = new List<Course> { course1, course2, course3 };
    }
    public List<Course> GetAll()
    {
        //burada DB işlemleri yapılır // SQL öğren
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
}
