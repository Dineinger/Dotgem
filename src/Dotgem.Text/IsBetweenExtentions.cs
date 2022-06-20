namespace Dotgem.Text;

public static class IsBetweenExtentions
{
    /// <summary>
    /// Determins if a char is between 2 other chars.
    /// </summary>
    /// <param name="self">The char which is checked.</param>
    /// <param name="from">The smaller value.</param>
    /// <param name="to">The bigger value.</param>
    /// <returns>true if the value is in between, otherwise false.</returns>
    public static bool IsBetween(this char self, char from, char to)
    {
        return self >= from && self <= to;
    }

    /// <summary>
    /// Determins if a char is between 2 integers.
    /// </summary>
    /// <param name="self">The char which is checked.</param>
    /// <param name="from">The smaller value.</param>
    /// <param name="to">The bigger value.</param>
    /// <returns>true if the value is in between, otherwise false.</returns>
    public static bool IsBetween(this char self, int from, int to)
    {
        return self >= from && self <= to;
    }

    /// <summary>
    /// Determins if a integer is between 2 other integers.
    /// </summary>
    /// <param name="self">The int which is checked.</param>
    /// <param name="from">The smaller value.</param>
    /// <param name="to">The bigger value.</param>
    /// <returns>true if the value is in between, otherwise false.</returns>
    public static bool IsBetween(this int self, int from, int to)
    {
        return self >= from && self <= to;
    }
}
