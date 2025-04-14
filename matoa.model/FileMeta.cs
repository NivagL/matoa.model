using Common.Model;
namespace Matoa.Model;

public class FileMeta : IModelMeta<Guid, Matoa.Model.File>
{
  public Func<Matoa.Model.File, Guid> Key { get; set; } = x => x.StreamId;

  public Action<Matoa.Model.File, Matoa.Model.File> Assign { get; set; } = (source, target) =>
  {
    source.FileStream = target.FileStream;
    source.Name = target.Name;
    source.FileType = target.FileType;
  };

  public Func<Matoa.Model.File, Matoa.Model.File, bool> Equal { get; set; } = (left, right) =>
  {
    return left.FileStream == right.FileStream
      && left.Name == right.Name
      && left.FileType == right.FileType;
  };
}
