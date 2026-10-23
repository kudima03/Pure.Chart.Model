using Pure.Chart.Model.Abstractions;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.Model;

public sealed record ChartSeries : IChartSeries
{
    public ChartSeries(
        IString legend,
        IString xAxisSource,
        IString yAxisSource,
        IString lineType
    )
    {
        Legend = legend;
        XAxisSource = xAxisSource;
        YAxisSource = yAxisSource;
        LineType = lineType;
    }

    public IString Legend { get; }

    public IString XAxisSource { get; }

    public IString YAxisSource { get; }

    public IString LineType { get; }
}
