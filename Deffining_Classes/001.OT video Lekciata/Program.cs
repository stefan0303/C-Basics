
using System;
using System.Collections.Generic;

public class Author
{
    public Author(string firstName, string lastName)//Constructor sus parametri
    {                                               //Veche triabva da se pishat parametrite pri vikane!    
        if (firstName == null | lastName == null)
        {
            throw new ArgumentException("Author firs name or last name cannot be null!");
        };
        this.firstName = firstName;
        this.lastName = lastName;

    }


    // public Author() //constuctor of Author Bez Parametri
    //   {               //KOgato Author se sudava se vika tozi kod otdolo

    //      year = 1600;
    //      this.books = new List<Book>();//izrichno kazvame sus this che idva ot Avtora
    //  }
    public string firstName;
    public string lastName;
    public int year;
    public List<Book> books;

}

