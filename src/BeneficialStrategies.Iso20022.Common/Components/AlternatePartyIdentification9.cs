// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Alternate identification for a party using an identification type, a country code and a text field.
/// </summary>
[IsoId("_chc-7ZKQEeWHWpTQn1FFVg")]
[DisplayName("Alternate Party Identification")]
public record AlternatePartyIdentification9
{
    /// <summary>
    /// Specifies the type of alternate identification of the party identified.
    /// </summary>
    [IsoId("_chc-75KQEeWHWpTQn1FFVg")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public required IdentificationType44Choice_ IdentificationType { get; init; }

    /// <summary>
    /// Country in which a person resides (the place of a person&apos;s home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    [IsoId("_chc-95KQEeWHWpTQn1FFVg")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_chc-_5KQEeWHWpTQn1FFVg")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax30Text)]
    [StringLength(maximumLength: 30, MinimumLength = 1)]
    public required IsoRestrictedFINXMax30Text AlternateIdentification { get; init; }
}
