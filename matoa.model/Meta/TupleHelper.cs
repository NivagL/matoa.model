using System.Reflection;

namespace matoa.model;

public static class TupleHelper
{
  public static string[] GetStringValues<TKey>(TKey key)
  {
    if (key == null)
    {
      return new[] { string.Empty };
    }

    Type t = typeof(TKey);

    // Check if it's a System.ValueTuple<...>
    if (t.IsGenericType && t.FullName is not null && t.FullName.StartsWith("System.ValueTuple"))
    {
      // ValueTuples store their data in fields named Item1, Item2, etc.
      var fields = t.GetFields(BindingFlags.Public | BindingFlags.Instance);
      return fields.Select(f => f.GetValue(key)?.ToString() ?? string.Empty).ToArray();
    }

    // Check if it's a System.Tuple<...>
    if (t.IsGenericType && t.Namespace == "System" && t.Name.StartsWith("Tuple"))
    {
      // Tuples store their data in properties named Item1, Item2, etc.
      var props = t.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                   .Where(p => p.Name.StartsWith("Item"));
      return props.Select(p => p.GetValue(key)?.ToString() ?? string.Empty).ToArray();
    }

    // If not a tuple, just return the single value
    return new[] { key.ToString() ?? string.Empty };
  }
}
