using System.Text;

namespace Dotgem.Text;

/// <summary>
/// Extent the <see cref="StringBuilder"/>
/// </summary>
public static class StringBuilderExtention
{
    /// <summary>
    /// Append spaces to the <see cref="StringBuilder" />.
    /// </summary>
    /// <param name="builder">The <see cref="StringBuilder" />.</param>
    /// <param name="spaceCount">The amount of spaces.</param>
    /// <returns>The same <see cref="StringBuilder" />. Use it as a Fluent API.</returns>
    public static StringBuilder AppenSpace(this StringBuilder builder, int spaceCount)
    {
        for (int a = 0; a < spaceCount; a++)
        {
            builder.Append(' ');
        }
        return builder;
    }
}
