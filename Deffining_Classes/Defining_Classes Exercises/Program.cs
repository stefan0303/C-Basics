using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
/*
class Program
{
    public static void Main(string[] args)
    {
        Type personType = typeof(Person);
        FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
        Console.WriteLine(fields.Length);
        var firstPerson = new Person
        {
            name = "Pesho",
            age = 20

        };
        var secondPerson = new Person
        {
            name = "Gosho",
            age = 18
        };
        var thirdPerson = new Person
        {
            name = "Stamat",
            age = 43
        };
    }
}
*/
public class Person
{
    public string name;
    public int age;
  //  public basePerson()
   // {
   //    this.name = "No name";
  //      this.age = 1;
        
       
  //  }
    public personWithAge(int age)
        {
        this.name = "No name";
        return new personWithAge(age)
        }
    
    public Person(string name)
    {
        
    }
}

public class Program
{
    public static void Main()
    {
        Type personType = typeof(Person);
        ConstructorInfo emptyCtor = personType.GetConstructor(new Type[] { });
        ConstructorInfo ageCtor = personType.GetConstructor(new[] { typeof(int) });
        ConstructorInfo nameAgeCtor = personType.GetConstructor(new[] { typeof(string), typeof(int) });
        bool swapped = false;
        if (nameAgeCtor == null)
        {
            nameAgeCtor = personType.GetConstructor(new[] { typeof(int), typeof(string) });
            swapped = true;

        }
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        Person basePerson = (Person)emptyCtor.Invoke(new object[] { });
        Person personWithAge = (Person)ageCtor.Invoke(new object[] { age });
        Person personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) : (Person)nameAgeCtor.Invoke(new object[] { name, age });

       // Console.WriteLine("{0} {1}", basePerson.name, basePerson.age);
        Console.WriteLine("{0} {1}", personWithAge.name, personWithAge.age);
        Console.WriteLine("{0} {1}", personWithAgeAndName.name, personWithAgeAndName.age);

    }

}

