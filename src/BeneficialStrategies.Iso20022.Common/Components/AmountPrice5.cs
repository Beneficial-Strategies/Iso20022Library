// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Price expressed as an amount.
/// </summary>
[IsoId("_Wi6RZdp-Ed-ak6NoX_4Aeg_-2041286606")]
[DisplayName("Amount Price")]
public record AmountPrice5
{
    /// <summary>
    /// Type of amount price.
    /// </summary>
    [IsoId("_Wi6RZtp-Ed-ak6NoX_4Aeg_259535984")]
    [DisplayName("Amount Price Type")]
    [IsoXmlTag("AmtPricTp")]
    public required AmountPriceType1Code AmountPriceType { get; init; }

    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_Wi6RZ9p-Ed-ak6NoX_4Aeg_-1734608722")]
    [DisplayName("Price Value")]
    [IsoXmlTag("PricVal")]
    public required RestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; init; }
}
