using TrainingApp.Domain.Enums;

namespace TrainingApp.Domain.Entities;

public sealed class Profile
{
    public string       Id           { get; init; } = Guid.NewGuid().ToString("N");
    public string       WeightUnit   { get; set;  } = "kg";
    public decimal?     TargetWeight { get; set;  }
    public EffortScale  EffortScale  { get; set;  }
    public TrainingPlan TrainingPlan { get; init; } = new();


    public List<Routine>              Routines              { get; init; } = [];
    public List<Workout>              Workouts              { get; init; } = [];
    public List<BodyWeightEntry>      BodyWeightHistory     { get; init; } = [];
    public List<Exercise>             CustomExercises       { get; init; } = [];
    public List<ExerciseWeightRecord> ExerciseWeightRecords { get; init; } = [];
}
