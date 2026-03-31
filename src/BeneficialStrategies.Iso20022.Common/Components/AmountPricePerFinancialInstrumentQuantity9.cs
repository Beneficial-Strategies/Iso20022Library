// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a ratio: amount price and price fixing date per financial instrument quantity.
/// </summary>
[IsoId("_zuw0oTpyEemk2e6qGBk8IQ")]
[DisplayName("Amount Price Per Financial Instrument Quantity")]
public record AmountPricePerFinancialInstrumentQuantity9
{
    /// <summary>
    /// Type of amount price.
    /// </summary>
    [IsoId("_z5pO8TpyEemk2e6qGBk8IQ")]
    [DisplayName("Amount Price Type")]
    [IsoXmlTag("AmtPricTp")]
    public required YieldedOrValueType1Choice_ AmountPriceType { get; init; }

    /// <summary>
    /// Value given to a price.
    /// </summary>
    [IsoId("_z5pO-TpyEemk2e6qGBk8IQ")]
    [DisplayName("Price Value")]
    [IsoXmlTag("PricVal")]
    public required PriceRateOrAmount3Choice_ PriceValue { get; init; }

    /// <summary>
    /// Quantity of financial instrument.
    /// </summary>
    [IsoId("_z5pPATpyEemk2e6qGBk8IQ")]
    [DisplayName("Financial Instrument Quantity")]
    [IsoXmlTag("FinInstrmQty")]
    public required FinancialInstrumentQuantity1Choice_ FinancialInstrumentQuantity { get; init; }

    /// <summary>
    /// Date at which the actual price for a financial instrument is fixed.
    /// </summary>
    [IsoId("_z5pPCTpyEemk2e6qGBk8IQ")]
    [DisplayName("Price Fixing Date")]
    [IsoXmlTag("PricFxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate PriceFixingDate { get; init; }
}
