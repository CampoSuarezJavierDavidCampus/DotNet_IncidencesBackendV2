namespace Domain.Entities;
public class Inscription{
    public int IdInscription { get; set; }

    public string? IdPersonFK { get; set; }
    public Person? Person { get; set; }

    public int IdClassroom { get; set; }
    public Classroom? Classroom { get; set; }
}
