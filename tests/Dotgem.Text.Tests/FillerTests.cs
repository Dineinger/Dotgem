namespace Dotgem.Text.Tests;

public class FillerTests
{
    [Fact]
    public void GetSpace()
    {
        IFiller filler = new Filler();

        List<(int Value, string Expected)> values = new()
        {
            (0, ""),
            (1, " "),
            (2, "  "),
            (3, "   "),
            (4, "    "),
            (10, "          "),
        };

        foreach (var (value, expected) in values)
        {
            var actual = filler.GetSpace(value).ToString();
            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void GetTabsWithSpaceFill()
    {
        IFiller filler = new Filler();

        List<(int Value, string Expected)> values = new()
        {
            (0, ""),
            (1, " "),
            (2, "  "),
            (3, "   "),
            (4, "\t"),
            (5, "\t "),
            (7, "\t   "),
            (10, "\t\t  "),
        };

        foreach (var (value, expected) in values)
        {
            var actual = filler.GetTabsWithSpaceFill(value).ToString();
            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void EnsureMinLengthFillWithSpace()
    {
        IFiller filler = new Filler();

        List<((string Value, int MinLength) Value, string Expected)> values = new()
        {
            (("", 0), ""),
            (("", 1), " "),
            (("", 2), "  "),
            (("", 3), "   "),
            ((" ", 0), " "),
            ((" ", 1), " "),
            ((" ", 2), "  "),
            ((" ", 3), "   "),
            (("  ", 0), "  "),
            (("  ", 1), "  "),
            (("  ", 2), "  "),
            (("  ", 3), "   "),
            (("  Text", 3), "  Text"),
            (("  Text", 10), "  Text    "),
        };

        foreach (var (Value, Expected) in values)
        {
            var actual = filler.EnsureMinLengthFillWithSpace(Value.Value, Value.MinLength);
            Assert.Equal(Expected, actual);
        }
    }

    [Fact]
    public void EnsureMinLengthFillWith()
    {
        IFiller filler = new Filler();

        List<((string Value, int MinLength) Value, string Expected)> values = new()
        {
            (("", 0), ""),
            (("", 1), "#"),
            (("", 2), "##"),
            (("", 3), "###"),
            ((" ", 0), " "),
            ((" ", 1), " "),
            ((" ", 2), " #"),
            ((" ", 3), " ##"),
            (("  ", 0), "  "),
            (("  ", 1), "  "),
            (("  ", 2), "  "),
            (("  ", 3), "  #"),
            (("  Text", 3), "  Text"),
            (("  Text", 10), "  Text####"),
        };

        foreach (var (Value, Expected) in values)
        {
            var actual = filler.EnsureMinLengthFillWith(Value.Value, '#', Value.MinLength);
            Assert.Equal(Expected, actual);
        }
    }

    [Fact]
    public void EnsureExactLength()
    {
        IFiller filler = new Filler();

        List<((string Value, int Length) Value, string Expected)> values = new()
        {
            (("", 0), ""),
            (("", 1), "#"),
            (("", 2), "##"),
            (("", 3), "###"),
            ((" ", 0), ""),
            ((" ", 1), " "),
            ((" ", 2), " #"),
            ((" ", 3), " ##"),
            (("  ", 0), ""),
            (("  ", 1), " "),
            (("  ", 2), "  "),
            (("  ", 3), "  #"),
            (("  Text", 3), "  T"),
            (("  Text", 10), "  Text####"),
        };

        foreach (var (Value, Expected) in values)
        {
            var actual = filler.EnsureExactLength(Value.Value, '#', Value.Length);
            Assert.Equal(Expected, actual);
        }
    }
}
