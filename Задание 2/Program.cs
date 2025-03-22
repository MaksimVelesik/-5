using System;

class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }
}

class Department
{
    public string Name { get; set; }

    public Department(string name)
    {
        Name = name;
    }
}

class Client
{
    public string Name { get; set; }

    public Client(string name)
    {
        Name = name;
    }
}

class Company
{
    private Employee[] employees;
    public Department Department { get; }

    public Company(Employee[] employees, Department department)
    {
        this.employees = employees;
        Department = department;
    }

    public decimal CalculateTotalSalary()
    {
        decimal totalSalary = 0;
        foreach (var employee in employees)
        {
            totalSalary += employee.Salary;
        }
        return totalSalary;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Отдел: {Department.Name}");
        foreach (var employee in employees)
        {
            Console.WriteLine($"- {employee.Name}: {employee.Salary}");
        }
    }
}

class Program
{
    static void Main()
    {
        var employees1 = new[]
        {
            new Employee("Иван Иванов", 50000),
            new Employee("Мария Петрова", 60000)
        };
        var employees2 = new[]
        {
            new Employee("Сергей Сидоров", 55000),
            new Employee("Анна Смирнова", 70000)
        };

        var department1 = new Department("Отдел продаж");
        var department2 = new Department("Отдел разработки");

        var companies = new[]
        {
            new Company(employees1, department1),
            new Company(employees2, department2)
        };

        foreach (var company in companies)
        {
            company.DisplayInfo();
            Console.WriteLine($"Общая зарплата: {company.CalculateTotalSalary()}\n");
        }
    }
}