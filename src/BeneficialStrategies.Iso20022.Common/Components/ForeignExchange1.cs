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
/// Provides the details of the foreign exchange.
/// </summary>
[IsoId("_8F9mqLu7EeSXxOgurgHGgw")]
[DisplayName("Foreign Exchange")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ForeignExchange1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ForeignExchange1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForeignExchange1( string reqForeignCurrency,System.Decimal reqExchangeSpotRate,System.UInt64 reqExchangeForwardPoint )
    {
        ForeignCurrency = reqForeignCurrency;
        ExchangeSpotRate = reqExchangeSpotRate;
        ExchangeForwardPoint = reqExchangeForwardPoint;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency into which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_8F9mrLu7EeSXxOgurgHGgw")]
    [DisplayName("Foreign Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrgnCcy")]
    #endif
    [IsoXmlTag("FrgnCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode ForeignCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ForeignCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ForeignCurrency { get; init; } 
    #else
    public string ForeignCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Foreign exchange rate between the source and the foreign currency applicable to the first leg of the FX swap transaction. The foreign exchange spot rate will be reported as the number of foreign currency units per one unit of the source currency.
    /// </summary>
    [IsoId("_8F9mq7u7EeSXxOgurgHGgw")]
    [DisplayName("Exchange Spot Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgSpotRate")]
    #endif
    [IsoXmlTag("XchgSpotRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoBaseOneRate ExchangeSpotRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal ExchangeSpotRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal ExchangeSpotRate { get; init; } 
    #else
    public System.Decimal ExchangeSpotRate { get; set; } 
    #endif
    
    /// <summary>
    /// Difference between the foreign exchange spot rate and the foreign exchange forward rate expressed in basis points quoted in accordance with the prevailing market conventions for the currency pair. 
    /// Usage:
    /// This value can be either positive or negative.
    /// </summary>
    [IsoId("_c1A2wLu8EeSXxOgurgHGgw")]
    [DisplayName("Exchange Forward Point")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgFwdPt")]
    #endif
    [IsoXmlTag("XchgFwdPt")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoDecimalNumber ExchangeForwardPoint { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 ExchangeForwardPoint { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 ExchangeForwardPoint { get; init; } 
    #else
    public System.UInt64 ExchangeForwardPoint { get; set; } 
    #endif
    
    
    #nullable disable
    
}
