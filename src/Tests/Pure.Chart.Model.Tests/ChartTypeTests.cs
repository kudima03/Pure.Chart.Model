using Pure.Chart.Model.Abstractions;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;

namespace Pure.Chart.Model.Tests;

public sealed record ChartTypeTests
{
    [Fact]
    public void InitializeNameCorrectly()
    {
        IString chartTypeName = new RandomString();

        IChartType type = new ChartType(chartTypeName);

        Assert.Equal(chartTypeName.TextValue, type.Name.TextValue);
    }
}
