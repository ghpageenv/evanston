using OneOf;
using OneOf.Types;
using ValueOf;

namespace Evanston;

public class Address : ValueOf<string, Address> { }
public class Phone : ValueOf<string, Phone> { }

public record Business(
    string Name,
    string Description,
    OneOf<Phone, None> Phone,
    OneOf<Address, None> Address,
    OneOf<Uri, None> Website)
{
}