using Pure.Chart.Model.Abstractions;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;

namespace Pure.Chart.Model.Tests;

public sealed record AxisTests
{
    [Fact]
    public void InitializeLegendCorrectly()
    {
        IString legend = new RandomString();

        IAxis axis = new Axis(legend);

        Assert.Equal(legend.TextValue, axis.Legend.TextValue);
    }
}
