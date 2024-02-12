using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.Business;

public class CourseManager
{
    Course[] courses = new Course[3];
    public CourseManager()
    {
        Course course1 = new Course();
        course1.Id = 0;
        course1.Name = "C#";
        course1.Description = "C# Kursu";
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

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;

        Console.WriteLine("CourseManager Başladı");
    }
    public Course[] GetAll()
    {        
        Console.WriteLine("Tüm Kurslar getirildi!");
        return courses;
    }
}
