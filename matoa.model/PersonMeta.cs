using matoa.model;

public class PersonMeta : IModelMeta<int, Person>
{
  public Func<Person, int> Key { get; set; } = x => x.Id;

  public Action<Person, Person> Assign { get; set; } = (source, target) =>
  {
    source.Name = target.Name;
  };

  public Func<Person, Person, bool> Equal { get; set; } = (left, right) =>
  {
    return left.Name == right.Name;
  };
}
