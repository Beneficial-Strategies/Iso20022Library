// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a ratio: amount price per financial instrument quantity.
/// </summary>
[IsoId("_pVBYl0ELEeWVgfuHGaKtRQ")]
[DisplayName("Amount Price Per Financial Instrument Quantity")]
public partial record AmountPricePerFinancialInstrumentQuantity6
{
    #nullable enable
    
    /// <summary>
    /// Type of amount price.
    /// </summary>
    [IsoId("_phXyU0ELEeWVgfuHGaKtRQ")]
    [DisplayName("Amount Price Type")]
    [IsoXmlTag("AmtPricTp")]
    public required AmountPriceType1Code AmountPriceType { get; init; } 
    
    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_phXyW0ELEeWVgfuHGaKtRQ")]
    [DisplayName("Price Value")]
    [IsoXmlTag("PricVal")]
    public required ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
    
    /// <summary>
    /// Quantity of financial instrument.
    /// </summary>
    [IsoId("_phXyY0ELEeWVgfuHGaKtRQ")]
    [DisplayName("Financial Instrument Quantity")]
    [IsoXmlTag("FinInstrmQty")]
    public required FinancialInstrumentQuantity1Choice_ FinancialInstrumentQuantity { get; init; } 
    
    
    #nullable disable
    
}
