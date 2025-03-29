namespace matoa.model;

public class PageQuery
{
  public PageDetail PageDetail { get; set; } = new PageDetail();
  public List<QueryValue> Query { get; set; } = new List<QueryValue>();
}
