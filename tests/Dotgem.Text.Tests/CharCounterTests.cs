namespace Dotgem.Text.Tests;

public class CharCounterTests
{
    [Fact]
    public void GetLeadingSpaceCount()
    {
        ICharCounter charCounter = new CharCounter();

        List<(string Value, int Actual)> Values = new()
        {
            ("", 0),
            ("d", 0),
            ("d ", 0),
            (" d", 1),
            (" d ", 1),
            ("  d ", 2),
            ("\t", 4),
            ("\t ", 5),
            (" \t ", 6),
            ("\td", 4),
            ("\t d", 5),
            (" \t d", 6),
            ("\t \t d", 10),
        };

        foreach (var (value, expected) in Values)
        {
            var actual = charCounter.GetLeadingSpaceCount(value);
            Assert.Equal(expected, actual);
        }
    }
}