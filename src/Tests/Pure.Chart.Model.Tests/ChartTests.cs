using Pure.Chart.Model.Abstractions;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;

namespace Pure.Chart.Model.Tests;

public sealed record ChartTests
{
    [Fact]
    public void InitializeTitleCorrectly()
    {
        IString title = new RandomString();

        IChart chart = new Chart(
            title,
            new RandomString(),
            new ChartType(new RandomString()),
            new Axis(new RandomString()),
            new Axis(new RandomString()),
            [new Series(new RandomString(), new RandomString(), new RandomString())]
        );

        Assert.Equal(title.TextValue, chart.Title.TextValue);
    }

    [Fact]
    public void InitializeDescriptionCorrectly()
    {
        IString description = new RandomString();

        IChart chart = new Chart(
            new RandomString(),
            description,
            new ChartType(new RandomString()),
            new Axis(new RandomString()),
            new Axis(new RandomString()),
            [new Series(new RandomString(), new RandomString(), new RandomString())]
        );

        Assert.Equal(description.TextValue, chart.Description.TextValue);
    }

    [Fact]
    public void InitializeChartTypeCorrectly()
    {
        IChartType type = new ChartType(new RandomString());

        IChart chart = new Chart(
            new RandomString(),
            new RandomString(),
            type,
            new Axis(new RandomString()),
            new Axis(new RandomString()),
            [new Series(new RandomString(), new RandomString(), new RandomString())]
        );

        Assert.Equal(type, chart.Type);
    }

    [Fact]
    public void InitializeXAxisCorrectly()
    {
        IAxis axis = new Axis(new RandomString());

        IChart chart = new Chart(
            new RandomString(),
            new RandomString(),
            new ChartType(new RandomString()),
            axis,
            new Axis(new RandomString()),
            [new Series(new RandomString(), new RandomString(), new RandomString())]
        );

        Assert.Equal(axis, chart.XAxis);
    }

    [Fact]
    public void InitializeYAxisCorrectly()
    {
        IAxis axis = new Axis(new RandomString());

        IChart chart = new Chart(
            new RandomString(),
            new RandomString(),
            new ChartType(new RandomString()),
            new Axis(new RandomString()),
            axis,
            [new Series(new RandomString(), new RandomString(), new RandomString())]
        );

        Assert.Equal(axis, chart.YAxis);
    }

    [Fact]
    public void InitializeSeriesCorrectly()
    {
        IEnumerable<ISeries> series =
        [
            new Series(new RandomString(), new RandomString(), new RandomString()),
        ];

        IChart chart = new Chart(
            new RandomString(),
            new RandomString(),
            new ChartType(new RandomString()),
            new Axis(new RandomString()),
            new Axis(new RandomString()),
            series
        );

        Assert.True(series.SequenceEqual(chart.Series));
    }
}
