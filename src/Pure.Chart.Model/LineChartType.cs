using Pure.Chart.Model.Abstractions;
using Pure.Primitives.Abstractions.String;
using String = Pure.Primitives.String.String;

namespace Pure.Chart.Model;

public sealed record LineChartType : IChartType
{
    public IString Name { get; } = new String("line");
}
