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
/// Provides the additional information for an NDF as supplied on a fixing instruction.
/// </summary>
[IsoId("_-eNb8KZqEea16Jw8SEVrDQ")]
[DisplayName("Fixing Conditions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FixingConditions1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FixingConditions1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FixingConditions1( System.DateOnly reqTradeDate,System.String reqOriginatorReference,ActiveOrHistoricCurrencyAndAmount reqTradingSideBuyAmount,ActiveOrHistoricCurrencyAndAmount reqTradingSideSellAmount,System.Decimal reqExchangeRate )
    {
        TradeDate = reqTradeDate;
        OriginatorReference = reqOriginatorReference;
        TradingSideBuyAmount = reqTradingSideBuyAmount;
        TradingSideSellAmount = reqTradingSideSellAmount;
        ExchangeRate = reqExchangeRate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// The date on which the trade was executed.
    /// </summary>
    [IsoId("_Oe21EKZrEea16Jw8SEVrDQ")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate TradeDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly TradeDate { get; init; } 
    #else
    public System.DateOnly TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Represents the original reference of the instruction for which the status is given, as assigned by the participant that submitted the foreign exchange trade.
    /// </summary>
    [IsoId("_b4koM6ZrEea16Jw8SEVrDQ")]
    [DisplayName("Originator Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgtrRef")]
    #endif
    [IsoXmlTag("OrgtrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginatorReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginatorReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginatorReference { get; init; } 
    #else
    public System.String OriginatorReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference common to both parties of the trade.
    /// </summary>
    [IsoId("_b4koNKZrEea16Jw8SEVrDQ")]
    [DisplayName("Common Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmonRef")]
    #endif
    [IsoXmlTag("CmonRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CommonReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CommonReference { get; init; } 
    #else
    public System.String? CommonReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the identification of a previous event in the life of a trade which is amended or cancelled.
    /// </summary>
    [IsoId("_b4koNaZrEea16Jw8SEVrDQ")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RelatedReference { get; init; } 
    #else
    public System.String? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Currency and amount bought in a foreign exchange trade.
    /// </summary>
    [IsoId("_0g_IYqZrEea16Jw8SEVrDQ")]
    [DisplayName("Trading Side Buy Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSdBuyAmt")]
    #endif
    [IsoXmlTag("TradgSdBuyAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount TradingSideBuyAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount TradingSideBuyAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount TradingSideBuyAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount TradingSideBuyAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Currency and amount sold in a foreign exchange trade.
    /// </summary>
    [IsoId("_0g_IY6ZrEea16Jw8SEVrDQ")]
    [DisplayName("Trading Side Sell Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSdSellAmt")]
    #endif
    [IsoXmlTag("TradgSdSellAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount TradingSideSellAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount TradingSideSellAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount TradingSideSellAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount TradingSideSellAmount { get; set; } 
    #endif
    
    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_B_U80aZsEea16Jw8SEVrDQ")]
    [DisplayName("Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRate")]
    #endif
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal ExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal ExchangeRate { get; init; } 
    #else
    public System.Decimal ExchangeRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
