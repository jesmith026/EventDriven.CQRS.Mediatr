using System.Diagnostics.CodeAnalysis;

namespace Common.Integration.Models
{
    [ExcludeFromCodeCoverage]
    public record Address(string Street, string City, string State, string Country, string PostalCode);
}