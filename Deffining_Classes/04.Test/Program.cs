using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Employee
{
   

    public string name;
    public decimal salary;
    public string position;
    public string department;
    public string email;  //optional
    public int age;       //optional     

    public Employee(string name, decimal salary, string position,string department)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
    }

}
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            string[] employeesInfo = Console.ReadLine().Split().ToArray();
            var employee = new Employee(employeesInfo[0],//izbroivame nujnite promenlivi ot public Employee
                decimal.Parse(employeesInfo[1]),
                employeesInfo[2], 
                employeesInfo[3]);
            if (employeesInfo.Length>4)
            {
                employee.email = employeesInfo[4];
               
            }
            if (employeesInfo.Length>5)
            {
                employee.age = int.Parse(employeesInfo[5]);
            }
            else
            {
                employee.email = "n/a";
                employee.age = 1;
            }
        }
        
    }
}

