namespace TrainingApp.Domain.Entities;

public sealed class TrainingPlan
{
    public Dictionary<DayOfWeek, string> WeeklySchedule { get; init; } = [];

    // A null routine explicitly marks a rest day and overrides the weekly schedule.
    public Dictionary<DateOnly, string?> DailyOverrides { get; init; } = [];
}
