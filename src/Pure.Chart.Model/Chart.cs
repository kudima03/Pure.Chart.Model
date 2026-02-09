using Pure.Chart.Model.Abstractions;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.Model;

public sealed record Chart : IChart
{
    public Chart(
        IString title,
        IString description,
        IChartType type,
        IAxis xAxis,
        IAxis yAxis,
        IEnumerable<ISeries> series
    )
    {
        Title = title;
        Description = description;
        Type = type;
        XAxis = xAxis;
        YAxis = yAxis;
        Series = series;
    }

    public IString Title { get; }

    public IString Description { get; }

    public IChartType Type { get; }

    public IAxis XAxis { get; }

    public IAxis YAxis { get; }

    public IEnumerable<ISeries> Series { get; }
}
