﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Petsy.Models;

public class Pet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    [Range(0, 50, ErrorMessage = "Pet age must be between 0 and 50.")]
    public int Age { get; set; }
    public int? PersonId { get; set; }

    public Person? Person { get; set; }
    public List<Vaccine> Vaccines { get; set; } = new List<Vaccine>();

    public Pet()
    {
        Vaccines = new List<Vaccine>();
    }
}