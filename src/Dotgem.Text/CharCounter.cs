namespace Dotgem.Text;

public class CharCounter : ICharCounter
{
    /// <inheritdoc />
    public int GetLeadingSpaceCount(ReadOnlySpan<char> value)
    {
        int spaceCount = 0;
        for (int a = 0; a < value.Length; a++)
        {
            switch (value[a])
            {
                case ' ': spaceCount++; continue;
                case '\t': spaceCount += 4; continue;
                default: return spaceCount;
            }
        }
        return spaceCount;
    }
}
