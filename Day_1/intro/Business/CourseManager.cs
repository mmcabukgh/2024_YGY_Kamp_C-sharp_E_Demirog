using intro.DataAccess.Abstracts;
using intro.DataAccess.Concretes;
using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.Business;

public class CourseManager
{
    //Course[] courses = new Course[3];
    // DEPENDENCY Injection
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
        Console.WriteLine("CourseManager Başladı");
    }

    public List<Course> GetAll()
    {
        //business rules
    //    CourseDal courseDal = new CourseDal(); //doğru olmaz NEW lemek bağımlı hale getirir.

        Console.WriteLine("Tüm Kurslar getirildi!");
        return _courseDal.GetAll();
    }
}
