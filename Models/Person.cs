using System.Collections.Generic;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public List<Pet> Pets { get; set; }

    public Person()
    {
        Pets = new List<Pet>();
    }

    public string GetFullName()
    {
        return $"{Name} {Surname}";
    }
}
