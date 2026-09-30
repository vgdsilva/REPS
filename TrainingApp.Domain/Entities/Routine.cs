using TrainingApp.Domain.Enums;

namespace TrainingApp.Domain.Entities;

public sealed class Routine
{
    public string Id { get; init; } = Guid.NewGuid().ToString("N");
    public required string Name { get; set; }
    public string? Emoji { get; set; }
    public ProgressionType? Progression { get; set; }
    public List<RoutineExercise> Exercises { get; init; } = [];
}
