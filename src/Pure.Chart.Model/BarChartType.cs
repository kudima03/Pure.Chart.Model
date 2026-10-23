using Pure.Chart.Model.Abstractions;
using Pure.Primitives.Abstractions.String;
using String = Pure.Primitives.String.String;

namespace Pure.Chart.Model;

public sealed record BarChartType : IChartType
{
    public IString Name { get; } = new String("bar");
}
