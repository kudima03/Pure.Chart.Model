using Pure.Chart.Model.Abstractions;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.Model;

public sealed record Series : ISeries
{
    public Series(IString legend, IString xAxisSource, IString yAxisSource)
    {
        Legend = legend;
        XAxisSource = xAxisSource;
        YAxisSource = yAxisSource;
    }

    public IString Legend { get; }

    public IString XAxisSource { get; }

    public IString YAxisSource { get; }
}
