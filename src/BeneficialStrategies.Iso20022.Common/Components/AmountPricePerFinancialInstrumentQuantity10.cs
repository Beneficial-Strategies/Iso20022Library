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
[IsoId("_HuURSRuyEeyhRdHRjakS2w")]
[DisplayName("Amount Price Per Financial Instrument Quantity")]
public record AmountPricePerFinancialInstrumentQuantity10
{
    /// <summary>
    /// Type of amount price.
    /// </summary>
    [IsoId("_IDLG0RuyEeyhRdHRjakS2w")]
    [DisplayName("Amount Price Type")]
    [IsoXmlTag("AmtPricTp")]
    public required AmountPriceType1Code AmountPriceType { get; init; }

    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_IDLG2RuyEeyhRdHRjakS2w")]
    [DisplayName("Price Value")]
    [IsoXmlTag("PricVal")]
    public required ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; }

    /// <summary>
    /// Quantity of financial instrument.
    /// </summary>
    [IsoId("_IDLG4RuyEeyhRdHRjakS2w")]
    [DisplayName("Financial Instrument Quantity")]
    [IsoXmlTag("FinInstrmQty")]
    public required FinancialInstrumentQuantity33Choice_ FinancialInstrumentQuantity { get; init; }
}
