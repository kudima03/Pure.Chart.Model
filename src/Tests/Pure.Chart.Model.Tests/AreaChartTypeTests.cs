using Pure.Chart.Model.Abstractions;

namespace Pure.Chart.Model.Tests;

public sealed record AreaChartTypeTests
{
    [Fact]
    public void ProduceCorrectName()
    {
        IChartType type = new AreaChartType();

        Assert.Equal("area", type.Name.TextValue);
    }
}
