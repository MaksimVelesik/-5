using System;
using System.Collections.Generic;
using System.Linq;

abstract class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }
}

interface IManager
{
    void Manage();
}

interface IWorker
{
    void Work();
}

class Director : Employee, IManager
{
    public Director(string name, decimal salary) : base(name, salary) { }

    public void Manage()
    {
        Console.WriteLine($"{Name} управляет компанией.");
    }
}

class Engineer : Employee, IWorker
{
    public Engineer(string name, decimal salary) : base(name, salary) { }

    public void Work()
    {
        Console.WriteLine($"{Name} работает над проектом.");
    }
}

class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[]
        {
            new Director("Иван Иванов", 100000),
            new Engineer("Мария Петрова", 60000),
            new Director("Сергей Сидоров", 120000),
            new Engineer("Анна Смирнова", 70000)
        };

        var managers = employees.OfType<IManager>().ToList();

        Console.WriteLine("Управленцы:");
        foreach (var manager in managers)
        {
            Console.WriteLine(manager.GetType().Name + ": " + ((Employee)manager).Name);
        }
    }
}