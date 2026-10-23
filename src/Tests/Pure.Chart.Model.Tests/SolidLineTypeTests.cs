using System.Collections;
using Pure.Primitives.Abstractions.Char;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.Model.Tests;

public sealed record SolidLineTypeTests
{
    [Fact]
    public void ProduceCorrectTextValue()
    {
        IString lineType = new SolidLineType();

        Assert.Equal("solid", lineType.TextValue);
    }

    [Fact]
    public void EnumeratesAsTyped()
    {
        IEnumerable<IChar> lineType = new SolidLineType();

        Assert.True("solid".SequenceEqual(lineType.Select(x => x.CharValue)));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IEnumerable lineType = new SolidLineType();

        ICollection<IChar> symbols = [];

        foreach (object symbol in lineType)
        {
            symbols.Add((symbol as IChar)!);
        }

        Assert.True("solid".SequenceEqual(symbols.Select(x => x.CharValue)));
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() => new SolidLineType().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() => new SolidLineType().ToString());
    }
}
