// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed to process a currency exchange or conversion.
/// </summary>
[IsoId("_U4D5KNp-Ed-ak6NoX_4Aeg_1699918074")]
[DisplayName("Foreign Exchange Terms")]
public partial record ForeignExchangeTerms3
{
    #nullable enable
    
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_U4NqINp-Ed-ak6NoX_4Aeg_1784878550")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public required CurrencyCode UnitCurrency { get; init; } 
    
    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    [IsoId("_U4NqIdp-Ed-ak6NoX_4Aeg_1787649177")]
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public required CurrencyCode QuotedCurrency { get; init; } 
    
    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_U4NqItp-Ed-ak6NoX_4Aeg_1787652010")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    
    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    [IsoId("_U4NqI9p-Ed-ak6NoX_4Aeg_1787652243")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? QuotationDate { get; init; } 
    
    /// <summary>
    /// Party that proposes a foreign exchange rate.
    /// </summary>
    [IsoId("_U4NqJNp-Ed-ak6NoX_4Aeg_1788572725")]
    [DisplayName("Quoting Institution")]
    [IsoXmlTag("QtgInstn")]
    public PartyIdentification1Choice_? QuotingInstitution { get; init; } 
    
    
    #nullable disable
    
}
