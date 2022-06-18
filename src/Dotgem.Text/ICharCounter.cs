namespace Dotgem.Text;

public interface ICharCounter
{
    /// <summary>
    /// Count's the leading space and tab characters at the beginning.
    /// Stop's counting at the first non space or tab character.
    /// 
    /// 1 tab   -> 4 space
    /// 1 space -> +1 result
    /// </summary>
    /// <param name="chars">The value for counting the characters.</param>
    /// <returns>The amount of space at the beginning of a space. 1 tab -> 4 spaces.</returns>
    int GetLeadingSpaceCount(ReadOnlySpan<char> chars);
}
