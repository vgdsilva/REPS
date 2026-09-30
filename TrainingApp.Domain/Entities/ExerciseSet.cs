namespace TrainingApp.Domain.Entities;

public sealed class ExerciseSet
{
    public decimal? Weight { get; set; }
    public int? Repetitions { get; set; }
    public TimeSpan? Duration { get; set; }
    public decimal? SpeedKilometersPerHour { get; set; }
    public decimal? RepetitionsInReserve { get; set; }
    public decimal? RateOfPerceivedExertion { get; set; }
    public bool IsCompleted { get; set; }
}
