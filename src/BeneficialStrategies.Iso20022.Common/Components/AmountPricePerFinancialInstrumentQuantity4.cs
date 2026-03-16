// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a ratio: amount price per financial instrument quantity.
/// </summary>
[IsoId("_Wi6RaNp-Ed-ak6NoX_4Aeg_-379253793")]
[DisplayName("Amount Price Per Financial Instrument Quantity")]
public record AmountPricePerFinancialInstrumentQuantity4
{
    /// <summary>
    /// Type of amount price.
    /// </summary>
    [IsoId("_WjDbUNp-Ed-ak6NoX_4Aeg_613105185")]
    [DisplayName("Amount Price Type")]
    [IsoXmlTag("AmtPricTp")]
    public required AmountPriceType1Code AmountPriceType { get; init; }

    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_WjDbUdp-Ed-ak6NoX_4Aeg_-1381039521")]
    [DisplayName("Price Value")]
    [IsoXmlTag("PricVal")]
    public required RestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; init; }

    /// <summary>
    /// Quantity of financial instrument.
    /// </summary>
    [IsoId("_WjDbUtp-Ed-ak6NoX_4Aeg_1787125323")]
    [DisplayName("Financial Instrument Quantity")]
    [IsoXmlTag("FinInstrmQty")]
    public required FinancialInstrumentQuantity15Choice_ FinancialInstrumentQuantity { get; init; }
}
