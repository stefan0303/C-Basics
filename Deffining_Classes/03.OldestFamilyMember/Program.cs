using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Family family =new Family(new List<Person>());
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            Person person =new Person(input[0],int.Parse(input[1]));
            family.AddMember(person);
        }
        Console.WriteLine(family.GetOldestMember().name +" "+family.GetOldestMember().age);
        
        //MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        //MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
        //if (oldestMemberMethod == null || addMemberMethod == null)
        //{
        //    throw new Exception();
        //}

    }
}
public class Person
{
    public string name;
    public int age;

    public Person(string name, int age)//first
    {
        this.name = name;
        this.age = age;
    }
}

public class Family
{
    private List<Person> people;

    public Family(List<Person> people)
    {
        this.people = people;
    }
    public void AddMember(Person member)
    {
        this.people.Add(member);
    }

    public Person GetOldestMember()
    {
        var oldestMember = this.people.OrderByDescending(p => p.age).FirstOrDefault();

        return oldestMember;
    }
}
