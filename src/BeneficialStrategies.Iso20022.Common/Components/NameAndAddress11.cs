// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a party.
/// </summary>
[IsoId("_WKw3LNp-Ed-ak6NoX_4Aeg_1542098084")]
[DisplayName("Name And Address")]
public record NameAndAddress11
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_WK6oINp-Ed-ak6NoX_4Aeg_1542098115")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoRestrictedFINMax35Text Name { get; init; }

    /// <summary>
    /// Postal address of a party.
    /// </summary>
    [IsoId("_WK6oIdp-Ed-ak6NoX_4Aeg_1542098487")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public PostalAddress7? Address { get; init; }
}
