// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Ratio expressed as a quotient of quantities.
/// </summary>
[IsoId("_WjNMUNp-Ed-ak6NoX_4Aeg_511377656")]
[DisplayName("Quantity To Quantity Ratio")]
public record QuantityToQuantityRatio2
{
    /// <summary>
    /// Numerator of the quotient of quantities.
    /// </summary>
    [IsoId("_WjNMUdp-Ed-ak6NoX_4Aeg_2126904066")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty1")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINDecimalNumber)]
    public required IsoRestrictedFINDecimalNumber Quantity1 { get; init; }

    /// <summary>
    /// Denominator of the quotient of quantities.
    /// </summary>
    [IsoId("_WjNMUtp-Ed-ak6NoX_4Aeg_-1402106980")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty2")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINDecimalNumber)]
    public required IsoRestrictedFINDecimalNumber Quantity2 { get; init; }
}
