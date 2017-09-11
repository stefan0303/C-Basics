using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Person
    {
        public string name;
        public int age;

        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }

        public Person(int age)
        {
            this.age = age;
            this.name = "No name";
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> persons =new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person =new Person(name,age);
                persons.Add(person);
            }
            foreach (var person in persons.Where(p=>p.age>30).OrderBy(p=>p.name))
            {
                Console.WriteLine(person.name+" - "+person.age);
            }
        }
    }

