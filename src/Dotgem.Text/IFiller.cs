namespace Dotgem.Text;

public interface IFiller
{
    /// <summary>
    /// Create a array of space characters.
    /// </summary>
    /// <param name="count">The amount of space characters.</param>
    /// <returns>The space characters.</returns>
    Span<char> GetSpace(int count);

    /// <summary>
    /// Create a array of tabs and 0-3 spaces at the end if needed.
    /// </summary>
    /// <param name="count">The amount of space. 4 space = 1 tab.</param>
    /// <returns>The tab and space characters.</returns>
    Span<char> GetTabsWithSpaceFill(int count);

    /// <summary>
    /// Fills a string with space characters if it's lengths is smaller than <see href="minLength"/>.
    /// </summary>
    /// <param name="value">The value which is tested and may filled.</param>
    /// <param name="minLength">The minimum required amout of characters in the string.</param>
    /// <returns>The string with the specified <see href="minLength"/>.</returns>
    string EnsureMinLengthFillWithSpace(string value, int minLength);

    /// <summary>
    /// Fills a string with the <see href="fill"/> of it's lengths is smaller than <see href="minLength"/>.
    /// </summary>
    /// <param name="value">The value which is tested and may filled.</param>
    /// <param name="fill">The character to fill it with.</param>
    /// <param name="minLength">The minimum required amout of characters in the string.</param>
    /// <returns>The string with the specified <see href="minLength"/>.</returns>
    string EnsureMinLengthFillWith(string value, char fill, int minLength);

    /// <summary>
    /// Create a string with the exact <see href="length"/>, cuts too long values and fill it with the <see href="fill"/>.
    /// </summary>
    /// <param name="value">The value which is tested and may filled or cut.</param>
    /// <param name="fill">The fill for too short values.</param>
    /// <param name="length">The exact length of the result.</param>
    /// <returns>The string with the specified <see href="length"/>.</returns>
    string EnsureExactLength(string value, char fill, int length);
}
