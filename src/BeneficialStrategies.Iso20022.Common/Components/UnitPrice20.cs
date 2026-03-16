// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_DoJXEQgBEeSaceXTzyiZRg")]
[DisplayName("Unit Price")]
public record UnitPrice20
{
    /// <summary>
    /// Type of price.
    /// </summary>
    [IsoId("_Iz8tkQgBEeSaceXTzyiZRg")]
    [DisplayName("Price Type")]
    [IsoXmlTag("PricTp")]
    public required UnitPriceType2Choice_ PriceType { get; init; }

    /// <summary>
    /// Value of the price, that is, as a currency and value.
    /// </summary>
    [IsoId("_EDeoOQgBEeSaceXTzyiZRg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceValue1 Value { get; init; }

    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_EDeoOwgBEeSaceXTzyiZRg")]
    [DisplayName("Price Method")]
    [IsoXmlTag("PricMtd")]
    public PriceMethod1Code? PriceMethod { get; init; }
}
