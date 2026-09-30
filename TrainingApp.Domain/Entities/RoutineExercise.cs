using TrainingApp.Domain.Enums;

namespace TrainingApp.Domain.Entities;

public sealed class RoutineExercise
{
    public required string ExerciseId { get; init; }
    public int Sets { get; set; } = 1;
    public ExerciseMode Mode { get; set; } = ExerciseMode.Repetitions;
    public int? Repetitions { get; set; }
    public int? MinimumRepetitions { get; set; }
    public int? MaximumRepetitions { get; set; }
    public TimeSpan? Duration { get; set; }
    public TimeSpan? CardioDuration { get; set; }
    public decimal? Weight { get; set; }
    public decimal? SpeedKilometersPerHour { get; set; }
    public bool IsBodyWeight { get; set; }
    public bool IsPerSide { get; set; }
    public ProgressionType? Progression { get; set; }
    public decimal? WeightIncrement { get; set; }
    public string? SupersetGroup { get; set; }
}
