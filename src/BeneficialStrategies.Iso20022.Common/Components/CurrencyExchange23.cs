// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the details of the currency exchange.
/// </summary>
[IsoId("_23CooCrJEe2_XNkEScEJ5w")]
[DisplayName("Currency Exchange")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyExchange23
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CurrencyExchange23 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CurrencyExchange23( string reqCurrency )
    {
        Currency = reqCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the currency.
    /// </summary>
    [IsoId("_24kSoSrJEe2_XNkEScEJ5w")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode Currency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Currency { get; init; } 
    #else
    public string Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the exchange rate between the two currencies specified in the derivative transaction agreed by the counterparties at the inception of the transaction, expressed as the rate of exchange from converting the unit currency into the quoted currency.
    /// </summary>
    [IsoId("_24kSoyrJEe2_XNkEScEJ5w")]
    [DisplayName("Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRate")]
    #endif
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOne18Rate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOne18Rate? ExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ExchangeRate { get; init; } 
    #else
    public System.Decimal? ExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Forward exchange rate as agreed between the counterparties in the contractual agreement, expressed as a price of base currency in the quoted currency.
    /// </summary>
    [IsoId("_24kSpSrJEe2_XNkEScEJ5w")]
    [DisplayName("Forward Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FwdXchgRate")]
    #endif
    [IsoXmlTag("FwdXchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOne18Rate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOne18Rate? ForwardExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ForwardExchangeRate { get; init; } 
    #else
    public System.Decimal? ForwardExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates, for equity options, commodity options and similar products, the currency in which the strike price is denominated.  In case of foreign exchange options, indicates the currency pair and order in which the strike price is expressed as unit currency and quoted currency.
    /// </summary>
    [IsoId("_24kSpyrJEe2_XNkEScEJ5w")]
    [DisplayName("Exchange Rate Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRateBsis")]
    #endif
    [IsoXmlTag("XchgRateBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExchangeRateBasis1Choice_? ExchangeRateBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangeRateBasis1Choice_? ExchangeRateBasis { get; init; } 
    #else
    public ExchangeRateBasis1Choice_? ExchangeRateBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date when a derivative will fix against an interest rate or an exchange rate that will be used to compute the cash settlement.
    /// </summary>
    [IsoId("_24kSqSrJEe2_XNkEScEJ5w")]
    [DisplayName("Fixing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FxgDt")]
    #endif
    [IsoXmlTag("FxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? FixingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? FixingDate { get; init; } 
    #else
    public System.DateTime? FixingDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
