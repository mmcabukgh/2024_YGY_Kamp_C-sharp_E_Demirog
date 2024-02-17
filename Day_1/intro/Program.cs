// See https://aka.ms/new-console-template for more information
using intro.Business;
using intro.DataAccess.Concretes;
using intro.Entities;

Console.WriteLine("Hello, World!");

CourseManager courseManager = new CourseManager(new CourseDal());
// Sadece  "new CourseDal()" ı >>>>  "new EfCourseDal()" yaparak tamamen farklı veritabanına ulaşabiliyoruz.
//CourseManager courseManager = new CourseManager(new EfCourseDal()); 

// Course[] courses1= courseManager.GetAll(); // güncellendi
List<Course> courses1 = courseManager.GetAll();

for (int i = 0; i < courses1.Count; i++)
{
    Console.WriteLine("Kurs: " + courses1[i].Name + " / Ücret: " + courses1[i].Price);    
}

IndividualCustomer customer1 =  new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdendity = "12345678901";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123450";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdendity = "12345678902";
customer2.FirstName = "Mehmet";
customer2.LastName = "Çabuk";
customer2.CustomerNumber = "123451";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.TaxNumber = "12345678903";
customer3.Name = "Abc";
customer3.CustomerNumber = "123452";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.TaxNumber = "12345678904";
customer4.Name = "Def";
customer4.CustomerNumber = "123453";

//-------------------------------
// value types      --> int, bool, double vb...
// reference types  --> array, class, interface 
// 1. value types
int number1 = 10;
int number2 = 20;

number1 = number2;
number2 = 50;

Console.WriteLine(number1); // ÇIKTI 20 olur - Değer -value- tip

// 2. reference types  
string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities2 = cities1;
cities1[0] = "Adana";

Console.WriteLine(cities2[0]); // ÇIKTI "Adana" olur - Referans Tip

BaseCustomer[] customers = [customer1, customer2, customer3, customer4]; //Base classlar alt classların referansını tutabilir.

//POLYMORPHISM
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine( "Sonuç = Id : " + customer.Id + "\t\tCustomer Number : " +customer.CustomerNumber);    
}

