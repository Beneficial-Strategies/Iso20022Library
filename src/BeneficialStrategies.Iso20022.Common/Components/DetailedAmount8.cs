// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed amounts associated with the total amount of transaction.
/// </summary>
[IsoId("__NLEUXsyEeSTS7uHCe8FPQ")]
[DisplayName("Detailed Amount")]
public partial record DetailedAmount8
{
    #nullable enable
    
    /// <summary>
    /// Amount after the currency exchange.
    /// It corresponds to ISO 8583 field number 6, completed by the field number 51 for the versions 87 and 93.
    /// </summary>
    [IsoId("__az3sXsyEeSTS7uHCe8FPQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Exchange rate to the currency of the amount.
    /// It corresponds to ISO 8583 field number 10.
    /// </summary>
    [IsoId("_Q68toHszEeSTS7uHCe8FPQ")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    
    /// <summary>
    /// Date and time at which the exchange rate has been quoted.
    /// </summary>
    [IsoId("_WdkBoHszEeSTS7uHCe8FPQ")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? QuotationDate { get; init; } 
    
    /// <summary>
    /// Text to display on the cardholder or to print on the cardholder bank statement.
    /// </summary>
    [IsoId("__az3s3syEeSTS7uHCe8FPQ")]
    [DisplayName("Label")]
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Label { get; init; } 
    
    
    #nullable disable
    
}
