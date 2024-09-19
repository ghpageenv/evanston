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
            !string.IsNullOrWhiteSpace(dto.Description) ? dto.Description : new None(),
            dto.Phone != null ? Phone.From(dto.Phone) : new None(),
            dto.Address != null ? Address.From(dto.Address) : new None(),
            Uri.IsWellFormedUriString(dto.Website, UriKind.Absolute) ? new Uri(dto.Website) : new None(),
            !string.IsNullOrWhiteSpace(dto.Email) ? Email.From(dto.Email) : new None(),
            dto.ChiefExecutive != null ? dto.ChiefExecutive : new None(),
            !string.IsNullOrWhiteSpace(dto.TargetClient) ? dto.TargetClient : new None(),
            dto.Categories);
    }
}