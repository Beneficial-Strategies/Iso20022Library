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
[IsoId("_PZJZa9p-Ed-ak6NoX_4Aeg_-1506311102")]
[DisplayName("Alternate Party Identification")]
public record AlternatePartyIdentification2
{
    /// <summary>
    /// Specifies the type of alternate identification of the party identified.
    /// </summary>
    [IsoId("_PZJZbNp-Ed-ak6NoX_4Aeg_1894769807")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public required IdentificationType4Choice_ IdentificationType { get; init; }

    /// <summary>
    /// Country in which a person resides (the place of a person&apos;s home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    [IsoId("_PZJZbdp-Ed-ak6NoX_4Aeg_-933048726")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_PZSjUNp-Ed-ak6NoX_4Aeg_719578782")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text AlternateIdentification { get; init; }
}
