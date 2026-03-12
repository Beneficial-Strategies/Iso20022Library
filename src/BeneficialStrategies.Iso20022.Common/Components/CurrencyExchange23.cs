// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the details of the currency exchange.
/// </summary>
[IsoId("_23CooCrJEe2_XNkEScEJ5w")]
[DisplayName("Currency Exchange")]
public partial record CurrencyExchange23
{
    #nullable enable
    
    /// <summary>
    /// Indicates the currency.
    /// </summary>
    [IsoId("_24kSoSrJEe2_XNkEScEJ5w")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveOrHistoricCurrencyCode Currency { get; init; } 
    
    /// <summary>
    /// Indicates the exchange rate between the two currencies specified in the derivative transaction agreed by the counterparties at the inception of the transaction, expressed as the rate of exchange from converting the unit currency into the quoted currency.
    /// </summary>
    [IsoId("_24kSoyrJEe2_XNkEScEJ5w")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOne18Rate)]
    public IsoBaseOne18Rate? ExchangeRate { get; init; } 
    
    /// <summary>
    /// Forward exchange rate as agreed between the counterparties in the contractual agreement, expressed as a price of base currency in the quoted currency.
    /// </summary>
    [IsoId("_24kSpSrJEe2_XNkEScEJ5w")]
    [DisplayName("Forward Exchange Rate")]
    [IsoXmlTag("FwdXchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOne18Rate)]
    public IsoBaseOne18Rate? ForwardExchangeRate { get; init; } 
    
    /// <summary>
    /// Indicates, for equity options, commodity options and similar products, the currency in which the strike price is denominated.  In case of foreign exchange options, indicates the currency pair and order in which the strike price is expressed as unit currency and quoted currency.
    /// </summary>
    [IsoId("_24kSpyrJEe2_XNkEScEJ5w")]
    [DisplayName("Exchange Rate Basis")]
    [IsoXmlTag("XchgRateBsis")]
    public ExchangeRateBasis1Choice_? ExchangeRateBasis { get; init; } 
    
    /// <summary>
    /// Specifies the date when a derivative will fix against an interest rate or an exchange rate that will be used to compute the cash settlement.
    /// </summary>
    [IsoId("_24kSqSrJEe2_XNkEScEJ5w")]
    [DisplayName("Fixing Date")]
    [IsoXmlTag("FxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? FixingDate { get; init; } 
    
    
    #nullable disable
    
}
