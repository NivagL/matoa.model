using System.Reflection;

namespace matoa.model;

public static class TupleHelper
{
  public static string[] GetStringValues<T>(T item)
  {

    if (item is null)
    {
      return new string[] { };
    }

    Type t = typeof(T);

    if (t is null)
    {
      return new string[] { };
    }

    if (t.FullName is not null && t.FullName.StartsWith("System.ValueTuple"))
    {
      // ValueTuples store their data in fields named Item1, Item2, etc.
      var fields = t.GetFields(BindingFlags.Public | BindingFlags.Instance);
      return fields.Select(f => f.GetValue(item)?.ToString() ?? string.Empty).ToArray();
    }

    // Check if it's a System.Tuple<...>
    if (t.Namespace == "System" && t.Name.StartsWith("Tuple"))
    {
      // Tuples store their data in properties named Item1, Item2, etc.
      var props = t.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.Name.StartsWith("Item"));
      return props.Select(p => p.GetValue(item)?.ToString() ?? string.Empty)
        .Where(x => !string.IsNullOrEmpty(x)).ToArray();
    }

    // If not a tuple, just return the single value
    return new[] { item.ToString() ?? string.Empty };
  }
}
