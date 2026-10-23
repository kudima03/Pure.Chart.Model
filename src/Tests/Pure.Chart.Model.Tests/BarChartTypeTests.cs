using Pure.Chart.Model.Abstractions;

namespace Pure.Chart.Model.Tests;

public sealed record BarChartTypeTests
{
    [Fact]
    public void ProduceCorrectName()
    {
        IChartType type = new BarChartType();

        Assert.Equal("bar", type.Name.TextValue);
    }
}
