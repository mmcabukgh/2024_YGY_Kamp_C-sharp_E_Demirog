// See https://aka.ms/new-console-template for more information

// INTERFACES Newlenemez, sadece sınıflar new lenebilir

// IPersonManager personManager = new IPersonManager(); <<----- Yanlış - çalışmaz 

IPersonManager customerManager = new CustomerManager();         // ya da
IPersonManager employeeManager = new EmployeeManager();     //olmalı

customerManager.Add();
employeeManager.Add();

// Şimdi genel bir "ProjectManager" ile projeyi merkezi bir yerden yönettiğimizi düşünelim.
// ProjectManager in TEK Add metodu ile ister Müşteri, ister Personel ekleyebilmeliyiz.
// Bu yüzden Add metoduna parametre olarak CLASS değil INTERFACE veririz !!!!
// Böylece aynı Add metodu hem CustomerManager hem de EmployeeManager ile çalışabilir.

Console.WriteLine("Merkezi Project Manager ile Ekleme ------------------------------------");

ProjectManager projectManager = new ProjectManager();
projectManager.Add(customerManager);  // CustomerManager dan gelen Müşteri ekleme kodu çalışır.
projectManager.Add(employeeManager);  // EmployeeManager dan gelen Personel ekleme kodu çalışır.

// İleride yeni bir ekleme (Örnek: Stajyer- Intern) gerekirse ESKİ KODLARDA HİÇBİR DEĞİŞİKLİK yapmadan InterManager ile de çalışabilir
IPersonManager internManager = new InternManager();
projectManager.Add(internManager);    // InternManager dan gelen Stajyer ekleme kodu çalışır.



interface IPersonManager 
{
    //un implemented operation
    void Add();
    void Update();
}
class ProjectManager
{
    public void Add(IPersonManager person)
    {
        person.Add();
    }
}
//inheerits - class ************************ implements - interface
class CustomerManager : IPersonManager
{
    public void Add()
    {
        //müşteri ekleme kodları
        Console.WriteLine("Müşteri eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri güncellendi");
    }
}
class EmployeeManager : IPersonManager
{
    public void Add()
    {
        //personel ekleme kodları
        Console.WriteLine("Personel eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Personel güncellendi");
    }
}
class InternManager : IPersonManager
{
    public void Add()
    {
        //personel ekleme kodları
        Console.WriteLine("Stajyer eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Stajyer güncellendi");
    }
}
