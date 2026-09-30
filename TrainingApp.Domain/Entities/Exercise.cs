namespace TrainingApp.Domain.Entities;

public sealed class Exercise
{
    public required string Id { get; init; }
    public required string Name { get; set; }
    public required string BodyPart { get; set; }
    public string? Equipment { get; set; }
    public string? TargetMuscle { get; set; }
    public string? MainMuscle { get; set; }
    public List<string> SecondaryMuscles { get; init; } = [];
    public List<string> Instructions { get; init; } = [];
    public string? Description { get; set; }
    public string? ImageFileName { get; set; }
    public string? AnimationFileName { get; set; }
    public bool IsCustom { get; init; }
}
