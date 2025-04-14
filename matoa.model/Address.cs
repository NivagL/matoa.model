namespace Matoa.Model;

public class Address
{
  public int Id { get; set; }
  public string Line1 { get; set; } = string.Empty;
  public string? Line2 { get; set; } = null;
  public string City { get; set; } = string.Empty;
  public string? Suburb { get; set; } = null;
  public string? Region { get; set; } = null;
  public string? Postcode { get; set; } = null;
  public string Country { get; set; } = "New Zealand";
  public string FullAddress { get { return $"{Line1} {City} {Suburb} {Region}"; } }
  public double Lat { get; set; } = 0.0;
  public double Lng { get; set; } = 0.0;
}
