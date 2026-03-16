// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Price expressed as an actual amount.
/// </summary>
[IsoId("_MZZGSZbSEee8S7xwGG7Veg")]
[DisplayName("Amount Price")]
public record AmountPrice6
{
    /// <summary>
    /// Type of amount price.
    /// </summary>
    [IsoId("_MZZGS5bSEee8S7xwGG7Veg")]
    [DisplayName("Amount Price Type")]
    [IsoXmlTag("AmtPricTp")]
    public required AmountPriceType3Code AmountPriceType { get; init; }

    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_MZZGSpbSEee8S7xwGG7Veg")]
    [DisplayName("Price Value")]
    [IsoXmlTag("PricVal")]
    public required ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; }
}
