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
[IsoId("_QLD-idp-Ed-ak6NoX_4Aeg_1423691963")]
[DisplayName("Foreign Exchange Terms")]
public partial record ForeignExchangeTerms7
{
    #nullable enable
    
    /// <summary>
    /// Cash amount resulting from a foreign exchange trade.
    /// </summary>
    [IsoId("_QLD-itp-Ed-ak6NoX_4Aeg_1432001062")]
    [DisplayName("To Amount")]
    [IsoXmlTag("ToAmt")]
    public ActiveCurrencyAnd13DecimalAmount? ToAmount { get; init; } 
    
    /// <summary>
    /// Cash amount for which a foreign exchange is required.
    /// </summary>
    [IsoId("_QLD-i9p-Ed-ak6NoX_4Aeg_1432001577")]
    [DisplayName("From Amount")]
    [IsoXmlTag("FrAmt")]
    public ActiveCurrencyAndAmount? FromAmount { get; init; } 
    
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_QLNvgNp-Ed-ak6NoX_4Aeg_1432002105")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public required ActiveOrHistoricCurrencyCode UnitCurrency { get; init; } 
    
    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    [IsoId("_QLNvgdp-Ed-ak6NoX_4Aeg_1432002508")]
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public required ActiveOrHistoricCurrencyCode QuotedCurrency { get; init; } 
    
    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_QLNvgtp-Ed-ak6NoX_4Aeg_1432003053")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    
    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    [IsoId("_QLNvg9p-Ed-ak6NoX_4Aeg_1432003636")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? QuotationDate { get; init; } 
    
    /// <summary>
    /// Party that proposes a foreign exchange rate.
    /// </summary>
    [IsoId("_QLNvhNp-Ed-ak6NoX_4Aeg_1432924152")]
    [DisplayName("Quoting Institution")]
    [IsoXmlTag("QtgInstn")]
    public PartyIdentification2Choice_? QuotingInstitution { get; init; } 
    
    
    #nullable disable
    
}
