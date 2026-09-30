namespace TrainingApp.Domain.Entities;

public sealed class BodyWeightEntry
{
    public DateOnly Date { get; set; }
    public decimal Weight { get; set; }
    public DateTimeOffset RecordedAt { get; set; }
}
