// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Source of a price quotation when it is not the local market.
/// </summary>
[IsoId("_Qebmfdp-Ed-ak6NoX_4Aeg_-24723485")]
[DisplayName("Price Source")]
public record PriceSource
{
    /// <summary>
    /// Source of the price.
    /// </summary>
    [IsoXmlTag("PricSrc")]
    public required PriceSource1Code Value { get; init; }

    /// <summary>
    /// Additional information about the source of a price.
    /// </summary>
    [IsoId("_QelXcdp-Ed-ak6NoX_4Aeg_404714109")]
    [DisplayName("Narrative")]
    [IsoXmlTag("Nrrtv")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Narrative { get; init; }
}
