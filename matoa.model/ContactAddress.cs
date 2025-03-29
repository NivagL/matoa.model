namespace matoa.model;

public class ContactAddress
{
  public int ContactId { get; set; }
  public int AddressId { get; set; }
  public Address? Address { get; set; } = null;
}
