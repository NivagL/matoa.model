namespace matoa.model;

public class ContactAddressMeta : IModelMeta<(int ContactId, int AddressId), ContactAddress>
{
  public (string Type, string Name)[] KeyNames
  {
    get
    {
      return [("int", "contactid"), ("int", "addressid")];
    }
  }

  private readonly IModelMeta<int, Address> _addressMeta;

  public Func<ContactAddress, (int ContactId, int AddressId)> Key { get; set; } = x => (x.ContactId, x.AddressId);
  public Action<ContactAddress, ContactAddress> Assign { get; set; }
  public Func<ContactAddress, ContactAddress, bool> Equal { get; set; }

  public ContactAddressMeta(IModelMeta<int, Address> addressMeta)
  {
    _addressMeta = addressMeta;

    Assign = (source, target) =>
    {
      source.AddressId = target.AddressId;
      source.ContactId = target.ContactId;
      if (target.Address != null)
      {
        source.Address = new Address();
        _addressMeta.Assign(source.Address, target.Address);
      }
    };

    Equal = (source, target) =>
    {
      return source.AddressId == target.AddressId
        && source.ContactId == target.ContactId;
    };
  }
}
