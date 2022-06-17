namespace Dotgem;

/// <summary>
/// Defines a builder class.
/// </summary>
/// <typeparam name="TProduct">The object type builded by the builder.</typeparam>
public interface IBuilder<TProduct>
{
    /// <summary>
    /// Building the object.
    /// </summary>
    /// <returns>The builded object.</returns>
    TProduct Build();
}