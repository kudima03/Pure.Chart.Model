using Pure.Chart.Model.Abstractions;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;

namespace Pure.Chart.Model.Tests;

public sealed record ChartSeriesTests
{
    [Fact]
    public void InitializeLegendCorrectly()
    {
        IString legend = new RandomString();

        IChartSeries series = new ChartSeries(
            legend,
            new RandomString(),
            new RandomString()
        );

        Assert.Equal(legend.TextValue, series.Legend.TextValue);
    }

    [Fact]
    public void InitializeXAxisSourceCorrectly()
    {
        IString xAxisSource = new RandomString();

        IChartSeries series = new ChartSeries(
            new RandomString(),
            xAxisSource,
            new RandomString()
        );

        Assert.Equal(xAxisSource.TextValue, series.XAxisSource.TextValue);
    }

    [Fact]
    public void InitializeYAxisSourceCorrectly()
    {
        IString yAxisSource = new RandomString();

        IChartSeries series = new ChartSeries(
            new RandomString(),
            new RandomString(),
            yAxisSource
        );

        Assert.Equal(yAxisSource.TextValue, series.YAxisSource.TextValue);
    }
}
