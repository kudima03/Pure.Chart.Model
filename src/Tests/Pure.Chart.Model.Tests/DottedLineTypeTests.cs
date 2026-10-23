using System.Collections;
using Pure.Primitives.Abstractions.Char;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.Model.Tests;

public sealed record DottedLineTypeTests
{
    [Fact]
    public void ProduceCorrectTextValue()
    {
        IString lineType = new DottedLineType();

        Assert.Equal("dotted", lineType.TextValue);
    }

    [Fact]
    public void EnumeratesAsTyped()
    {
        IEnumerable<IChar> lineType = new DottedLineType();

        Assert.True("dotted".SequenceEqual(lineType.Select(x => x.CharValue)));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IEnumerable lineType = new DottedLineType();

        ICollection<IChar> symbols = [];

        foreach (object symbol in lineType)
        {
            symbols.Add((symbol as IChar)!);
        }

        Assert.True("dotted".SequenceEqual(symbols.Select(x => x.CharValue)));
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() =>
            new DottedLineType().GetHashCode()
        );
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() => new DottedLineType().ToString());
    }
}
