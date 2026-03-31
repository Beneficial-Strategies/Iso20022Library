// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party to which the TaxReport is delivered. This message block contains party details for a specific tax authority.
/// </summary>
[IsoId("_-WIBwEkGEeaOe8w0NJ11wQ")]
[DisplayName("Tax Organisation Identification")]
public record TaxOrganisationIdentification1
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_MhcQ8EkHEeaOe8w0NJ11wQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Name { get; init; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_vamoMEkHEeaOe8w0NJ11wQ")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress6? PostalAddress { get; init; }

    /// <summary>
    /// Set of elements used to indicate how to contact the party.
    /// </summary>
    [IsoId("_7lpBsEkHEeaOe8w0NJ11wQ")]
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    public ContactDetails2? ContactDetails { get; init; }
}
