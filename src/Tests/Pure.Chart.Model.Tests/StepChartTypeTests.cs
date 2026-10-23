using Pure.Chart.Model.Abstractions;

namespace Pure.Chart.Model.Tests;

public sealed record StepChartTypeTests
{
    [Fact]
    public void ProduceCorrectName()
    {
        IChartType type = new StepChartType();

        Assert.Equal("step", type.Name.TextValue);
    }
}
