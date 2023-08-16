namespace Domain.Entities;
public class Classroom: BaseEntity{
    public int IdClassroom { get; set; }
    public string? NameClassroom { get; set; }
    public int Capacity { get; set; }

    public ICollection<Inscription>? Inscriptions { get; set; }
    public ICollection<TrainerClassroom>? TrainerClassrooms { get; set; }
}
