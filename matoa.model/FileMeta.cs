using matoa.model;

public class FileMeta : IModelMeta<Guid, matoa.model.File>
{
  public Func<matoa.model.File, Guid> Key { get; set; } = x => x.StreamId;

  public Action<matoa.model.File, matoa.model.File> Assign { get; set; } = (source, target) =>
  {
    source.FileStream = target.FileStream;
    source.Name = target.Name;
    source.FileType = target.FileType;
  };

  public Func<matoa.model.File, matoa.model.File, bool> Equal { get; set; } = (left, right) =>
  {
    return left.FileStream == right.FileStream
      && left.Name == right.Name
      && left.FileType == right.FileType;
  };
}
