// See https://aka.ms/new-console-template for more information
using intro.Business;
using intro.Entities;

Console.WriteLine("Hello, World!");

CourseManager courseManager = new CourseManager();

Course[] courses1= courseManager.GetAll();

for (int i = 0; i < courses1.Length; i++)
{
    Console.WriteLine("Kurs: " + courses1[i].Name + " / Ücret: " + courses1[i].Price);
    
}