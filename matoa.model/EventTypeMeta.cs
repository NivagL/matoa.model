using Common.Model;
namespace Matoa.Model;

public class EventTypeMeta : IModelMeta<int, EventType>
{
  public Func<EventType, int> Key { get; set; } = et => et.Id;

  public Action<EventType, EventType> Assign { get; set; } = (source, target) =>
  {
    source.Name = target.Name;
  };

  public Func<EventType, EventType, bool> Equal { get; set; } = (left, right) =>
  {
    return left.Name == right.Name;
  };
}
