namespace Dotgem.Text;

public partial class Filler : IFiller
{
    /// <inheritdoc />
    public Span<char> GetSpace(int count)
    {
        Span<char> space = new char[count];
        for (int a = 0; a < space.Length; a++)
        {
            space[a] = ' ';
        }
        return space;
    }

    /// <inheritdoc />
    public Span<char> GetTabsWithSpaceFill(int spaceCount)
    {
        int tabs = spaceCount / 4;
        int spaces = spaceCount % 4;
        Span<char> result = new char[tabs + spaces];
        for (int a = 0; a < tabs; a++)
        {
            result[a] = '\t';
        }
        for (int a = tabs; a < tabs + spaces; a++)
        {
            result[a] = ' ';
        }
        return result;
    }

    /// <inheritdoc />
    public string EnsureMinLengthFillWithSpace(string value, int minLength) =>
        EnsureMinLengthFillWith(value, ' ', minLength);

    /// <inheritdoc />
    public string EnsureMinLengthFillWith(string value, char fill, int minLength)
    {
        if (value.Length >= minLength)
        {
            return value;
        }

        ReadOnlySpan<char> valueSpan = value;
        int biggerValue = valueSpan.Length > minLength ? valueSpan.Length : minLength;
        Span<char> result = new char[biggerValue];

        for (int a = 0; a < valueSpan.Length; a++)
        {
            result[a] = valueSpan[a];
        }

        for (int a = valueSpan.Length; a < result.Length; a++)
        {
            result[a] = fill;
        }

        return result.ToString();
    }

    /// <inheritdoc />
    public string EnsureExactLength(string value, char fill, int length)
    {
        if (value.Length >= length)
        {
            return value[..length];
        }

        return EnsureMinLengthFillWith(value, fill, length);
    }
}
