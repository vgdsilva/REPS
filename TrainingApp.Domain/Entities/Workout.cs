namespace TrainingApp.Domain.Entities;

public sealed class Workout
{
    public string Id { get; init; } = Guid.NewGuid().ToString("N");
    public DateOnly Date { get; set; }
    public DateTimeOffset StartedAt { get; set; }
    public DateTimeOffset? EndedAt { get; set; }
    public string? RoutineId { get; set; }
    public required string Name { get; set; }
    public decimal? BodyWeight { get; set; }
    public decimal Volume { get; set; }
    public List<WorkoutExercise> Exercises { get; init; } = [];
    public List<string> PersonalRecordExerciseIds { get; init; } = [];
}
