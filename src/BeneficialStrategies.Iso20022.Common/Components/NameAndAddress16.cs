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
[IsoId("_9MDku24-EeiU9cctagi5ow")]
[DisplayName("Name And Address")]
public record NameAndAddress16
{
    /// <summary>
    /// Name by which a party is known and is usually used to identify that party.
    /// </summary>
    [IsoId("_9XYD424-EeiU9cctagi5ow")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Name { get; init; }

    /// <summary>
    /// Postal address of a party.
    /// </summary>
    [IsoId("_9XYD5W4-EeiU9cctagi5ow")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public required PostalAddress24 Address { get; init; }
}
