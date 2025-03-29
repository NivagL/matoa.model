using matoa.model;

public class ImageFileMeta : IModelMeta<Guid, ImageFile>
{
  public (string Type, string Name)[] KeyNames { get { return [("Guid", "streamid")]; } }
  public Func<ImageFile, Guid> Key { get; set; } = x => x.StreamId;

  public Action<ImageFile, ImageFile> Assign { get; set; } = (source, target) =>
  {
    source.FileStream = target.FileStream;
    source.Name = target.Name;
    source.FileType = target.FileType;
  };

  public Func<ImageFile, ImageFile, bool> Equal { get; set; } = (left, right) =>
  {
    return left.FileStream == right.FileStream
      && left.Name == right.Name
      && left.FileType == right.FileType;
  };
}
