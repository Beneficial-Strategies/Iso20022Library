// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount, currency, exchange rate and quotation date.
/// </summary>
[IsoId("_shQi4ESGEeeb1MmUPTrSMw")]
[DisplayName("Amount")]
public partial record Amount4
{
    #nullable enable
    
    /// <summary>
    /// Amount exclusive of currency.
    /// </summary>
    [IsoId("_H_0w0ESHEeeb1MmUPTrSMw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Currency code associated with the applicable type of amount.  ISO 4217 &quot;Codes for the representation of currencies and funds&quot;.
    /// </summary>
    [IsoId("_P33rIESHEeeb1MmUPTrSMw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// The factor used in the conversion from one amount to another amount.
    /// </summary>
    [IsoId("_0rnfwESHEeeb1MmUPTrSMw")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ExchangeRate { get; init; } 
    
    /// <summary>
    /// Date and time at which the exchange rate has been quoted.
    /// </summary>
    [IsoId("_8tPM0ESHEeeb1MmUPTrSMw")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? QuotationDate { get; init; } 
    
    
    #nullable disable
    
}
