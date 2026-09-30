namespace TrainingApp.Domain.Entities;

public sealed class ExerciseWeightRecord
{
    public required string ExerciseId { get; init; }
    public decimal Weight { get; set; }
    public DateOnly Date { get; set; }
}
