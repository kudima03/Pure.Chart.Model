using Pure.Chart.Model.Abstractions;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.Model;

public sealed record ChartType : IChartType
{
    public ChartType(IString name)
    {
        Name = name;
    }

    public IString Name { get; }
}
