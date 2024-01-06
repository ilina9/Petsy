using System.Collections.Generic;

public class Pet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Age { get; set; }
    public int? PersonId { get; set; }

    public Person? Person { get; set; } 
    public List<Vaccine> Vaccines { get; set; } = new List<Vaccine>();

    public Pet()
    {
        Vaccines = new List<Vaccine>();
    }
}
