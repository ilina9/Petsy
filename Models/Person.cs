﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    [Range(18, 100, ErrorMessage = "Age must be between 18 and 100.")]
    public int Age { get; set; }
    public List<Pet> Pets { get; set; }

    public Person()
    {
        Pets = new List<Pet>();
    }

    [DisplayName("Owner's Full Name")]
    public string GetFullName
    {
        get { return String.Format("{0} {1}", Name, Surname); }
    }

}