using Pure.Chart.Model.Abstractions;
using Pure.Primitives.Abstractions.String;
using String = Pure.Primitives.String.String;

namespace Pure.Chart.Model;

public sealed record StepChartType : IChartType
{
    public IString Name { get; } = new String("step");
}
