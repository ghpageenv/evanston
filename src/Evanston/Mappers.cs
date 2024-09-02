using Riok.Mapperly.Abstractions;
using OneOf.Types;

namespace Evanston;

[Mapper]
public partial class Mappers
{
    public Business BusinessDtoToModel(BusinessDto dto)
    {
        return new(
            dto.Name,
            dto.Description,
            dto.Phone != null ? Phone.From(dto.Phone) : new None(),
            dto.Address != null ? Address.From(dto.Address) : new None(),
            !string.IsNullOrWhiteSpace(dto.Email) ? Email.From(dto.Email) : new None(),
            dto.ChiefExecutive != null ? dto.ChiefExecutive : new None());
    }
}