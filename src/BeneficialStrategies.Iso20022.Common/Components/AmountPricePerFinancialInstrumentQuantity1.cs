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
[IsoId("_QbAfBtp-Ed-ak6NoX_4Aeg_-1640515139")]
[DisplayName("Amount Price Per Financial Instrument Quantity")]
public record AmountPricePerFinancialInstrumentQuantity1
{
    /// <summary>
    /// Type of amount price.
    /// </summary>
    [IsoId("_QbAfB9p-Ed-ak6NoX_4Aeg_-1342218248")]
    [DisplayName("Amount Price Type")]
    [IsoXmlTag("AmtPricTp")]
    public required AmountPriceType1FormatChoice_ AmountPriceType { get; init; }

    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_QbJo8Np-Ed-ak6NoX_4Aeg_-1342218247")]
    [DisplayName("Price Value")]
    [IsoXmlTag("PricVal")]
    public required ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; }

    /// <summary>
    /// Quantity of financial instrument.
    /// </summary>
    [IsoId("_QbJo8dp-Ed-ak6NoX_4Aeg_-1312665173")]
    [DisplayName("Financial Instrument Quantity")]
    [IsoXmlTag("FinInstrmQty")]
    public required UnitOrFaceAmount1Choice_ FinancialInstrumentQuantity { get; init; }
}
