using Common.Model;
using TypeGen.Core.SpecGeneration;
namespace Matoa.Model;

public class TypescriptExportSpec : GenerationSpec
{
  public TypescriptExportSpec()
  {
    AddInterface<IHasImage>()
      .Member("ImageId").Null().DefaultValue("null")
      .Member("ImageUrl").Null().DefaultValue("null");

    AddClass<User>()
      .Member("ContactId").Null().DefaultValue("null")
      .Member("Contact").Null().DefaultValue("null")
      .Member("UserRoles").DefaultValue("[]");

    AddClass<Role>()
      .Member("UserRoles").DefaultValue("[]");

    AddClass<UserRole>()
      .Member("User").Null().DefaultValue("null")
      .Member("Role").Null().DefaultValue("null");

    AddClass<Registration>()
      .Member("Created").DefaultValue("new Date()")
      .Member("MiddleNames").Null().DefaultValue("null")
      .Member("DateOfBirth").Null().DefaultValue("null")
      .Member("Phone").Null().DefaultValue("null")
      .Member("Geneology").Null().DefaultValue("null")
      .Member("UserId").Null().DefaultValue("null")
      .Member("User").Null().DefaultValue("null")
      .Member("ContactId").Null().DefaultValue("null")
      .Member("Contact").Null().DefaultValue("null")
      .Member("ImageId").Null().DefaultValue("null")
      .Member("ImageUrl").Null().DefaultValue("null");

    AddClass<LoginResponse>()
      .Member("LoggedIn").Null().DefaultValue("new Date()")
      .Member("Expires").Null().DefaultValue("new Date()")
      .Member("LoggedOut").Null().DefaultValue("new Date()")
      .Member("User").Null().DefaultValue("null");

    AddClass<Block>()
      .Member("District").Null().DefaultValue("null")
      .Member("Plan").Null().DefaultValue("null")
      .Member("Reference").Null().DefaultValue("null")
      .Member("Shares").Null().DefaultValue("null")
      .Member("Meters").Null().DefaultValue("null")
      .Member("Acres").Null().DefaultValue("null")
      .Member("ImageId").Null().DefaultValue("null")
      .Member("ImageUrl").Null().DefaultValue("null");

    AddClass<BlockContact>()
      .Member("Block").Null().DefaultValue("null")
      .Member("Contact").Null().DefaultValue("null");

    AddClass<BlockOrganisation>()
      .Member("Block").Null().DefaultValue("null")
      .Member("Organisation").Null().DefaultValue("null");

    AddClass<Organisation>()
      .Member("Name").DefaultValue("''")
      .Member("Type").DefaultValue("''")
      .Member("District").Null().DefaultValue("null")
      .Member("Region").Null().DefaultValue("null")
      .Member("Purpose").Null().DefaultValue("null")
      .Member("ImageId").Null().DefaultValue("null")
      .Member("ImageUrl").Null().DefaultValue("null");

    AddClass<OrganisationContact>()
      .Member("Organisation").Null().DefaultValue("null")
      .Member("Contact").Null().DefaultValue("null");

    AddClass<Person>();
    AddClass<BlockOwnership>()
      .Member("Block").DefaultValue("new Block()");

    AddClass<UserSetting>()
      .Member("User").Null().DefaultValue("null")
      .Member("Key").DefaultValue("''")
      .Member("Value").DefaultValue("''");
    AddEnum<RoleEnum>();

    AddClass<Address>()
      .Member("Lng").DefaultValue("-35.2138378")
      .Member("Lat").DefaultValue("173.8806516")
      .Member("FullAddress").Ignore();

    AddClass<Contact>()
      .Member("Title").Null().DefaultValue("null")
      .Member("MiddleNames").Null().DefaultValue("null")
      .Member("AlternateName").Null().DefaultValue("null")
      .Member("DateOfBirth").Null().DefaultValue("null")
      .Member("DateOfDeath").Null().DefaultValue("null")
      .Member("EMail").Null().DefaultValue("null")
      .Member("Phone").Null().DefaultValue("null")
      .Member("Geneology").Null().DefaultValue("null")
      .Member("ImageId").Null().DefaultValue("null")
      .Member("ImageUrl").Null().DefaultValue("null")
      .Member("FullName").Ignore();

    AddClass<ContactAddress>()
      .Member("Address").Null().DefaultValue("null");

    AddClass<Event>()
      .Member("EventTypeId").Null().DefaultValue("null")
      .Member("EventType").Null().DefaultValue("null")
      .Member("OrganiserId").Null().DefaultValue("null")
      .Member("Organiser").Null().DefaultValue("null")
      .Member("LocationId").Null().DefaultValue("null")
      .Member("Location").Null().DefaultValue("null")
      .Member("EventStart").Null().DefaultValue("null")
      .Member("EventEnd").Null().DefaultValue("null")
      .Member("ImageId").Null().DefaultValue("null")
      .Member("ImageUrl").Null().DefaultValue("null");

    AddClass<EventType>();
    AddEnum<EventTypeEnum>();

    AddClass<EventAttendee>()
      .Member("Event").Null().DefaultValue("null")
      .Member("Contact").Null().DefaultValue("null");

    AddClass<Location>()
      .Member("LocationType").DefaultValue("new LocationType()")
      .Member("Address").Null().DefaultValue("null")
      .Member("ImageId").Null().DefaultValue("null")
      .Member("ImageUrl").Null().DefaultValue("null");

    AddClass<LocationContact>()
      .Member("Location").Null().DefaultValue("null")
      .Member("Contact").Null().DefaultValue("null");

    AddClass<LocationType>();
    AddEnum<LocationTypeEnum>();

    AddClass<PageDetail>();
    AddClass<PageResult<Object>>()
      .Member("Results").DefaultValue("[]");

    AddClass<QueryValue>();
    AddClass<PageQuery>()
      .Member("PageDetail").DefaultValue("new PageDetail()")
      .Member("Query").DefaultValue("[]");

    AddClass<DocumentInfo>()
      .Member("User").Null().DefaultValue("null")
      .Member("DateCreated").Null().DefaultValue("null");

    AddClass<AccountInfo>()
      .Member("User").Null().DefaultValue("null");

    AddClass<ChatThread>();
    AddClass<UserChat>()
      .Member("User").Null().DefaultValue("null")
      .Member("ChatThread").Null().DefaultValue("null")
      .Member("DateTime").Null().DefaultValue("null");

    AddClass<UserError>()
      .Member("User").Null().DefaultValue("null")
      .Member("Error").Null().DefaultValue("null")
      .Member("Severity").Null().DefaultValue("-1");

    AddClass<UserPost>()
      .Member("User").Null().DefaultValue("null");

    AddClass<ImageFile>()
      .Member("FileStream").DefaultValue("[]")
      .Member("User").Null().DefaultValue("null");

    AddClass<PageText>();
  }
}
