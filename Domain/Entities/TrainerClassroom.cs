namespace Domain.Entities;
public class TrainerClassroom{
    public string? IdPerTrainerFk { get; set; }   
    public Person? Person { get; set; }

    public int IdClassroomFk { get; set; }
    public Classroom? Classroom { get; set; }
}
