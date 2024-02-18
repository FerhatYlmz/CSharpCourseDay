// See https://aka.ms/new-console-template for more information

//IPersonManager customerManager = new CustomerManager();

//IPersonManager employeeManager = new EmployeeManager();

ProjectManager projectManager = new ProjectManager();
projectManager.Add(new InterManager());



//interface new'lenemez
interface IPersonManager
{
    //unimplement operation
    void Add();
    void Update();
}


//inherits - class --------- implements - interface
class CustomerManager : IPersonManager
{
    public void Add()
    {
        //Müşteri ekleme kodları
        Console.WriteLine("Müşteri eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri Güncellendi");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        //Personel ekleme kodları
        Console.WriteLine("Personel eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Personel Güncellendi");
    }
}

class InterManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Stajyer Güncellendi");
    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}

