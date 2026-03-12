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
[IsoId("_U36vM9p-Ed-ak6NoX_4Aeg_-1456785777")]
[DisplayName("Foreign Exchange Terms")]
public partial record ForeignExchangeTerms4
{
    #nullable enable
    
    /// <summary>
    /// Currency and amount bought in a foreign exchange trade. The buy amount is received by the buyer.
    /// </summary>
    [IsoId("_U36vNNp-Ed-ak6NoX_4Aeg_-1456784941")]
    [DisplayName("Buy Amount")]
    [IsoXmlTag("BuyAmt")]
    public ActiveCurrencyAnd13DecimalAmount? BuyAmount { get; init; } 
    
    /// <summary>
    /// Currency and amount sold in a foreign exchange trade. The sold amount is delivered by the buyer.
    /// </summary>
    [IsoId("_U36vNdp-Ed-ak6NoX_4Aeg_-1456784456")]
    [DisplayName("Sell Amount")]
    [IsoXmlTag("SellAmt")]
    public ActiveCurrencyAndAmount? SellAmount { get; init; } 
    
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_U36vNtp-Ed-ak6NoX_4Aeg_-1455864407")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public required CurrencyCode UnitCurrency { get; init; } 
    
    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    [IsoId("_U36vN9p-Ed-ak6NoX_4Aeg_-1455864210")]
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public required CurrencyCode QuotedCurrency { get; init; } 
    
    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_U36vONp-Ed-ak6NoX_4Aeg_-1455863880")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    
    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    [IsoId("_U4D5INp-Ed-ak6NoX_4Aeg_-1455863795")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? QuotationDate { get; init; } 
    
    /// <summary>
    /// Party that proposes a foreign exchange rate.
    /// </summary>
    [IsoId("_U4D5Idp-Ed-ak6NoX_4Aeg_-1455863297")]
    [DisplayName("Quoting Institution")]
    [IsoXmlTag("QtgInstn")]
    public PartyIdentification2Choice_? QuotingInstitution { get; init; } 
    
    
    #nullable disable
    
}
