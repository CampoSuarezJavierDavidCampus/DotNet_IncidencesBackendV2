namespace Domain.Entities;
public class Inscription{
    public int IdInscription { get; set; }

    public string? IdPersonFk { get; set; }
    public Person? Person { get; set; }

    public int IdClassroomFk { get; set; }
    public Classroom? Classroom { get; set; }
}
