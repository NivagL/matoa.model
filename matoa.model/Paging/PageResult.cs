namespace matoa.model;

public class PageResult<TValue>
{
  public int? TotalResults { get; set; } = null;
  public int? TotalPages { get; set; } = null;
  public IEnumerable<TValue>? Results { get; set; } = null;
}
