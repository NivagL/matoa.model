using matoa.model;

public class DocumentMeta : IModelMeta<Guid, Document>
{
  public Func<Document, Guid> Key { get; set; } = x => x.StreamId;

  public Action<Document, Document> Assign { get; set; } = (source, target) =>
  {
    source.FileStream = target.FileStream;
    source.Name = target.Name;
    source.FileType = target.FileType;
  };

  public Func<Document, Document, bool> Equal { get; set; } = (left, right) =>
  {
    return left.FileStream == right.FileStream
      && left.Name == right.Name
      && left.FileType == right.FileType;
  };
}
