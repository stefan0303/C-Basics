﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    public string name;
    public int age;

    public Person(string name, int age)//first
    {
        this.name=name;
        this.age = age;
    }
}
    class Program
    {
    static void Main(string[] args)
    {
        Type personType = typeof(Person);
        FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
        Console.WriteLine(fields.Length);
    }

}

