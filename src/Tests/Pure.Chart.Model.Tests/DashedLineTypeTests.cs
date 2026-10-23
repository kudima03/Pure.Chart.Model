using System.Collections;
using Pure.Primitives.Abstractions.Char;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.Model.Tests;

public sealed record DashedLineTypeTests
{
    [Fact]
    public void ProduceCorrectTextValue()
    {
        IString lineType = new DashedLineType();

        Assert.Equal("dashed", lineType.TextValue);
    }

    [Fact]
    public void EnumeratesAsTyped()
    {
        IEnumerable<IChar> lineType = new DashedLineType();

        Assert.True("dashed".SequenceEqual(lineType.Select(x => x.CharValue)));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IEnumerable lineType = new DashedLineType();

        ICollection<IChar> symbols = [];

        foreach (object symbol in lineType)
        {
            symbols.Add((symbol as IChar)!);
        }

        Assert.True("dashed".SequenceEqual(symbols.Select(x => x.CharValue)));
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() => new DashedLineType().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() => new DashedLineType().ToString());
    }
}
