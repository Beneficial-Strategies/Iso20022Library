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
[IsoId("_U4XbJNp-Ed-ak6NoX_4Aeg_-1749119969")]
[DisplayName("Unit Price")]
public record UnitPrice1
{
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_U4XbJdp-Ed-ak6NoX_4Aeg_-1749119968")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice2Code Type { get; init; }

    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_U4XbJtp-Ed-ak6NoX_4Aeg_-1749119967")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceValue1 Value { get; init; }

    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_U4XbJ9p-Ed-ak6NoX_4Aeg_225497879")]
    [DisplayName("Price Method")]
    [IsoXmlTag("PricMtd")]
    public PriceMethod1Code? PriceMethod { get; init; }
}
