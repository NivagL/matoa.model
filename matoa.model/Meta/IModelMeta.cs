namespace matoa.model;

public interface IModelMeta<TKey, TValue>
{
    /// <summary>
    /// Gets the key names and their types for the entity.
    /// </summary>
    public (string Type, string Name)[] KeyNames { get { return new[] { ("int", "id") }; } }

    /// <summary>
    /// A function to retrieve the key from an entity.
    /// </summary>
    Func<TValue, TKey> Key { get; set; }

    /// <summary>
    /// An action to assign values from one entity to another.
    /// </summary>
    Action<TValue, TValue> Assign { get; set; }

    /// <summary>
    /// A function to compare two entities for equality.
    /// </summary>
    Func<TValue, TValue, bool> Equal { get; set; }
}
