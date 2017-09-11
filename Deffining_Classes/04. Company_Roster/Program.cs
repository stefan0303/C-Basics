using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Employee
{
    public string Name;
    public decimal Salary;
    public string Position;
    public string Department;
    public string Email = "n/a";  //optional
    public int Age = -1;       //optional     

    public Employee(string name, decimal salary, string position, string department)
    {
        this.Name = name;
        this.Salary = salary;
        this.Position = position;
        this.Department = department;
    }
    public Employee(string name, decimal salary, string position, string department, string email, int age)
    {
        this.Name = name;
        this.Salary = salary;
        this.Position = position;
        this.Department = department;
        this.Email = email;
        this.Age = age;
    }
}
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var employees = new List<Employee>(); //tuka slagame vseki edin podaden employee
        for (int i = 0; i < n; i++)
        {
            string[] employeesInfo = Console.ReadLine().Split(' ').ToArray();
            //izbroivame nujnite promenlivi ot public Employee
            var employee = new Employee(

                employeesInfo[0],
                decimal.Parse(employeesInfo[1]),
                employeesInfo[2],
                employeesInfo[3]);

        employees.Add(employee); //addvame vseki employee v lista
    }

    var result = employees.GroupBy(e => e.Department)
     .Select(e => new
     {
         Department = e.Key,
         AverageSalary = e.Average(emp => emp.Salary),//anonimen obekt
                employees = e.OrderByDescending(emp => emp.Salary),
         Employee = e.OrderByDescending(emp => emp.Salary)
     })
     .OrderByDescending(dep => dep.AverageSalary).FirstOrDefault();//izkarva samo purvia resultat


    Console.WriteLine("Highest Average Salary: " + result.Department);
        foreach (var e in result.employees)
        {
            Console.WriteLine("{0} {1:f2} {2} {3}",e.Name,e.Salary,e.Email,e.Age);
        }
    }
}
//Viarna na 80% v Judje
