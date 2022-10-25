using System.Collections.Generic;

class Employee
{
    public int age { get; set; }
    public int Id { get; set; }
    public string firstname { get; set; }
    public string lastname { get; set; }

    public override string ToString()
    {
        return $"{Id,-5} {firstname,-7} {lastname,-10} {age,-5}";
    }
}
class Employees
{
    List<Employee> employees;
    public Employees()
    {
        this.employees = new List<Employee>();
    }

    public void add(Employee employee)
    {
        employees.Add(employee);
        Console.WriteLine($"{employee} eklendi");

    }

    public void remove(int Id)
    {
        foreach (Employee emp in employees)
        {
            if (emp.Id == Id)
            {
                employees.Remove(emp);
                Console.WriteLine("kaldırıldı");
                break;
            }
        }
    }
}


class program
{
    static void Main()
    {

        Employee employee1 = new Employee()
        {
            age = 18,
            Id = 1,
            firstname = "mustafa",
            lastname = "karaca"
        };
        Employee employee2 = new Employee()
        {
            age = 19,
            Id = 2,
            firstname = "mehmet",
            lastname = "kara"
        };
        Employee employee3 = new Employee()
        {
            age = 20,
            Id = 3,
            firstname = "musa",
            lastname = "tuğ"
        };
        Employee employee4 = new Employee()
        {
            age = 21,
            Id = 4,
            firstname = "selim",
            lastname = "kara"
        };

        Employees employees = new Employees();
        employees.add(employee1);
        employees.add(employee2);
        employees.add(employee3);
        employees.add(employee4);
        employees.remove(4);

    }
}