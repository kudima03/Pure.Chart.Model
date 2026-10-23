using System.Collections;
using Pure.Primitives.Abstractions.Char;
using Pure.Primitives.Abstractions.String;
using Char = Pure.Primitives.Char.Char;

namespace Pure.Chart.Model;

public sealed record DottedLineType : IString
{
    public string TextValue => "dotted";

    public IEnumerator<IChar> GetEnumerator()
    {
        return TextValue.Select(symbol => new Char(symbol)).GetEnumerator();
    }

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
