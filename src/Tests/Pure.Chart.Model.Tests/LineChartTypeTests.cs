using Pure.Chart.Model.Abstractions;

namespace Pure.Chart.Model.Tests;

public sealed record LineChartTypeTests
{
    [Fact]
    public void ProduceCorrectName()
    {
        IChartType type = new LineChartType();

        Assert.Equal("line", type.Name.TextValue);
    }
}
