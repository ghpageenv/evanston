using OneOf;
using OneOf.Types;
using ValueOf;

namespace Evanston;

public class Address : ValueOf<string, Address> { }
public class Phone : ValueOf<string, Phone> { }
public class Email : ValueOf<string, Email> { }

public record Business(
    string Name,
    OneOf<string, None> Description,
    OneOf<Phone, None> Phone,
    OneOf<Address, None> Address,
    OneOf<Uri, None> Website,
    OneOf<Email, None> Email,
    OneOf<string, None> ChiefExecutive,
    OneOf<string, None> TargetClient,
    OneOf<string, None> Anchor,
    BusinessCategory[] Categories)
{
}