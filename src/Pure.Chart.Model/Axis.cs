using Pure.Chart.Model.Abstractions;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.Model;

public sealed record Axis : IAxis
{
    public Axis(IString legend)
    {
        Legend = legend;
    }

    public IString Legend { get; }
}
