namespace TrainingApp.Domain.Entities;

public sealed class WorkoutExercise
{
    public required string ExerciseId { get; init; }
    public RoutineExercise? Target { get; set; }
    public List<ExerciseSet> Sets { get; init; } = [];
    public decimal? TopWeight { get; set; }
}
