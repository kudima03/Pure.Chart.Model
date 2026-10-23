using Pure.Chart.Model.Abstractions;

namespace Pure.Chart.Model.Tests;

public sealed record ScatterChartTypeTests
{
    [Fact]
    public void ProduceCorrectName()
    {
        IChartType type = new ScatterChartType();

        Assert.Equal("scatter", type.Name.TextValue);
    }
}
